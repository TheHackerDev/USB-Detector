using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Detector
{
    public partial class EmailConfigForm : Form
    {
        // Reference to the main form
        public Form MainForm = new Form();

        public EmailConfigForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Load the values into the email configuration instance
            // TODO
            
            // Switch back to the main window
            this.Close();
        }
    }
}
