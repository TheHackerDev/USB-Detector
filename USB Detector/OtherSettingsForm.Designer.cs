namespace USB_Detector
{
    partial class OtherSettingsForm
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
            this.grpLogging = new System.Windows.Forms.GroupBox();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLogLocation = new System.Windows.Forms.TextBox();
            this.lblLogEnabled = new System.Windows.Forms.Label();
            this.chkLogEnabled = new System.Windows.Forms.CheckBox();
            this.btnOpenLogLocation = new System.Windows.Forms.Button();
            this.lblSelectLogLocation = new System.Windows.Forms.Label();
            this.grpLogging.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogging
            // 
            this.grpLogging.Controls.Add(this.lblSelectLogLocation);
            this.grpLogging.Controls.Add(this.btnOpenLogLocation);
            this.grpLogging.Controls.Add(this.chkLogEnabled);
            this.grpLogging.Controls.Add(this.lblLogEnabled);
            this.grpLogging.Controls.Add(this.txtLogLocation);
            this.grpLogging.Controls.Add(this.lblEmailTo);
            this.grpLogging.Location = new System.Drawing.Point(12, 12);
            this.grpLogging.Name = "grpLogging";
            this.grpLogging.Size = new System.Drawing.Size(310, 100);
            this.grpLogging.TabIndex = 18;
            this.grpLogging.TabStop = false;
            this.grpLogging.Text = "Logging";
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(53, 19);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(72, 13);
            this.lblEmailTo.TabIndex = 5;
            this.lblEmailTo.Text = "Log Location:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(143, 118);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 17;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "%appdata%/USB Detector/Log";
            // 
            // txtLogLocation
            // 
            this.txtLogLocation.Location = new System.Drawing.Point(131, 16);
            this.txtLogLocation.Name = "txtLogLocation";
            this.txtLogLocation.ReadOnly = true;
            this.txtLogLocation.Size = new System.Drawing.Size(170, 20);
            this.txtLogLocation.TabIndex = 6;
            // 
            // lblLogEnabled
            // 
            this.lblLogEnabled.AutoSize = true;
            this.lblLogEnabled.Location = new System.Drawing.Point(76, 44);
            this.lblLogEnabled.Name = "lblLogEnabled";
            this.lblLogEnabled.Size = new System.Drawing.Size(49, 13);
            this.lblLogEnabled.TabIndex = 7;
            this.lblLogEnabled.Text = "Enabled:";
            // 
            // chkLogEnabled
            // 
            this.chkLogEnabled.AutoSize = true;
            this.chkLogEnabled.Location = new System.Drawing.Point(131, 43);
            this.chkLogEnabled.Name = "chkLogEnabled";
            this.chkLogEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkLogEnabled.TabIndex = 8;
            this.chkLogEnabled.UseVisualStyleBackColor = true;
            // 
            // btnOpenLogLocation
            // 
            this.btnOpenLogLocation.Location = new System.Drawing.Point(131, 64);
            this.btnOpenLogLocation.Name = "btnOpenLogLocation";
            this.btnOpenLogLocation.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLogLocation.TabIndex = 9;
            this.btnOpenLogLocation.Text = "Open";
            this.btnOpenLogLocation.UseVisualStyleBackColor = true;
            this.btnOpenLogLocation.Click += new System.EventHandler(this.btnOpenLogLocation_Click);
            // 
            // lblSelectLogLocation
            // 
            this.lblSelectLogLocation.AutoSize = true;
            this.lblSelectLogLocation.Location = new System.Drawing.Point(20, 69);
            this.lblSelectLogLocation.Name = "lblSelectLogLocation";
            this.lblSelectLogLocation.Size = new System.Drawing.Size(105, 13);
            this.lblSelectLogLocation.TabIndex = 10;
            this.lblSelectLogLocation.Text = "Select Log Location:";
            // 
            // OtherSettingsForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 147);
            this.ControlBox = false;
            this.Controls.Add(this.grpLogging);
            this.Controls.Add(this.btnAccept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherSettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Other Settings";
            this.grpLogging.ResumeLayout(false);
            this.grpLogging.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogging;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtLogLocation;
        private System.Windows.Forms.Label lblSelectLogLocation;
        private System.Windows.Forms.Button btnOpenLogLocation;
        private System.Windows.Forms.CheckBox chkLogEnabled;
        private System.Windows.Forms.Label lblLogEnabled;
    }
}