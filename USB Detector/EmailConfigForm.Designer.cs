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
            this.lblSmtpPasswd = new System.Windows.Forms.Label();
            this.txtSmtpPasswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(145, 12);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpServer.TabIndex = 0;
            this.txtSmtpServer.Leave += new System.EventHandler(this.Validate_txtSmtpServer);
            // 
            // lblSmtpServer
            // 
            this.lblSmtpServer.AutoSize = true;
            this.lblSmtpServer.Location = new System.Drawing.Point(65, 15);
            this.lblSmtpServer.Name = "lblSmtpServer";
            this.lblSmtpServer.Size = new System.Drawing.Size(74, 13);
            this.lblSmtpServer.TabIndex = 1;
            this.lblSmtpServer.Text = "SMTP Server:";
            // 
            // lblSmtpPort
            // 
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Location = new System.Drawing.Point(77, 41);
            this.lblSmtpPort.Name = "lblSmtpPort";
            this.lblSmtpPort.Size = new System.Drawing.Size(62, 13);
            this.lblSmtpPort.TabIndex = 3;
            this.lblSmtpPort.Text = "SMTP Port:";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(145, 38);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpPort.TabIndex = 2;
            this.txtSmtpPort.TextChanged += new System.EventHandler(this.txtSmtpPort_TextChanged);
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(78, 120);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(61, 13);
            this.lblEmailFrom.TabIndex = 7;
            this.lblEmailFrom.Text = "Email From:";
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(145, 117);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(150, 20);
            this.txtEmailFrom.TabIndex = 6;
            this.txtEmailFrom.TextChanged += new System.EventHandler(this.txtEmailFrom_TextChanged);
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(88, 94);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(51, 13);
            this.lblEmailTo.TabIndex = 5;
            this.lblEmailTo.Text = "Email To:";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(145, 91);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(150, 20);
            this.txtEmailTo.TabIndex = 4;
            this.txtEmailTo.TextChanged += new System.EventHandler(this.txtEmailTo_TextChanged);
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.AutoSize = true;
            this.lblEmailSubject.Location = new System.Drawing.Point(19, 146);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(120, 13);
            this.lblEmailSubject.TabIndex = 9;
            this.lblEmailSubject.Text = "Email Subject (optional):";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(145, 143);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(150, 20);
            this.txtEmailSubject.TabIndex = 8;
            this.txtEmailSubject.TextChanged += new System.EventHandler(this.txtEmailSubject_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(130, 170);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblSmtpPasswd
            // 
            this.lblSmtpPasswd.AutoSize = true;
            this.lblSmtpPasswd.Location = new System.Drawing.Point(50, 67);
            this.lblSmtpPasswd.Name = "lblSmtpPasswd";
            this.lblSmtpPasswd.Size = new System.Drawing.Size(89, 13);
            this.lblSmtpPasswd.TabIndex = 12;
            this.lblSmtpPasswd.Text = "SMTP Password:";
            // 
            // txtSmtpPasswd
            // 
            this.txtSmtpPasswd.Location = new System.Drawing.Point(145, 64);
            this.txtSmtpPasswd.Name = "txtSmtpPasswd";
            this.txtSmtpPasswd.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpPasswd.TabIndex = 11;
            this.txtSmtpPasswd.TextChanged += new System.EventHandler(this.txtSmtpPasswd_TextChanged);
            // 
            // EmailConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.ControlBox = false;
            this.Controls.Add(this.lblSmtpPasswd);
            this.Controls.Add(this.txtSmtpPasswd);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblEmailSubject);
            this.Controls.Add(this.txtEmailSubject);
            this.Controls.Add(this.lblEmailFrom);
            this.Controls.Add(this.txtEmailFrom);
            this.Controls.Add(this.lblEmailTo);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.lblSmtpPort);
            this.Controls.Add(this.txtSmtpPort);
            this.Controls.Add(this.lblSmtpServer);
            this.Controls.Add(this.txtSmtpServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Email Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblSmtpPasswd;
        private System.Windows.Forms.TextBox txtSmtpPasswd;
    }
}