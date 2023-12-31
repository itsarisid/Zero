﻿using Connector.APIHelper.APIRequest;
using Connector.APIHelper.Client;
using Connector.APIHelper.Command;
using Connector.APIHelper;
using RestSharp;
using System.Net;
using Connector.Client;
using Connector.Models;
using Connector.APIHelper.Interface;
using Serilog;
using System.Collections.Concurrent;
using Connector.APIHelper.APIResponse;
using System.Collections.Generic;
using Connector.DbEntities;
using Connector.Services;
using Connector.Repositories;
using Azure.Core;
using System.Linq;
using System.Reflection.PortableExecutable;
using Newtonsoft.Json.Linq;
using System.Runtime;
using Azure;
using Microsoft.AspNetCore.DataProtection;
using System.Security.Policy;
using System.Net.Sockets;

namespace Connector
{
    public class AppConnector
    {
        private readonly IService<ApiDetail> apiDetailService;
        private readonly IService<ApiRequest> apiRequestService;
        private readonly IService<Header> apiHeaderService;
        private readonly IService<DbEntities.QueryParameter> apiQueryService;
        private AppSettings? settings;

        public AppConnector(AppSettings? _settings)
        {
            settings = _settings;

            apiDetailService = new Service<ApiDetail>(new Repository<ApiDetail>());
            apiRequestService = new Service<ApiRequest>(new Repository<ApiRequest>());
            apiHeaderService = new Service<Header>(new Repository<Header>());
            apiQueryService = new Service<DbEntities.QueryParameter>(new Repository<DbEntities.QueryParameter>());
        }
        /// <summary>Main program runner</summary>
        /// <exception cref="System.ArgumentNullException">BaseUrl</exception>
        /// <exception cref="System.Exception">Error with status code: {response.StatusCode}</exception>
        public void Run()
        {
            if (string.IsNullOrEmpty(settings?.BaseUrl)) throw new ArgumentNullException(nameof(settings.BaseUrl));

            IClient _client = new DefaultClient(new RestClientOptions()
            {
                ThrowOnAnyError = true,
                BaseUrl = new Uri(settings.BaseUrl),
                MaxTimeout = -1,
                Authenticator = new ApiAuthenticator(settings.AuthenticationParameter).Authenticate(settings.AuthenticatorType)
            });

            RestApiExecutor apiExecutor = new();

            foreach (var request in settings.Requests)
            {
                if (request.Page != null)
                {
                    WithPagination(apiExecutor, _client, request);
                }
                else
                {
                    ProcessRequest(apiExecutor, _client, request);
                }
            }

            _client.Dispose();
        }

        public void Execute()
        {
            var apiDetails = apiDetailService.GetAll();
            foreach (var api in apiDetails)
            {
                var requests = apiRequestService.FindBy(x => x.ApiId == api.Id && x.IsSuccessful == false);
                foreach (var request in requests)
                {
                    var authType = api.AuthType.ToEnum<AuthenticatorType>(AuthenticatorType.None);

                    var authParam = new AuthenticationParameter
                    {
                        Token = api.Token,
                        ConsumerKey = api.ConsumerKey,
                        ConsumerSecret = api.ConsumerSecret,
                        OAuthToken = api.OauthToken,
                        OAuthTokenSecret = api.OauthTokenSecret,
                        UserName = api.UserName,
                        Password = api.Password,
                        APIKey = api.Apikey,
                        URL = api.AuthUrl
                    };

                    request.Headers = apiHeaderService.FindBy(x => x.ReqId == request.Id).ToList();
                    request.QueryParameters = apiQueryService.FindBy(x => x.ReqId == request.Id).ToList();

                    var _client = new DefaultClient(new RestClientOptions()
                    {
                        ThrowOnAnyError = true,
                        BaseUrl = new Uri(request.BaseUrl),
                        MaxTimeout = -1,
                        Authenticator = new ApiAuthenticator(authParam).Authenticate(authType)
                    });

                    RestApiExecutor apiExecutor = new();

                    var headers = Utility.ConvertToKeyValue<Header>(request.Headers);
                    var parameters = Utility.ConvertToKeyValue<DbEntities.QueryParameter>(request.QueryParameters);

                    var requestModel = new RequestModel
                    {
                        Method = request.Method.ToEnum<Method>(Method.Get),
                        Uri = request.ResourceUrl ?? "",
                        Headers = headers,
                        Parameters = parameters,
                        NextUrl = request.NextUrl
                    };

                    ProcessRequest(apiExecutor, _client, requestModel);

                    request.IsSuccessful = true;

                    apiRequestService.UpdateAsync(request);

                    _client.Dispose();


                }
            }
        }


        /// <summary>
        /// Runs the pagination.
        /// </summary>
        /// <param name="executor">The executor.</param>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">Page</exception>
        public void WithPagination(RestApiExecutor executor, IClient client, RequestModel request)
        {
            var page = request.Page ?? throw new ArgumentNullException(nameof(request.Page));

            var parameters = new List<KeyValueParameter>
            {
                page.Size,
                page.Number
            };

            for (int i = 1; i <= page.Total; i++)
            {
                //TODO: Call with paging until reach last page.

                //Update page number.
                var newList = parameters.Where(w => w.Key != page.Number.Key).ToList();
                newList.Add(new KeyValueParameter
                {
                    Key = page.Number.Key,
                    Value = i.ToString()
                });

                request.Parameters = newList;

                ProcessRequest(executor, client, request);
            }
        }

        /// <summary>Runs the asynchronous.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        /// <exception cref="System.ArgumentNullException">BaseUrl</exception>
        public async Task RunAsync()
        {
            if (string.IsNullOrEmpty(settings?.BaseUrl)) throw new ArgumentNullException(nameof(settings.BaseUrl));

            IClient _client = new DefaultClient(new RestClientOptions()
            {
                ThrowOnAnyError = true,
                BaseUrl = new Uri(settings.BaseUrl),
                MaxTimeout = -1,
                Authenticator = new ApiAuthenticator(settings.AuthenticationParameter).Authenticate(settings.AuthenticatorType)
            });

            RestApiExecutor apiExecutor = new();

            ConcurrentBag<string> response = new();

            //Note: Call API 
            await Parallel.ForEachAsync(settings.Requests, async (request, cancellationToken) =>
            {
                ProcessRequest(apiExecutor, _client, request);
            });
        }

        /// <summary>Processes the request.</summary>
        /// <param name="apiExecutor">The API executor.</param>
        /// <param name="client">The client.</param>
        /// <param name="requestModel">The request model.</param>
        /// <exception cref="System.Exception">Error with status code: {statusCode}</exception>
        private string ProcessRequest(RestApiExecutor apiExecutor, IClient client, RequestModel requestModel)
        {
            RequestBuilder requestBuilder = new(requestModel);
            string _data = string.Empty;

            // Create request
            var request = requestBuilder.BuildRequest();

            ICommand getCommand = new RequestCommand(request, client);

            apiExecutor.SetCommand(getCommand);

            var response = apiExecutor.ExecuteRequest();

            var statusCode = response.GetHttpStatusCode();
            try
            {
                Thread.Sleep(250);

                int tries = 0;
                int maxTries = 25;
                while (statusCode != HttpStatusCode.OK && tries < maxTries)
                {
                    Log.Logger.Error($"Error with status code: {statusCode}");
                    if (statusCode == HttpStatusCode.Unauthorized || statusCode == HttpStatusCode.Forbidden)
                    {
                        response = apiExecutor.ExecuteRequest();
                        statusCode = response.GetHttpStatusCode();
                        tries++;
                        Log.Logger.Warning("APIConnection", $"UNAUTHORIZED USER ERROR: {statusCode} ");
                    }
                    else if (statusCode == HttpStatusCode.InternalServerError || statusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        Thread.Sleep(250);  //Sleep for 1/4 a second
                        response = apiExecutor.ExecuteRequest();
                        statusCode = response.GetHttpStatusCode();
                        tries++;
                        Log.Logger.Warning("APIConnection", $"CONNECTION ERROR: {statusCode} ");
                    }
                    else
                    {
                        response = apiExecutor.ExecuteRequest();
                        statusCode = response.GetHttpStatusCode();

                        tries++;
                        Log.Logger.Warning("APIConnection", $"OTHER ERROR: {statusCode}");
                    }
                }

                if (statusCode != HttpStatusCode.OK && tries >= maxTries)
                {
                    Log.Logger.Warning("APIConnection", "NO RESPONSE AFTER MAX RETRIES: ");
                    Environment.Exit(0);
                }
            

                if (statusCode == HttpStatusCode.OK)
                {
                    _data = response.GetResponseData();

                    Log.Logger.Information("Status OK");
                    var path = string.IsNullOrEmpty(settings?.OutputDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : settings.OutputDirectory;

                    path = $"{path}\\{requestModel.Uri.GetEndpointName()}.json";

                    //Save file in JSON
                    response.SaveInFile(path);

                    var json = JToken.Parse(_data);

                    var nexturl = json.SelectToken(requestModel.NextUrl).ToString();

                    while (nexturl != null)
                    {
                        requestModel.Uri = nexturl;
                        ProcessRequest(apiExecutor, client, requestModel);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Logger.Error("APIConnection", "NO RESPONSE AFTER MAX RETRIES: ", ex);
            }
            return _data;
        }
    }
}
