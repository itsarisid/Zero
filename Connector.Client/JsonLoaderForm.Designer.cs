namespace Connector.Client
{
    partial class JsonLoaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            lblName = new Label();
            tabControlMain = new TabControl();
            tabPageAuth = new TabPage();
            btnAuthGo = new Button();
            btnSave = new Button();
            tabControl = new TabControl();
            tabHeadersPage = new TabPage();
            dataGridViewHeader = new DataGridView();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            tabQueryParametersPage = new TabPage();
            dataGridViewQueryParameters = new DataGridView();
            QKey = new DataGridViewTextBoxColumn();
            QValue = new DataGridViewTextBoxColumn();
            tabBodyPage = new TabPage();
            rtxBody = new RichTextBox();
            tabPageOutput = new TabPage();
            groupBox1 = new GroupBox();
            cmbContentType = new ComboBox();
            lblContentType = new Label();
            lblToken = new Label();
            lblSecret = new Label();
            lblKey = new Label();
            txtToken = new TextBox();
            txtSecret = new TextBox();
            txtKey = new TextBox();
            cmbAuthType = new ComboBox();
            lblAuthType = new Label();
            txtAuthUrl = new TextBox();
            lblAuthUrl = new Label();
            cmbMethod = new ComboBox();
            lblMethod = new Label();
            tabPageRequest = new TabPage();
            groupBox2 = new GroupBox();
            cmbRequestBodyType = new ComboBox();
            lblRequetBodyType = new Label();
            tabControlReq = new TabControl();
            tabReqHeadersPage = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            tabReqQueryParametersPage = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabReqBodyPage = new TabPage();
            richTextBox1 = new RichTextBox();
            cmbReqMethod = new ComboBox();
            txtNextUrl = new TextBox();
            lblReqMethod = new Label();
            lblNextUrl = new Label();
            txtResourceUrl = new TextBox();
            lblResourceUrl = new Label();
            txtBaseUrl = new TextBox();
            lblBaseUrl = new Label();
            tabReqPageOutput = new TabPage();
            button1 = new Button();
            button2 = new Button();
            tabControlMain.SuspendLayout();
            tabPageAuth.SuspendLayout();
            tabControl.SuspendLayout();
            tabHeadersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHeader).BeginInit();
            tabQueryParametersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQueryParameters).BeginInit();
            tabBodyPage.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageRequest.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControlReq.SuspendLayout();
            tabReqHeadersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabReqQueryParametersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabReqBodyPage.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 24);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(406, 23);
            txtName.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageAuth);
            tabControlMain.Controls.Add(tabPageRequest);
            tabControlMain.Location = new Point(12, 67);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(608, 713);
            tabControlMain.TabIndex = 6;
            // 
            // tabPageAuth
            // 
            tabPageAuth.Controls.Add(btnAuthGo);
            tabPageAuth.Controls.Add(btnSave);
            tabPageAuth.Controls.Add(tabControl);
            tabPageAuth.Controls.Add(groupBox1);
            tabPageAuth.Location = new Point(4, 24);
            tabPageAuth.Name = "tabPageAuth";
            tabPageAuth.Padding = new Padding(3);
            tabPageAuth.Size = new Size(600, 685);
            tabPageAuth.TabIndex = 0;
            tabPageAuth.Text = "Authentication";
            tabPageAuth.UseVisualStyleBackColor = true;
            // 
            // btnAuthGo
            // 
            btnAuthGo.Location = new Point(511, 656);
            btnAuthGo.Name = "btnAuthGo";
            btnAuthGo.Size = new Size(75, 23);
            btnAuthGo.TabIndex = 30;
            btnAuthGo.Text = "Validate";
            btnAuthGo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(430, 656);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabHeadersPage);
            tabControl.Controls.Add(tabQueryParametersPage);
            tabControl.Controls.Add(tabBodyPage);
            tabControl.Controls.Add(tabPageOutput);
            tabControl.Location = new Point(11, 271);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(580, 365);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 29;
            // 
            // tabHeadersPage
            // 
            tabHeadersPage.Controls.Add(dataGridViewHeader);
            tabHeadersPage.Location = new Point(4, 24);
            tabHeadersPage.Name = "tabHeadersPage";
            tabHeadersPage.Padding = new Padding(3);
            tabHeadersPage.Size = new Size(572, 337);
            tabHeadersPage.TabIndex = 0;
            tabHeadersPage.Text = "Headers";
            tabHeadersPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHeader
            // 
            dataGridViewHeader.AllowUserToOrderColumns = true;
            dataGridViewHeader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHeader.Columns.AddRange(new DataGridViewColumn[] { Key, Value });
            dataGridViewHeader.Location = new Point(6, 7);
            dataGridViewHeader.Name = "dataGridViewHeader";
            dataGridViewHeader.RowTemplate.Height = 25;
            dataGridViewHeader.Size = new Size(560, 334);
            dataGridViewHeader.TabIndex = 0;
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
            // tabQueryParametersPage
            // 
            tabQueryParametersPage.Controls.Add(dataGridViewQueryParameters);
            tabQueryParametersPage.Location = new Point(4, 24);
            tabQueryParametersPage.Name = "tabQueryParametersPage";
            tabQueryParametersPage.Padding = new Padding(3);
            tabQueryParametersPage.Size = new Size(572, 337);
            tabQueryParametersPage.TabIndex = 1;
            tabQueryParametersPage.Text = "Query Parameters";
            tabQueryParametersPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQueryParameters
            // 
            dataGridViewQueryParameters.AllowUserToOrderColumns = true;
            dataGridViewQueryParameters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQueryParameters.Columns.AddRange(new DataGridViewColumn[] { QKey, QValue });
            dataGridViewQueryParameters.Location = new Point(7, 7);
            dataGridViewQueryParameters.Name = "dataGridViewQueryParameters";
            dataGridViewQueryParameters.RowTemplate.Height = 25;
            dataGridViewQueryParameters.Size = new Size(559, 327);
            dataGridViewQueryParameters.TabIndex = 1;
            // 
            // QKey
            // 
            QKey.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QKey.HeaderText = "Key";
            QKey.Name = "QKey";
            // 
            // QValue
            // 
            QValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QValue.HeaderText = "Value";
            QValue.Name = "QValue";
            // 
            // tabBodyPage
            // 
            tabBodyPage.Controls.Add(rtxBody);
            tabBodyPage.Location = new Point(4, 24);
            tabBodyPage.Name = "tabBodyPage";
            tabBodyPage.Size = new Size(572, 337);
            tabBodyPage.TabIndex = 2;
            tabBodyPage.Text = "Body";
            tabBodyPage.UseVisualStyleBackColor = true;
            // 
            // rtxBody
            // 
            rtxBody.Location = new Point(1, 2);
            rtxBody.Name = "rtxBody";
            rtxBody.Size = new Size(568, 332);
            rtxBody.TabIndex = 0;
            rtxBody.Text = "";
            // 
            // tabPageOutput
            // 
            tabPageOutput.Location = new Point(4, 24);
            tabPageOutput.Name = "tabPageOutput";
            tabPageOutput.Size = new Size(572, 337);
            tabPageOutput.TabIndex = 3;
            tabPageOutput.Text = "Output";
            tabPageOutput.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 259);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Authentication";
            // 
            // cmbContentType
            // 
            cmbContentType.FormattingEnabled = true;
            cmbContentType.Location = new Point(383, 77);
            cmbContentType.Name = "cmbContentType";
            cmbContentType.Size = new Size(196, 23);
            cmbContentType.TabIndex = 15;
            // 
            // lblContentType
            // 
            lblContentType.AutoSize = true;
            lblContentType.Location = new Point(277, 80);
            lblContentType.Name = "lblContentType";
            lblContentType.Size = new Size(79, 15);
            lblContentType.TabIndex = 14;
            lblContentType.Text = "Content-Type";
            lblContentType.Click += lblContentType_Click;
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
            // lblSecret
            // 
            lblSecret.AutoSize = true;
            lblSecret.Location = new Point(277, 178);
            lblSecret.Name = "lblSecret";
            lblSecret.Size = new Size(39, 15);
            lblSecret.TabIndex = 12;
            lblSecret.Text = "Secret";
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
            // txtToken
            // 
            txtToken.Location = new Point(80, 216);
            txtToken.Name = "txtToken";
            txtToken.PlaceholderText = "Token";
            txtToken.Size = new Size(499, 23);
            txtToken.TabIndex = 10;
            // 
            // txtSecret
            // 
            txtSecret.Location = new Point(383, 175);
            txtSecret.Name = "txtSecret";
            txtSecret.PlaceholderText = "Secret";
            txtSecret.Size = new Size(196, 23);
            txtSecret.TabIndex = 9;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(80, 175);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Key";
            txtKey.Size = new Size(167, 23);
            txtKey.TabIndex = 8;
            // 
            // cmbAuthType
            // 
            cmbAuthType.FormattingEnabled = true;
            cmbAuthType.Location = new Point(80, 124);
            cmbAuthType.Name = "cmbAuthType";
            cmbAuthType.Size = new Size(167, 23);
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
            // txtAuthUrl
            // 
            txtAuthUrl.Location = new Point(80, 28);
            txtAuthUrl.Name = "txtAuthUrl";
            txtAuthUrl.PlaceholderText = "Auth URL";
            txtAuthUrl.Size = new Size(503, 23);
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
            // cmbMethod
            // 
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Location = new Point(80, 77);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(167, 23);
            cmbMethod.TabIndex = 1;
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
            // tabPageRequest
            // 
            tabPageRequest.Controls.Add(groupBox2);
            tabPageRequest.Location = new Point(4, 24);
            tabPageRequest.Name = "tabPageRequest";
            tabPageRequest.Padding = new Padding(3);
            tabPageRequest.Size = new Size(600, 685);
            tabPageRequest.TabIndex = 1;
            tabPageRequest.Text = "Request";
            tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
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
            groupBox2.Location = new Point(3, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 663);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resource";
            // 
            // cmbRequestBodyType
            // 
            cmbRequestBodyType.FormattingEnabled = true;
            cmbRequestBodyType.Location = new Point(442, 123);
            cmbRequestBodyType.Name = "cmbRequestBodyType";
            cmbRequestBodyType.Size = new Size(138, 23);
            cmbRequestBodyType.TabIndex = 29;
            // 
            // lblRequetBodyType
            // 
            lblRequetBodyType.AutoSize = true;
            lblRequetBodyType.Location = new Point(361, 126);
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
            tabControlReq.Controls.Add(tabReqPageOutput);
            tabControlReq.Location = new Point(18, 174);
            tabControlReq.Multiline = true;
            tabControlReq.Name = "tabControlReq";
            tabControlReq.SelectedIndex = 0;
            tabControlReq.Size = new Size(562, 365);
            tabControlReq.SizeMode = TabSizeMode.FillToRight;
            tabControlReq.TabIndex = 27;
            // 
            // tabReqHeadersPage
            // 
            tabReqHeadersPage.Controls.Add(dataGridView1);
            tabReqHeadersPage.Location = new Point(4, 24);
            tabReqHeadersPage.Name = "tabReqHeadersPage";
            tabReqHeadersPage.Padding = new Padding(3);
            tabReqHeadersPage.Size = new Size(554, 337);
            tabReqHeadersPage.TabIndex = 0;
            tabReqHeadersPage.Text = "Headers";
            tabReqHeadersPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView1.Location = new Point(6, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(545, 324);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Key";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Values";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabReqQueryParametersPage
            // 
            tabReqQueryParametersPage.Controls.Add(dataGridView2);
            tabReqQueryParametersPage.Location = new Point(4, 24);
            tabReqQueryParametersPage.Name = "tabReqQueryParametersPage";
            tabReqQueryParametersPage.Padding = new Padding(3);
            tabReqQueryParametersPage.Size = new Size(554, 337);
            tabReqQueryParametersPage.TabIndex = 1;
            tabReqQueryParametersPage.Text = "Query Parameters";
            tabReqQueryParametersPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(7, 7);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(541, 324);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Key";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Value";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tabReqBodyPage
            // 
            tabReqBodyPage.Controls.Add(richTextBox1);
            tabReqBodyPage.Location = new Point(4, 24);
            tabReqBodyPage.Name = "tabReqBodyPage";
            tabReqBodyPage.Size = new Size(554, 337);
            tabReqBodyPage.TabIndex = 2;
            tabReqBodyPage.Text = "Body";
            tabReqBodyPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(550, 332);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // cmbReqMethod
            // 
            cmbReqMethod.FormattingEnabled = true;
            cmbReqMethod.Location = new Point(129, 120);
            cmbReqMethod.Name = "cmbReqMethod";
            cmbReqMethod.Size = new Size(108, 23);
            cmbReqMethod.TabIndex = 17;
            // 
            // txtNextUrl
            // 
            txtNextUrl.Location = new Point(129, 560);
            txtNextUrl.Name = "txtNextUrl";
            txtNextUrl.PlaceholderText = "Next Page URL";
            txtNextUrl.Size = new Size(447, 23);
            txtNextUrl.TabIndex = 21;
            txtNextUrl.TextChanged += txtNextUrl_TextChanged;
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
            // lblNextUrl
            // 
            lblNextUrl.AutoSize = true;
            lblNextUrl.Location = new Point(18, 563);
            lblNextUrl.Name = "lblNextUrl";
            lblNextUrl.Size = new Size(56, 15);
            lblNextUrl.TabIndex = 20;
            lblNextUrl.Text = "Next URL";
            // 
            // txtResourceUrl
            // 
            txtResourceUrl.Location = new Point(129, 76);
            txtResourceUrl.Name = "txtResourceUrl";
            txtResourceUrl.PlaceholderText = "Resource URL";
            txtResourceUrl.Size = new Size(451, 23);
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
            // txtBaseUrl
            // 
            txtBaseUrl.Location = new Point(129, 30);
            txtBaseUrl.Name = "txtBaseUrl";
            txtBaseUrl.PlaceholderText = "Base URL";
            txtBaseUrl.Size = new Size(451, 23);
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
            // tabReqPageOutput
            // 
            tabReqPageOutput.Location = new Point(4, 24);
            tabReqPageOutput.Name = "tabReqPageOutput";
            tabReqPageOutput.Size = new Size(554, 337);
            tabReqPageOutput.TabIndex = 3;
            tabReqPageOutput.Text = "Output";
            tabReqPageOutput.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(498, 604);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Validate";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(417, 604);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // JsonLoaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 786);
            Controls.Add(tabControlMain);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "JsonLoaderForm";
            Text = "JsonLoaderForm";
            tabControlMain.ResumeLayout(false);
            tabPageAuth.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabHeadersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHeader).EndInit();
            tabQueryParametersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewQueryParameters).EndInit();
            tabBodyPage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageRequest.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControlReq.ResumeLayout(false);
            tabReqHeadersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabReqQueryParametersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabReqBodyPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private TabControl tabControlMain;
        private TabPage tabPageAuth;
        private TabPage tabPageRequest;
        private GroupBox groupBox1;
        private ComboBox cmbContentType;
        private Label lblContentType;
        private Label lblToken;
        private Label lblSecret;
        private Label lblKey;
        private TextBox txtToken;
        private TextBox txtSecret;
        private TextBox txtKey;
        private ComboBox cmbAuthType;
        private Label lblAuthType;
        private TextBox txtAuthUrl;
        private Label lblAuthUrl;
        private ComboBox cmbMethod;
        private Label lblMethod;
        private TabControl tabControl;
        private TabPage tabHeadersPage;
        private DataGridView dataGridViewHeader;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private TabPage tabQueryParametersPage;
        private DataGridView dataGridViewQueryParameters;
        private DataGridViewTextBoxColumn QKey;
        private DataGridViewTextBoxColumn QValue;
        private TabPage tabBodyPage;
        private RichTextBox rtxBody;
        private Button btnAuthGo;
        private Button btnSave;
        private GroupBox groupBox2;
        private ComboBox cmbRequestBodyType;
        private Label lblRequetBodyType;
        private TabControl tabControlReq;
        private TabPage tabReqHeadersPage;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TabPage tabReqQueryParametersPage;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TabPage tabReqBodyPage;
        private RichTextBox richTextBox1;
        private ComboBox cmbReqMethod;
        private TextBox txtNextUrl;
        private Label lblReqMethod;
        private Label lblNextUrl;
        private TextBox txtResourceUrl;
        private Label lblResourceUrl;
        private TextBox txtBaseUrl;
        private Label lblBaseUrl;
        private TabPage tabPageOutput;
        private TabPage tabReqPageOutput;
        private Button button1;
        private Button button2;
    }
}