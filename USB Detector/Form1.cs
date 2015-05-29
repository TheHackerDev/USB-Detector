using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        // Device-specific information
        

        // For getting device information
        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }


        public Form1()
        {
            InitializeComponent();
        }

        // Overriding the base method in order to handle the WM_DEVICECHANGE event
        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    DEV_BROADCAST_VOLUME vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));

                    // The WParam value identifies what is occurring.
                    if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                    {
                        txt_output.Text = "Device inserted. ";
                        txt_output.Text += "Drive letter: " + DriveMaskToLetter(vol.dbcv_unitmask);
                        // TODO: Get more device information
                    }
                    else if (m.WParam.ToInt32() == DBT_DEVICEREMOVALCOMPLETE)
                    {
                        txt_output.Text = "Device removed.";
                        txt_output.Text += "Drive letter: " + DriveMaskToLetter(vol.dbcv_unitmask);
                    }
                }
            }
            catch (Exception e)
            {
                // Sometimes exceptions occur before the device is initialized.
            }
            
            // Continue to do what was originally done with the message
            base.WndProc(ref m);
        }

        // For determining where the drive was plugged in.
        private static char DriveMaskToLetter(int mask)
        {
            char letter;
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //1 = A, 2 = B, 3 = C
            int cnt = 0;
            int pom = mask / 2;
            while (pom != 0)    // while there is any bit set in the mask shift it right      
            {
                pom = pom / 2;
                cnt++;
            }
            letter = cnt < drives.Length ? drives[cnt] : '?';
            return letter;
        }
    }
}
