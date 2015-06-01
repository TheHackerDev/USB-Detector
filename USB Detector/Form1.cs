using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // For getting basic device information from the device events
        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }

        // The device information
        private Dictionary<char, DeviceInfo> devices = new Dictionary<char, DeviceInfo>(); // CHAR SHOULD BE UPPER CASE
        public struct DeviceInfo
        {
            public readonly string DriveFormat;
            public readonly long DriveSize;
            public readonly string DriveLabel;
            public readonly char DriveLetter;

            public DeviceInfo(string driveFormat, long driveSize, string driveLabel, char driveLetter)
            {
                this.DriveFormat = driveFormat;
                this.DriveSize = driveSize;
                this.DriveLabel = driveLabel;
                this.DriveLetter = driveLetter.ToString().ToUpper().ToCharArray()[0]; // ensure it is always upper case
            }
        }

        public Form1()
        {
            InitializeComponent();
            
            // Get the existing drive information
            EnumDrives();
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
                        char driveLetter = DriveMaskToLetter(vol.dbcv_unitmask);

                        txt_output.Text = "Device inserted. ";
                        txt_output.Text += "\nDrive letter: " + driveLetter;
                        if (driveLetter != '?')
                        {
                            // Add the device to the existing device map
                            DeviceInfo device = GetDeviceInfo(driveLetter);
                            devices.Add(driveLetter, device);

                            // Print the device data to the screen
                            txt_output.Text += "\nDrive format: " + device.DriveFormat;
                            txt_output.Text += "\nDrive label: " + device.DriveLabel;
                            txt_output.Text += "\nDrive size (bytes): " + device.DriveSize;
                        }
                    }
                    else if (m.WParam.ToInt32() == DBT_DEVICEREMOVALCOMPLETE)
                    {
                        char driveLetter = DriveMaskToLetter(vol.dbcv_unitmask);

                        txt_output.Text = "Device removed.";
                        txt_output.Text += "\nDrive letter: " + driveLetter;
                        
                        // Check if device was already mapped
                        if (driveLetter != '?' && devices.ContainsKey(driveLetter))
                        {
                            // Get the previous entry from the drive mapping
                            DeviceInfo device = devices[driveLetter];

                            // Output information
                            txt_output.Text += "\nDrive format: " + device.DriveFormat;
                            txt_output.Text += "\nDrive label: " + device.DriveLabel;
                            txt_output.Text += "\nDrive size (bytes): " + device.DriveSize;

                            // Remove drive from mapping
                            devices.Remove(driveLetter);
                        }
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
        private static char DriveMaskToLetter(int logicalUnitMask)
        {
            char letter;
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //1 = A, 2 = B, 3 = C
            int count = 0;
            int tmpMask = logicalUnitMask / 2;
            // while there is any bit set in the mask shift it right
            while (tmpMask != 0)      
            {
                tmpMask = tmpMask / 2;
                count++;
            }
            letter = count < drives.Length ? drives[count] : '?';
            return letter;
        }

        private DeviceInfo GetDeviceInfo(char driveLetter)
        {
            try
            {
                DriveInfo info = new DriveInfo(driveLetter.ToString());
                DeviceInfo device = new DeviceInfo(
                    info.DriveFormat, 
                    info.TotalSize, 
                    info.VolumeLabel, 
                    driveLetter
                    );

                return device;
            }
            catch (IOException ioException)
            {
                // Empty drive
                DeviceInfo device = new DeviceInfo();
                return device;
            }

            //TODO: get drive serial number.
        }

        // Enumerate the existing drives to create a map associated with the drive letters.
        private void EnumDrives()
        {
            foreach (var drive in Environment.GetLogicalDrives())
            {
                char driveLetter = drive.Substring(0, 1).ToUpper().ToCharArray()[0];
                devices.Add(driveLetter, GetDeviceInfo(driveLetter));
            }
        }
    }
}
