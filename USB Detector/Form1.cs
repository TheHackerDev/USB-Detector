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
    public partial class Form1 : Form
    {
        // For detecting device insertion and removal.
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVALCOMPLETE = 0x8004;
        private const int WM_DEVICECHANGE = 0x0219;


        public Form1()
        {
            InitializeComponent();
        }

        // Overriding the base method in order to handle the WM_DEVICECHANGE event
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    // The WParam value identifies what is occurring.
                    if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                    {
                        txt_output.Text = "Device inserted.";
                    }
                    else if (m.WParam.ToInt32() == DBT_DEVICEREMOVALCOMPLETE)
                    {
                        txt_output.Text = "Device removed.";
                    }
                    break;
            }
            
            // Continue to do what was originally done with the message
            base.WndProc(ref m);


        }
    }
}
