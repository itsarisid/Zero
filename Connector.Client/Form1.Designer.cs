namespace Connector.Client
{
    partial class frmRestClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMethod = new Label();
            cmbMethod = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            txtAuthUrl = new TextBox();
            lblAuthUrl = new Label();
            cmbAuthType = new ComboBox();
            lblAuthType = new Label();
            txtKey = new TextBox();
            txtSecret = new TextBox();
            txtToken = new TextBox();
            lblKey = new Label();
            lblSecret = new Label();
            lblToken = new Label();
            txtBaseUrl = new TextBox();
            lblBaseUrl = new Label();
            txtResourceUrl = new TextBox();
            lblResourceUrl = new Label();
            trOutput = new TreeView();
            lblResponseOutput = new Label();
            txtNextUrl = new TextBox();
            lblNextUrl = new Label();
            btnAuthGo = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            cmbContentType = new ComboBox();
            lblContentType = new Label();
            groupBox2 = new GroupBox();
            cmbRequestBodyType = new ComboBox();
            lblRequetBodyType = new Label();
            tabControlReq = new TabControl();
            tabReqHeadersPage = new TabPage();
            dataGridViewHeader = new DataGridView();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            tabReqQueryParametersPage = new TabPage();
            dataGridView1 = new DataGridView();
            tabReqBodyPage = new TabPage();
            rtxBody = new RichTextBox();
            cmbReqMethod = new ComboBox();
            lblReqMethod = new Label();
            btnRun = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControlReq.SuspendLayout();
            tabReqHeadersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHeader).BeginInit();
            tabReqQueryParametersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabReqBodyPage.SuspendLayout();
            SuspendLayout();
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(6, 80);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(49, 15);
            lblMethod.TabIndex = 0;
            lblMethod.Text = "Method";
            // 
            // cmbMethod
            // 
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Location = new Point(80, 77);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(117, 23);
            cmbMethod.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 19);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(394, 23);
            txtName.TabIndex = 3;
            // 
            // txtAuthUrl
            // 
            txtAuthUrl.Location = new Point(80, 28);
            txtAuthUrl.Name = "txtAuthUrl";
            txtAuthUrl.PlaceholderText = "Auth URL";
            txtAuthUrl.Size = new Size(395, 23);
            txtAuthUrl.TabIndex = 5;
            // 
            // lblAuthUrl
            // 
            lblAuthUrl.AutoSize = true;
            lblAuthUrl.Location = new Point(3, 31);
            lblAuthUrl.Name = "lblAuthUrl";
            lblAuthUrl.Size = new Size(57, 15);
            lblAuthUrl.TabIndex = 4;
            lblAuthUrl.Text = "Auth URL";
            // 
            // cmbAuthType
            // 
            cmbAuthType.FormattingEnabled = true;
            cmbAuthType.Location = new Point(80, 124);
            cmbAuthType.Name = "cmbAuthType";
            cmbAuthType.Size = new Size(117, 23);
            cmbAuthType.TabIndex = 7;
            // 
            // lblAuthType
            // 
            lblAuthType.AutoSize = true;
            lblAuthType.Location = new Point(10, 127);
            lblAuthType.Name = "lblAuthType";
            lblAuthType.Size = new Size(60, 15);
            lblAuthType.TabIndex = 6;
            lblAuthType.Text = "Auth Type";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(80, 175);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Key";
            txtKey.Size = new Size(167, 23);
            txtKey.TabIndex = 8;
            // 
            // txtSecret
            // 
            txtSecret.Location = new Point(348, 175);
            txtSecret.Name = "txtSecret";
            txtSecret.PlaceholderText = "Secret";
            txtSecret.Size = new Size(127, 23);
            txtSecret.TabIndex = 9;
            // 
            // txtToken
            // 
            txtToken.Location = new Point(80, 216);
            txtToken.Name = "txtToken";
            txtToken.PlaceholderText = "Token";
            txtToken.Size = new Size(395, 23);
            txtToken.TabIndex = 10;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(8, 178);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(26, 15);
            lblKey.TabIndex = 11;
            lblKey.Text = "Key";
            // 
            // lblSecret
            // 
            lblSecret.AutoSize = true;
            lblSecret.Location = new Point(277, 178);
            lblSecret.Name = "lblSecret";
            lblSecret.Size = new Size(39, 15);
            lblSecret.TabIndex = 12;
            lblSecret.Text = "Secret";
            // 
            // lblToken
            // 
            lblToken.AutoSize = true;
            lblToken.Location = new Point(5, 219);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(38, 15);
            lblToken.TabIndex = 13;
            lblToken.Text = "Token";
            // 
            // txtBaseUrl
            // 
            txtBaseUrl.Location = new Point(129, 30);
            txtBaseUrl.Name = "txtBaseUrl";
            txtBaseUrl.PlaceholderText = "Base URL";
            txtBaseUrl.Size = new Size(351, 23);
            txtBaseUrl.TabIndex = 15;
            // 
            // lblBaseUrl
            // 
            lblBaseUrl.AutoSize = true;
            lblBaseUrl.Location = new Point(18, 30);
            lblBaseUrl.Name = "lblBaseUrl";
            lblBaseUrl.Size = new Size(55, 15);
            lblBaseUrl.TabIndex = 14;
            lblBaseUrl.Text = "Base URL";
            // 
            // txtResourceUrl
            // 
            txtResourceUrl.Location = new Point(129, 76);
            txtResourceUrl.Name = "txtResourceUrl";
            txtResourceUrl.PlaceholderText = "Resource URL";
            txtResourceUrl.Size = new Size(351, 23);
            txtResourceUrl.TabIndex = 17;
            // 
            // lblResourceUrl
            // 
            lblResourceUrl.AutoSize = true;
            lblResourceUrl.Location = new Point(18, 79);
            lblResourceUrl.Name = "lblResourceUrl";
            lblResourceUrl.Size = new Size(79, 15);
            lblResourceUrl.TabIndex = 16;
            lblResourceUrl.Text = "Resource URL";
            // 
            // trOutput
            // 
            trOutput.Location = new Point(25, 323);
            trOutput.Name = "trOutput";
            trOutput.Size = new Size(484, 306);
            trOutput.TabIndex = 18;
            trOutput.AfterSelect += trOutput_AfterSelect;
            trOutput.NodeMouseClick += trOutput_NodeMouseClick;
            // 
            // lblResponseOutput
            // 
            lblResponseOutput.AutoSize = true;
            lblResponseOutput.Location = new Point(25, 305);
            lblResponseOutput.Name = "lblResponseOutput";
            lblResponseOutput.Size = new Size(98, 15);
            lblResponseOutput.TabIndex = 19;
            lblResponseOutput.Text = "Response Output";
            // 
            // txtNextUrl
            // 
            txtNextUrl.Location = new Point(129, 545);
            txtNextUrl.Name = "txtNextUrl";
            txtNextUrl.PlaceholderText = "Next Page URL";
            txtNextUrl.Size = new Size(347, 23);
            txtNextUrl.TabIndex = 21;
            // 
            // lblNextUrl
            // 
            lblNextUrl.AutoSize = true;
            lblNextUrl.Location = new Point(14, 545);
            lblNextUrl.Name = "lblNextUrl";
            lblNextUrl.Size = new Size(56, 15);
            lblNextUrl.TabIndex = 20;
            lblNextUrl.Text = "Next URL";
            // 
            // btnAuthGo
            // 
            btnAuthGo.Location = new Point(922, 22);
            btnAuthGo.Name = "btnAuthGo";
            btnAuthGo.Size = new Size(75, 23);
            btnAuthGo.TabIndex = 22;
            btnAuthGo.Text = "Validate";
            btnAuthGo.UseVisualStyleBackColor = true;
            btnAuthGo.Click += btnAuthGo_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(841, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(760, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbContentType);
            groupBox1.Controls.Add(lblContentType);
            groupBox1.Controls.Add(lblToken);
            groupBox1.Controls.Add(lblSecret);
            groupBox1.Controls.Add(lblKey);
            groupBox1.Controls.Add(txtToken);
            groupBox1.Controls.Add(txtSecret);
            groupBox1.Controls.Add(txtKey);
            groupBox1.Controls.Add(cmbAuthType);
            groupBox1.Controls.Add(lblAuthType);
            groupBox1.Controls.Add(txtAuthUrl);
            groupBox1.Controls.Add(lblAuthUrl);
            groupBox1.Controls.Add(cmbMethod);
            groupBox1.Controls.Add(lblMethod);
            groupBox1.Location = new Point(25, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 259);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Authentication";
            // 
            // cmbContentType
            // 
            cmbContentType.FormattingEnabled = true;
            cmbContentType.Location = new Point(307, 77);
            cmbContentType.Name = "cmbContentType";
            cmbContentType.Size = new Size(168, 23);
            cmbContentType.TabIndex = 15;
            // 
            // lblContentType
            // 
            lblContentType.AutoSize = true;
            lblContentType.Location = new Point(208, 80);
            lblContentType.Name = "lblContentType";
            lblContentType.Size = new Size(79, 15);
            lblContentType.TabIndex = 14;
            lblContentType.Text = "Content-Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbRequestBodyType);
            groupBox2.Controls.Add(lblRequetBodyType);
            groupBox2.Controls.Add(tabControlReq);
            groupBox2.Controls.Add(cmbReqMethod);
            groupBox2.Controls.Add(txtNextUrl);
            groupBox2.Controls.Add(lblReqMethod);
            groupBox2.Controls.Add(lblNextUrl);
            groupBox2.Controls.Add(txtResourceUrl);
            groupBox2.Controls.Add(lblResourceUrl);
            groupBox2.Controls.Add(txtBaseUrl);
            groupBox2.Controls.Add(lblBaseUrl);
            groupBox2.Location = new Point(515, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 585);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resource";
            // 
            // cmbRequestBodyType
            // 
            cmbRequestBodyType.FormattingEnabled = true;
            cmbRequestBodyType.Location = new Point(342, 118);
            cmbRequestBodyType.Name = "cmbRequestBodyType";
            cmbRequestBodyType.Size = new Size(138, 23);
            cmbRequestBodyType.TabIndex = 29;
            // 
            // lblRequetBodyType
            // 
            lblRequetBodyType.AutoSize = true;
            lblRequetBodyType.Location = new Point(261, 121);
            lblRequetBodyType.Name = "lblRequetBodyType";
            lblRequetBodyType.Size = new Size(61, 15);
            lblRequetBodyType.TabIndex = 28;
            lblRequetBodyType.Text = "Body Type";
            // 
            // tabControlReq
            // 
            tabControlReq.Controls.Add(tabReqHeadersPage);
            tabControlReq.Controls.Add(tabReqQueryParametersPage);
            tabControlReq.Controls.Add(tabReqBodyPage);
            tabControlReq.Location = new Point(18, 174);
            tabControlReq.Multiline = true;
            tabControlReq.Name = "tabControlReq";
            tabControlReq.SelectedIndex = 0;
            tabControlReq.Size = new Size(462, 365);
            tabControlReq.SizeMode = TabSizeMode.FillToRight;
            tabControlReq.TabIndex = 27;
            // 
            // tabReqHeadersPage
            // 
            tabReqHeadersPage.Controls.Add(dataGridViewHeader);
            tabReqHeadersPage.Location = new Point(4, 24);
            tabReqHeadersPage.Name = "tabReqHeadersPage";
            tabReqHeadersPage.Padding = new Padding(3);
            tabReqHeadersPage.Size = new Size(454, 337);
            tabReqHeadersPage.TabIndex = 0;
            tabReqHeadersPage.Text = "Headers";
            tabReqHeadersPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHeader
            // 
            dataGridViewHeader.AllowUserToOrderColumns = true;
            dataGridViewHeader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHeader.Columns.AddRange(new DataGridViewColumn[] { Key, Value });
            dataGridViewHeader.Location = new Point(6, 7);
            dataGridViewHeader.Name = "dataGridViewHeader";
            dataGridViewHeader.RowTemplate.Height = 25;
            dataGridViewHeader.Size = new Size(440, 327);
            dataGridViewHeader.TabIndex = 0;
            dataGridViewHeader.CellContentClick += dataGridViewHeader_CellContentClick;
            // 
            // Key
            // 
            Key.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Key.HeaderText = "Key";
            Key.Name = "Key";
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Value.HeaderText = "Values";
            Value.Name = "Value";
            // 
            // tabReqQueryParametersPage
            // 
            tabReqQueryParametersPage.Controls.Add(dataGridView1);
            tabReqQueryParametersPage.Location = new Point(4, 24);
            tabReqQueryParametersPage.Name = "tabReqQueryParametersPage";
            tabReqQueryParametersPage.Padding = new Padding(3);
            tabReqQueryParametersPage.Size = new Size(454, 337);
            tabReqQueryParametersPage.TabIndex = 1;
            tabReqQueryParametersPage.Text = "Query Parameters";
            tabReqQueryParametersPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(451, 334);
            dataGridView1.TabIndex = 0;
            // 
            // tabReqBodyPage
            // 
            tabReqBodyPage.Controls.Add(rtxBody);
            tabReqBodyPage.Location = new Point(4, 24);
            tabReqBodyPage.Name = "tabReqBodyPage";
            tabReqBodyPage.Size = new Size(454, 337);
            tabReqBodyPage.TabIndex = 2;
            tabReqBodyPage.Text = "Body";
            tabReqBodyPage.UseVisualStyleBackColor = true;
            // 
            // rtxBody
            // 
            rtxBody.Location = new Point(1, 2);
            rtxBody.Name = "rtxBody";
            rtxBody.Size = new Size(450, 383);
            rtxBody.TabIndex = 0;
            rtxBody.Text = "";
            // 
            // cmbReqMethod
            // 
            cmbReqMethod.FormattingEnabled = true;
            cmbReqMethod.Location = new Point(129, 120);
            cmbReqMethod.Name = "cmbReqMethod";
            cmbReqMethod.Size = new Size(108, 23);
            cmbReqMethod.TabIndex = 17;
            // 
            // lblReqMethod
            // 
            lblReqMethod.AutoSize = true;
            lblReqMethod.Location = new Point(18, 123);
            lblReqMethod.Name = "lblReqMethod";
            lblReqMethod.Size = new Size(49, 15);
            lblReqMethod.TabIndex = 16;
            lblReqMethod.Text = "Method";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(679, 22);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 29;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // frmRestClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 648);
            Controls.Add(btnRun);
            Controls.Add(btnAuthGo);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblResponseOutput);
            Controls.Add(trOutput);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "frmRestClient";
            Text = "REST Client";
            Load += frmRestClient_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControlReq.ResumeLayout(false);
            tabReqHeadersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHeader).EndInit();
            tabReqQueryParametersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabReqBodyPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMethod;
        private ComboBox cmbMethod;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtAuthUrl;
        private Label lblAuthUrl;
        private ComboBox cmbAuthType;
        private Label lblAuthType;
        private TextBox txtKey;
        private TextBox txtSecret;
        private TextBox txtToken;
        private Label lblKey;
        private Label lblSecret;
        private Label lblToken;
        private TextBox txtBaseUrl;
        private Label lblBaseUrl;
        private TextBox txtResourceUrl;
        private Label lblResourceUrl;
        private TreeView trOutput;
        private Label lblResponseOutput;
        private TextBox txtNextUrl;
        private Label lblNextUrl;
        private Button btnAuthGo;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControlReq;
        private TabPage tabReqHeadersPage;
        private TabPage tabReqQueryParametersPage;
        private DataGridView dataGridViewHeader;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private ComboBox cmbContentType;
        private Label lblContentType;
        private TabPage tabReqBodyPage;
        private RichTextBox rtxBody;
        private Button btnRun;
        private ComboBox cmbReqMethod;
        private Label lblReqMethod;
        private ComboBox cmbRequestBodyType;
        private Label lblRequetBodyType;
        private DataGridView dataGridView1;
    }
}