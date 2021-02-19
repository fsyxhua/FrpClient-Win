﻿namespace FrpClient_Win
{
    partial class ServerConfigDlg
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
            this.SaveServerConfig = new System.Windows.Forms.Button();
            this.CancelConfig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FrpAdminPort = new System.Windows.Forms.TextBox();
            this.FrpAdmin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FrpToken = new System.Windows.Forms.TextBox();
            this.FrpServerPort = new System.Windows.Forms.TextBox();
            this.FrpServerIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputServerProtocol = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveServerConfig
            // 
            this.SaveServerConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveServerConfig.Location = new System.Drawing.Point(174, 217);
            this.SaveServerConfig.Name = "SaveServerConfig";
            this.SaveServerConfig.Size = new System.Drawing.Size(75, 23);
            this.SaveServerConfig.TabIndex = 0;
            this.SaveServerConfig.Text = "确定";
            this.SaveServerConfig.UseVisualStyleBackColor = true;
            this.SaveServerConfig.Click += new System.EventHandler(this.SaveServerConfig_Click);
            // 
            // CancelConfig
            // 
            this.CancelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelConfig.Location = new System.Drawing.Point(261, 217);
            this.CancelConfig.Name = "CancelConfig";
            this.CancelConfig.Size = new System.Drawing.Size(75, 23);
            this.CancelConfig.TabIndex = 1;
            this.CancelConfig.Text = "取消";
            this.CancelConfig.UseVisualStyleBackColor = true;
            this.CancelConfig.Click += new System.EventHandler(this.CancelConfig_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.InputServerProtocol);
            this.groupBox1.Controls.Add(this.FrpAdminPort);
            this.groupBox1.Controls.Add(this.FrpAdmin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FrpToken);
            this.groupBox1.Controls.Add(this.FrpServerPort);
            this.groupBox1.Controls.Add(this.FrpServerIp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通用参数";
            // 
            // FrpAdminPort
            // 
            this.FrpAdminPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrpAdminPort.Enabled = false;
            this.FrpAdminPort.Location = new System.Drawing.Point(234, 157);
            this.FrpAdminPort.Name = "FrpAdminPort";
            this.FrpAdminPort.Size = new System.Drawing.Size(67, 21);
            this.FrpAdminPort.TabIndex = 9;
            this.FrpAdminPort.Text = "7400";
            // 
            // FrpAdmin
            // 
            this.FrpAdmin.AutoSize = true;
            this.FrpAdmin.Location = new System.Drawing.Point(24, 161);
            this.FrpAdmin.Name = "FrpAdmin";
            this.FrpAdmin.Size = new System.Drawing.Size(204, 16);
            this.FrpAdmin.TabIndex = 8;
            this.FrpAdmin.Text = "开启客户端面板（热加载），端口";
            this.FrpAdmin.UseVisualStyleBackColor = true;
            this.FrpAdmin.CheckedChanged += new System.EventHandler(this.FrpAdmin_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "协议";
            // 
            // FrpToken
            // 
            this.FrpToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrpToken.Location = new System.Drawing.Point(118, 95);
            this.FrpToken.Name = "FrpToken";
            this.FrpToken.Size = new System.Drawing.Size(183, 21);
            this.FrpToken.TabIndex = 5;
            // 
            // FrpServerPort
            // 
            this.FrpServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrpServerPort.Location = new System.Drawing.Point(118, 62);
            this.FrpServerPort.Name = "FrpServerPort";
            this.FrpServerPort.Size = new System.Drawing.Size(183, 21);
            this.FrpServerPort.TabIndex = 4;
            // 
            // FrpServerIp
            // 
            this.FrpServerIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrpServerIp.Location = new System.Drawing.Point(118, 29);
            this.FrpServerIp.Name = "FrpServerIp";
            this.FrpServerIp.Size = new System.Drawing.Size(183, 21);
            this.FrpServerIp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "验证字符串";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "frp服务端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "frp服务器IP";
            // 
            // InputServerProtocol
            // 
            this.InputServerProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputServerProtocol.FormattingEnabled = true;
            this.InputServerProtocol.Items.AddRange(new object[] {
            "tcp",
            "websocket"});
            this.InputServerProtocol.Location = new System.Drawing.Point(118, 127);
            this.InputServerProtocol.Name = "InputServerProtocol";
            this.InputServerProtocol.Size = new System.Drawing.Size(183, 20);
            this.InputServerProtocol.TabIndex = 10;
            // 
            // ServerConfigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelConfig);
            this.Controls.Add(this.SaveServerConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerConfigDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "服务配置";
            this.Load += new System.EventHandler(this.OnConfigDlgLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveServerConfig;
        private System.Windows.Forms.Button CancelConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FrpToken;
        private System.Windows.Forms.TextBox FrpServerPort;
        private System.Windows.Forms.TextBox FrpServerIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox FrpAdmin;
        private System.Windows.Forms.TextBox FrpAdminPort;
        private System.Windows.Forms.ComboBox InputServerProtocol;
    }
}