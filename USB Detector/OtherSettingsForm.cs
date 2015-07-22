#region imports

using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

#endregion

namespace USB_Detector
{
    public partial class OtherSettingsForm : Form
    {
        public OtherSettingsForm()
        {
            InitializeComponent();

            // Read log file location and enabled/disabled from configuration file
            ReadConfigFile();
        }

        private void btnOpenLogLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                // Save the file to Other Settings
                Program.OtherSettings.LogFileLocation = file;

                // Show the file location in the text field
                txtLogLocation.Text = file;
            }
        }

        // Saves the configuration to a file
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Program.OtherSettings.LogFileLocation = txtLogLocation.Text;
            Program.OtherSettings.LoggingEnabled = chkLogEnabled.Checked;

            // Serialize the configuration into Json
            string jsonConfig = JsonConvert.SerializeObject(Program.OtherSettings);

            // Ensure the folder exists in %AppData% before saving
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string configFolder = Path.Combine(appDataFolder, "USB Detector");
            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }

            // Write to the file
            string configFile = Path.Combine(configFolder, "Other Settings.txt");
            using (var writer = new StreamWriter(configFile))
            {
                writer.WriteLine(jsonConfig);
            }

            // Hide the form
            this.Hide();
        }

        private void ReadConfigFile()
        {
            try
            {
                string configFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "USB Detector", "Other Settings.txt");
                string configTextJson;

                // If the config file exists, try loading the settings into the config
                if (File.Exists(configFile))
                {
                    using (var reader = new StreamReader(configFile))
                    {
                        // Read in the values from the configuration file
                        configTextJson = reader.ReadLine(); // should only have one line in the config file (for now)
                        Program.OtherSettings = JsonConvert.DeserializeObject<OtherSettings>(configTextJson);
                    }
                }
            }
            catch (Exception e)
            {
                // Something went wrong. Config defaults are set in Progam.cs, so nothing needs to be done here
            }

            // Set log file settings from config
            txtLogLocation.Text = Program.OtherSettings.LogFileLocation;
            chkLogEnabled.Checked = Program.OtherSettings.LoggingEnabled;
        }
    }
}