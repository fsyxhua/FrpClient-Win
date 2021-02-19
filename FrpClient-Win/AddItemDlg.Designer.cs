namespace FrpClient_Win
{
    partial class AddItemDlg
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
            this.components = new System.ComponentModel.Container();
            this.AddType = new System.Windows.Forms.Label();
            this.AddLoaclPort = new System.Windows.Forms.Label();
            this.AddLoaclIP = new System.Windows.Forms.Label();
            this.AddRemotePort = new System.Windows.Forms.Label();
            this.AddDomain = new System.Windows.Forms.Label();
            this.AddSectionName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddTranOpt = new System.Windows.Forms.Label();
            this.CheckAddUseCompression = new System.Windows.Forms.CheckBox();
            this.CheckAddUseEncryption = new System.Windows.Forms.CheckBox();
            this.InputAddType = new System.Windows.Forms.ComboBox();
            this.InputAddSectionName = new System.Windows.Forms.TextBox();
            this.InputAddDomain = new System.Windows.Forms.TextBox();
            this.InputAddRemotePort = new System.Windows.Forms.TextBox();
            this.InputAddLoaclIP = new System.Windows.Forms.TextBox();
            this.InputAddLoaclPort = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.CancelAdd = new System.Windows.Forms.Button();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.InputAddSK = new System.Windows.Forms.TextBox();
            this.AddSK = new System.Windows.Forms.Label();
            this.AddRole = new System.Windows.Forms.Label();
            this.InputAddServerName = new System.Windows.Forms.TextBox();
            this.AddServerNmae = new System.Windows.Forms.Label();
            this.CheckAddRoleVisitor = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddType
            // 
            this.AddType.AutoSize = true;
            this.AddType.Location = new System.Drawing.Point(65, 25);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(29, 12);
            this.AddType.TabIndex = 0;
            this.AddType.Text = "类型";
            // 
            // AddLoaclPort
            // 
            this.AddLoaclPort.AutoSize = true;
            this.AddLoaclPort.Location = new System.Drawing.Point(41, 54);
            this.AddLoaclPort.Name = "AddLoaclPort";
            this.AddLoaclPort.Size = new System.Drawing.Size(53, 12);
            this.AddLoaclPort.TabIndex = 1;
            this.AddLoaclPort.Text = "本地端口";
            // 
            // AddLoaclIP
            // 
            this.AddLoaclIP.AutoSize = true;
            this.AddLoaclIP.Location = new System.Drawing.Point(53, 83);
            this.AddLoaclIP.Name = "AddLoaclIP";
            this.AddLoaclIP.Size = new System.Drawing.Size(41, 12);
            this.AddLoaclIP.TabIndex = 2;
            this.AddLoaclIP.Text = "本地IP";
            // 
            // AddRemotePort
            // 
            this.AddRemotePort.AutoSize = true;
            this.AddRemotePort.Location = new System.Drawing.Point(41, 112);
            this.AddRemotePort.Name = "AddRemotePort";
            this.AddRemotePort.Size = new System.Drawing.Size(53, 12);
            this.AddRemotePort.TabIndex = 3;
            this.AddRemotePort.Text = "远程端口";
            // 
            // AddDomain
            // 
            this.AddDomain.AutoSize = true;
            this.AddDomain.Location = new System.Drawing.Point(41, 141);
            this.AddDomain.Name = "AddDomain";
            this.AddDomain.Size = new System.Drawing.Size(53, 12);
            this.AddDomain.TabIndex = 4;
            this.AddDomain.Text = "绑定域名";
            // 
            // AddSectionName
            // 
            this.AddSectionName.AutoSize = true;
            this.AddSectionName.Location = new System.Drawing.Point(41, 240);
            this.AddSectionName.Name = "AddSectionName";
            this.AddSectionName.Size = new System.Drawing.Size(53, 12);
            this.AddSectionName.TabIndex = 5;
            this.AddSectionName.Text = "唯一标签";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckAddRoleVisitor);
            this.groupBox1.Controls.Add(this.InputAddServerName);
            this.groupBox1.Controls.Add(this.AddServerNmae);
            this.groupBox1.Controls.Add(this.AddRole);
            this.groupBox1.Controls.Add(this.InputAddSK);
            this.groupBox1.Controls.Add(this.AddSK);
            this.groupBox1.Controls.Add(this.AddTranOpt);
            this.groupBox1.Controls.Add(this.CheckAddUseCompression);
            this.groupBox1.Controls.Add(this.CheckAddUseEncryption);
            this.groupBox1.Controls.Add(this.InputAddType);
            this.groupBox1.Controls.Add(this.InputAddSectionName);
            this.groupBox1.Controls.Add(this.InputAddDomain);
            this.groupBox1.Controls.Add(this.InputAddRemotePort);
            this.groupBox1.Controls.Add(this.InputAddLoaclIP);
            this.groupBox1.Controls.Add(this.InputAddLoaclPort);
            this.groupBox1.Controls.Add(this.AddSectionName);
            this.groupBox1.Controls.Add(this.AddDomain);
            this.groupBox1.Controls.Add(this.AddLoaclIP);
            this.groupBox1.Controls.Add(this.AddRemotePort);
            this.groupBox1.Controls.Add(this.AddType);
            this.groupBox1.Controls.Add(this.AddLoaclPort);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条目配置";
            // 
            // AddTranOpt
            // 
            this.AddTranOpt.AutoSize = true;
            this.AddTranOpt.Location = new System.Drawing.Point(41, 274);
            this.AddTranOpt.Name = "AddTranOpt";
            this.AddTranOpt.Size = new System.Drawing.Size(53, 12);
            this.AddTranOpt.TabIndex = 9;
            this.AddTranOpt.Text = "传输选项";
            // 
            // CheckAddUseCompression
            // 
            this.CheckAddUseCompression.AutoSize = true;
            this.CheckAddUseCompression.Location = new System.Drawing.Point(170, 273);
            this.CheckAddUseCompression.Name = "CheckAddUseCompression";
            this.CheckAddUseCompression.Size = new System.Drawing.Size(48, 16);
            this.CheckAddUseCompression.TabIndex = 8;
            this.CheckAddUseCompression.Text = "压缩";
            this.CheckAddUseCompression.UseVisualStyleBackColor = true;
            // 
            // CheckAddUseEncryption
            // 
            this.CheckAddUseEncryption.AutoSize = true;
            this.CheckAddUseEncryption.Location = new System.Drawing.Point(116, 273);
            this.CheckAddUseEncryption.Name = "CheckAddUseEncryption";
            this.CheckAddUseEncryption.Size = new System.Drawing.Size(48, 16);
            this.CheckAddUseEncryption.TabIndex = 7;
            this.CheckAddUseEncryption.Text = "加密";
            this.CheckAddUseEncryption.UseVisualStyleBackColor = true;
            // 
            // InputAddType
            // 
            this.InputAddType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddType.FormattingEnabled = true;
            this.InputAddType.Items.AddRange(new object[] {
            "tcp",
            "stcp",
            "udp",
            "http",
            "https"});
            this.InputAddType.Location = new System.Drawing.Point(116, 22);
            this.InputAddType.Name = "InputAddType";
            this.InputAddType.Size = new System.Drawing.Size(227, 20);
            this.InputAddType.TabIndex = 6;
            this.InputAddType.SelectedIndexChanged += new System.EventHandler(this.InputAddType_SelectedIndexChanged);
            // 
            // InputAddSectionName
            // 
            this.InputAddSectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddSectionName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.InputAddSectionName.Location = new System.Drawing.Point(116, 236);
            this.InputAddSectionName.Name = "InputAddSectionName";
            this.InputAddSectionName.Size = new System.Drawing.Size(227, 21);
            this.InputAddSectionName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.InputAddSectionName, "当端口为范围格式时，将自动补全 range:");
            // 
            // InputAddDomain
            // 
            this.InputAddDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddDomain.Location = new System.Drawing.Point(116, 137);
            this.InputAddDomain.Name = "InputAddDomain";
            this.InputAddDomain.Size = new System.Drawing.Size(227, 21);
            this.InputAddDomain.TabIndex = 4;
            // 
            // InputAddRemotePort
            // 
            this.InputAddRemotePort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddRemotePort.Location = new System.Drawing.Point(116, 108);
            this.InputAddRemotePort.Name = "InputAddRemotePort";
            this.InputAddRemotePort.Size = new System.Drawing.Size(227, 21);
            this.InputAddRemotePort.TabIndex = 3;
            this.toolTip1.SetToolTip(this.InputAddRemotePort, "双击填入“本地端口”内容");
            this.InputAddRemotePort.DoubleClick += new System.EventHandler(this.InputAddRemotePort_DoubleClick);
            // 
            // InputAddLoaclIP
            // 
            this.InputAddLoaclIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddLoaclIP.Location = new System.Drawing.Point(116, 79);
            this.InputAddLoaclIP.Name = "InputAddLoaclIP";
            this.InputAddLoaclIP.Size = new System.Drawing.Size(227, 21);
            this.InputAddLoaclIP.TabIndex = 2;
            this.toolTip1.SetToolTip(this.InputAddLoaclIP, "双击填入 127.0.0.1");
            this.InputAddLoaclIP.DoubleClick += new System.EventHandler(this.InputAddLoaclIP_DoubleClick);
            // 
            // InputAddLoaclPort
            // 
            this.InputAddLoaclPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddLoaclPort.Location = new System.Drawing.Point(116, 50);
            this.InputAddLoaclPort.Name = "InputAddLoaclPort";
            this.InputAddLoaclPort.Size = new System.Drawing.Size(227, 21);
            this.InputAddLoaclPort.TabIndex = 1;
            this.toolTip1.SetToolTip(this.InputAddLoaclPort, "支持范围端口格式如：80-88,443");
            // 
            // AddItem
            // 
            this.AddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItem.Location = new System.Drawing.Point(217, 323);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 7;
            this.AddItem.Text = "确定";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // CancelAdd
            // 
            this.CancelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelAdd.Location = new System.Drawing.Point(304, 323);
            this.CancelAdd.Name = "CancelAdd";
            this.CancelAdd.Size = new System.Drawing.Size(75, 23);
            this.CancelAdd.TabIndex = 8;
            this.CancelAdd.Text = "取消";
            this.CancelAdd.UseVisualStyleBackColor = true;
            this.CancelAdd.Click += new System.EventHandler(this.CancelAdd_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteItem.ForeColor = System.Drawing.Color.Red;
            this.DeleteItem.Location = new System.Drawing.Point(13, 323);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.DeleteItem.TabIndex = 9;
            this.DeleteItem.Text = "删除";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // InputAddSK
            // 
            this.InputAddSK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddSK.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.InputAddSK.Location = new System.Drawing.Point(116, 166);
            this.InputAddSK.Name = "InputAddSK";
            this.InputAddSK.Size = new System.Drawing.Size(227, 21);
            this.InputAddSK.TabIndex = 10;
            this.toolTip1.SetToolTip(this.InputAddSK, "当端口为范围格式时，将自动补全 range:");
            // 
            // AddSK
            // 
            this.AddSK.AutoSize = true;
            this.AddSK.Location = new System.Drawing.Point(77, 170);
            this.AddSK.Name = "AddSK";
            this.AddSK.Size = new System.Drawing.Size(17, 12);
            this.AddSK.TabIndex = 11;
            this.AddSK.Text = "SK";
            // 
            // AddRole
            // 
            this.AddRole.AutoSize = true;
            this.AddRole.Location = new System.Drawing.Point(238, 277);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(0, 12);
            this.AddRole.TabIndex = 13;
            // 
            // InputAddServerName
            // 
            this.InputAddServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddServerName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.InputAddServerName.Location = new System.Drawing.Point(116, 199);
            this.InputAddServerName.Name = "InputAddServerName";
            this.InputAddServerName.Size = new System.Drawing.Size(227, 21);
            this.InputAddServerName.TabIndex = 14;
            this.toolTip1.SetToolTip(this.InputAddServerName, "当端口为范围格式时，将自动补全 range:");
            // 
            // AddServerNmae
            // 
            this.AddServerNmae.AutoSize = true;
            this.AddServerNmae.Location = new System.Drawing.Point(23, 203);
            this.AddServerNmae.Name = "AddServerNmae";
            this.AddServerNmae.Size = new System.Drawing.Size(71, 12);
            this.AddServerNmae.TabIndex = 15;
            this.AddServerNmae.Text = "Server_Name";
            // 
            // CheckAddRoleVisitor
            // 
            this.CheckAddRoleVisitor.AutoSize = true;
            this.CheckAddRoleVisitor.Location = new System.Drawing.Point(233, 273);
            this.CheckAddRoleVisitor.Name = "CheckAddRoleVisitor";
            this.CheckAddRoleVisitor.Size = new System.Drawing.Size(90, 16);
            this.CheckAddRoleVisitor.TabIndex = 16;
            this.CheckAddRoleVisitor.Text = "RoleVisitor";
            this.CheckAddRoleVisitor.UseVisualStyleBackColor = true;
            this.CheckAddRoleVisitor.CheckedChanged += new System.EventHandler(this.CheckAddRoleVisitor_CheckedChanged);
            // 
            // AddItemDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 357);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.CancelAdd);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增/修改条目";
            this.Load += new System.EventHandler(this.OnAddItemDlgLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AddType;
        private System.Windows.Forms.Label AddLoaclPort;
        private System.Windows.Forms.Label AddLoaclIP;
        private System.Windows.Forms.Label AddRemotePort;
        private System.Windows.Forms.Label AddDomain;
        private System.Windows.Forms.Label AddSectionName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InputAddSectionName;
        private System.Windows.Forms.TextBox InputAddDomain;
        private System.Windows.Forms.TextBox InputAddRemotePort;
        private System.Windows.Forms.TextBox InputAddLoaclIP;
        private System.Windows.Forms.TextBox InputAddLoaclPort;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button CancelAdd;
        private System.Windows.Forms.ComboBox InputAddType;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.CheckBox CheckAddUseCompression;
        private System.Windows.Forms.CheckBox CheckAddUseEncryption;
        private System.Windows.Forms.Label AddTranOpt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox InputAddServerName;
        private System.Windows.Forms.Label AddServerNmae;
        private System.Windows.Forms.Label AddRole;
        private System.Windows.Forms.TextBox InputAddSK;
        private System.Windows.Forms.Label AddSK;
        private System.Windows.Forms.CheckBox CheckAddRoleVisitor;
    }
}