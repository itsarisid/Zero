
using Connector.DbEntities;
using Connector.Models;
using Connector.Repositories;
using Connector.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Connector.Client
{
    public partial class frmRestClient : Form
    {
        private readonly IService<ApiDetail> apiDetailService;
        private readonly IService<ApiRequest> apiRequestService;
        public frmRestClient()
        {
            InitializeComponent();
            cmbMethod.DataSource = Enum.GetValues(typeof(Method));
            cmbReqMethod.DataSource = Enum.GetValues(typeof(Method));
            cmbAuthType.DataSource = Enum.GetValues(typeof(AuthenticatorType));
            cmbRequestBodyType.DataSource = Enum.GetValues(typeof(RequestBodyType));
            //cmbContentType.DataSource = Enum.GetValues(typeof(ContentType));
            apiDetailService = new Service<ApiDetail>(new Repository<ApiDetail>());
            apiRequestService = new Service<ApiRequest>(new Repository<ApiRequest>());
            btnSave.Enabled = false;
        }

        private void frmRestClient_Load(object sender, EventArgs e)
        {

        }
        private void trOutput_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private ApiDetail GetApiDetail() => new ApiDetail
        {
            Name = txtName.Text,
            AuthUrl = txtAuthUrl.Text,
            Method = cmbMethod.SelectedValue.ToString(),
            AuthType = cmbAuthType.SelectedValue.ToString(),
            ConsumerKey = txtKey.Text,
            ConsumerSecret = txtSecret.Text,
            UserName = txtKey.Text,
            Password = txtSecret.Text,
            OauthToken = txtKey.Text,
            OauthTokenSecret = txtSecret.Text,
            Token = txtToken.Text,
            Apikey = txtToken.Text,
            CreatedDate = DateTime.Now,
            IsActive = true,
        };

        private ApiRequest GetApiRequest() => new ApiRequest
        {
            BaseUrl = txtBaseUrl.Text,
            ResourceUrl = txtResourceUrl.Text,
            NextUrl = txtNextUrl.Text,
            Body = rtxBody.Text,
            ContentType = cmbRequestBodyType.SelectedValue.ToString(),
            Headers = dataGridViewHeader.Rows.ConvertToHeader(),
            QueryParameters = dataGridViewQueryParameters.Rows.ConvertToQueryParameters(),
            CreatedDate = DateTime.Now,
            IsActive = true,
        };



        private async void btnSave_Click(object sender, EventArgs e)
        {
            var apiDetail = GetApiDetail();

            var details = await apiDetailService.AddAsync(apiDetail);

            var apiRequest = GetApiRequest();
            apiRequest.ApiId = details.Id;

            _ = await apiRequestService.AddAsync(apiRequest);
        }

        private void btnAuthGo_Click(object sender, EventArgs e)
        {
            var apiDetail = GetApiDetail();
            var request = GetApiRequest();

            var executer = new RequestExecuter
            {
                validateRequest = new ValidateRequestParam
                {
                    ApiDetail = apiDetail,
                    ApiRequest = request,
                }
            };


            //var data = executer.Initialize().Run();
            var data = executer.Validate().Run();
            if (string.IsNullOrEmpty(data))
            {
                Utilities.JsonToTreeview(trOutput, data, "root");
            }
            //trOutput.ExpandAll();
        }

        private void trOutput_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var ancestorsAndSelf = e.Node.FullPath.Split(trOutput.PathSeparator.ToCharArray());
            string node = string.Join(".", ancestorsAndSelf);
            txtNextUrl.Text = node;
            btnSave.Enabled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //TODO Call to run All Request.
        }

        private void dataGridViewHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}