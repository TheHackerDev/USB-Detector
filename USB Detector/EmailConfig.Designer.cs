namespace USB_Detector
{
    partial class EmailConfig
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
            this.SuspendLayout();
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(145, 12);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(150, 20);
            this.txtSmtpServer.TabIndex = 0;
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
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(78, 93);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(61, 13);
            this.lblEmailFrom.TabIndex = 7;
            this.lblEmailFrom.Text = "Email From:";
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(145, 90);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(150, 20);
            this.txtEmailFrom.TabIndex = 6;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(88, 67);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(51, 13);
            this.lblEmailTo.TabIndex = 5;
            this.lblEmailTo.Text = "Email To:";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(145, 64);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(150, 20);
            this.txtEmailTo.TabIndex = 4;
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.AutoSize = true;
            this.lblEmailSubject.Location = new System.Drawing.Point(19, 119);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(120, 13);
            this.lblEmailSubject.TabIndex = 9;
            this.lblEmailSubject.Text = "Email Subject (optional):";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(145, 116);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(150, 20);
            this.txtEmailSubject.TabIndex = 8;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(130, 143);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // EmailConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 178);
            this.ControlBox = false;
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
            this.Name = "EmailConfig";
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
    }
}