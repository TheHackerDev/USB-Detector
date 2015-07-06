namespace USB_Detector
{
    partial class EmailConfigForm
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
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.lblSmtpServer = new System.Windows.Forms.Label();
            this.lblSmtpPort = new System.Windows.Forms.Label();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.lblEmailSubject = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblSmtpUser = new System.Windows.Forms.Label();
            this.txtSmtpUser = new System.Windows.Forms.TextBox();
            this.grpSmtpInfo = new System.Windows.Forms.GroupBox();
            this.chkSslEnabled = new System.Windows.Forms.CheckBox();
            this.lblSslEnabled = new System.Windows.Forms.Label();
            this.txtSmtpPasswd = new System.Windows.Forms.TextBox();
            this.lblSmtpPasswd = new System.Windows.Forms.Label();
            this.grpEmailInfo = new System.Windows.Forms.GroupBox();
            this.grpSmtpInfo.SuspendLayout();
            this.grpEmailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(133, 19);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpServer.TabIndex = 0;
            // 
            // lblSmtpServer
            // 
            this.lblSmtpServer.AutoSize = true;
            this.lblSmtpServer.Location = new System.Drawing.Point(53, 22);
            this.lblSmtpServer.Name = "lblSmtpServer";
            this.lblSmtpServer.Size = new System.Drawing.Size(74, 13);
            this.lblSmtpServer.TabIndex = 1;
            this.lblSmtpServer.Text = "SMTP Server:";
            // 
            // lblSmtpPort
            // 
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Location = new System.Drawing.Point(65, 48);
            this.lblSmtpPort.Name = "lblSmtpPort";
            this.lblSmtpPort.Size = new System.Drawing.Size(62, 13);
            this.lblSmtpPort.TabIndex = 3;
            this.lblSmtpPort.Text = "SMTP Port:";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(133, 45);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpPort.TabIndex = 1;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(66, 46);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(61, 13);
            this.lblEmailFrom.TabIndex = 7;
            this.lblEmailFrom.Text = "Email From:";
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(133, 43);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(150, 20);
            this.txtEmailFrom.TabIndex = 6;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(76, 20);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(51, 13);
            this.lblEmailTo.TabIndex = 5;
            this.lblEmailTo.Text = "Email To:";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(133, 17);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(150, 20);
            this.txtEmailTo.TabIndex = 5;
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.AutoSize = true;
            this.lblEmailSubject.Location = new System.Drawing.Point(7, 72);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(120, 13);
            this.lblEmailSubject.TabIndex = 9;
            this.lblEmailSubject.Text = "Email Subject (optional):";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(133, 69);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(150, 20);
            this.txtEmailSubject.TabIndex = 7;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(135, 286);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblSmtpUser
            // 
            this.lblSmtpUser.AutoSize = true;
            this.lblSmtpUser.Location = new System.Drawing.Point(36, 74);
            this.lblSmtpUser.Name = "lblSmtpUser";
            this.lblSmtpUser.Size = new System.Drawing.Size(91, 13);
            this.lblSmtpUser.TabIndex = 12;
            this.lblSmtpUser.Text = "SMTP Username:";
            // 
            // txtSmtpUser
            // 
            this.txtSmtpUser.Location = new System.Drawing.Point(133, 71);
            this.txtSmtpUser.Name = "txtSmtpUser";
            this.txtSmtpUser.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpUser.TabIndex = 2;
            // 
            // grpSmtpInfo
            // 
            this.grpSmtpInfo.Controls.Add(this.chkSslEnabled);
            this.grpSmtpInfo.Controls.Add(this.lblSslEnabled);
            this.grpSmtpInfo.Controls.Add(this.txtSmtpPasswd);
            this.grpSmtpInfo.Controls.Add(this.lblSmtpPasswd);
            this.grpSmtpInfo.Controls.Add(this.txtSmtpUser);
            this.grpSmtpInfo.Controls.Add(this.lblSmtpUser);
            this.grpSmtpInfo.Controls.Add(this.txtSmtpServer);
            this.grpSmtpInfo.Controls.Add(this.lblSmtpServer);
            this.grpSmtpInfo.Controls.Add(this.txtSmtpPort);
            this.grpSmtpInfo.Controls.Add(this.lblSmtpPort);
            this.grpSmtpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpSmtpInfo.Name = "grpSmtpInfo";
            this.grpSmtpInfo.Size = new System.Drawing.Size(300, 162);
            this.grpSmtpInfo.TabIndex = 13;
            this.grpSmtpInfo.TabStop = false;
            this.grpSmtpInfo.Text = "SMTP Server Info";
            // 
            // chkSslEnabled
            // 
            this.chkSslEnabled.AutoSize = true;
            this.chkSslEnabled.Location = new System.Drawing.Point(133, 125);
            this.chkSslEnabled.Name = "chkSslEnabled";
            this.chkSslEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkSslEnabled.TabIndex = 4;
            this.chkSslEnabled.Text = "Enabled";
            this.chkSslEnabled.UseVisualStyleBackColor = true;
            // 
            // lblSslEnabled
            // 
            this.lblSslEnabled.AutoSize = true;
            this.lblSslEnabled.Location = new System.Drawing.Point(97, 126);
            this.lblSslEnabled.Name = "lblSslEnabled";
            this.lblSslEnabled.Size = new System.Drawing.Size(30, 13);
            this.lblSslEnabled.TabIndex = 15;
            this.lblSslEnabled.Text = "SSL:";
            // 
            // txtSmtpPasswd
            // 
            this.txtSmtpPasswd.Location = new System.Drawing.Point(133, 99);
            this.txtSmtpPasswd.Name = "txtSmtpPasswd";
            this.txtSmtpPasswd.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpPasswd.TabIndex = 3;
            this.txtSmtpPasswd.UseSystemPasswordChar = true;
            // 
            // lblSmtpPasswd
            // 
            this.lblSmtpPasswd.AutoSize = true;
            this.lblSmtpPasswd.Location = new System.Drawing.Point(38, 102);
            this.lblSmtpPasswd.Name = "lblSmtpPasswd";
            this.lblSmtpPasswd.Size = new System.Drawing.Size(89, 13);
            this.lblSmtpPasswd.TabIndex = 14;
            this.lblSmtpPasswd.Text = "SMTP Password:";
            // 
            // grpEmailInfo
            // 
            this.grpEmailInfo.Controls.Add(this.txtEmailSubject);
            this.grpEmailInfo.Controls.Add(this.txtEmailTo);
            this.grpEmailInfo.Controls.Add(this.lblEmailTo);
            this.grpEmailInfo.Controls.Add(this.lblEmailSubject);
            this.grpEmailInfo.Controls.Add(this.txtEmailFrom);
            this.grpEmailInfo.Controls.Add(this.lblEmailFrom);
            this.grpEmailInfo.Location = new System.Drawing.Point(12, 180);
            this.grpEmailInfo.Name = "grpEmailInfo";
            this.grpEmailInfo.Size = new System.Drawing.Size(300, 100);
            this.grpEmailInfo.TabIndex = 14;
            this.grpEmailInfo.TabStop = false;
            this.grpEmailInfo.Text = "Email Info";
            // 
            // EmailConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 318);
            this.ControlBox = false;
            this.Controls.Add(this.grpEmailInfo);
            this.Controls.Add(this.grpSmtpInfo);
            this.Controls.Add(this.btnAccept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Email Configuration";
            this.grpSmtpInfo.ResumeLayout(false);
            this.grpSmtpInfo.PerformLayout();
            this.grpEmailInfo.ResumeLayout(false);
            this.grpEmailInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label lblSmtpServer;
        private System.Windows.Forms.Label lblSmtpPort;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.Label lblEmailSubject;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblSmtpUser;
        private System.Windows.Forms.TextBox txtSmtpUser;
        private System.Windows.Forms.GroupBox grpSmtpInfo;
        private System.Windows.Forms.TextBox txtSmtpPasswd;
        private System.Windows.Forms.Label lblSmtpPasswd;
        private System.Windows.Forms.GroupBox grpEmailInfo;
        private System.Windows.Forms.CheckBox chkSslEnabled;
        private System.Windows.Forms.Label lblSslEnabled;
    }
}