using Connector.Entities;
using Connector.Repositories;
using Connector.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connector.Client
{
    public partial class JsonLoaderForm : Form
    {
        private readonly IService<ApiDetail> apiDetailService;
        private readonly IService<ApiRequest> apiRequestService;

        public JsonLoaderForm()
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

        private void btnAuthGo_Click(object sender, EventArgs e)
        {

        }
    }
}
