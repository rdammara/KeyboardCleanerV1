using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace KeyboardCleaner
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void SaveConfiguration(AppConfig config)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppConfig));
            using (TextWriter writer = new StreamWriter("config.xml"))
            {
                serializer.Serialize(writer, config);
            }
        }

        private AppConfig LoadConfiguration()
        {
            if (File.Exists("config.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppConfig));
                using (TextReader reader = new StreamReader("config.xml"))
                {
                    return (AppConfig)serializer.Deserialize(reader);
                }
            }
            else
            {
                return new AppConfig(); // Return default configuration if file doesn't exist
            }
        }

        private bool settingsSaved = false;
        private void saveButton_Click(object sender, EventArgs e)
        {
            AppConfig config = LoadConfiguration(); // Load existing config or default

            config.PasswordProtectionEnabled = chkPasswordProtection.Checked;
            if (config.PasswordProtectionEnabled)
            {
                string newPassword = txtPassword.Text;
                if (!string.IsNullOrEmpty(newPassword))
                {
                    config.HashedPassword = HashPassword(newPassword);
                }
                else
                {
                    MessageBox.Show("Please enter a valid password.");
                    return; // Abort saving
                }
            }

            SaveConfiguration(config);
            settingsSaved = true;
            MessageBox.Show("Settings saved successfully.");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!settingsSaved)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit? The settings have not been saved.",
                    "Exit Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    return; // User chose not to exit
                }
            }

            this.Close(); // Close the settings form
        }
    }
    }

