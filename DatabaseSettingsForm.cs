using FingerprintUploader.Models;
using FingerprintUploader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FingerprintUploader
{
    public partial class DatabaseSettingsForm : Form
    {
        public DatabaseSettingsForm()
        {
            InitializeComponent();
        }

        private void DatabaseSettingsForm_Load(object sender, EventArgs e)
        {
            var config = ConfigManager.LoadConfig();

            if (config != null && config.Database != null)
            {
                textBox1.Text = config.Database.Host;
                textBox2.Text = config.Database.Port;
                textBox3.Text = config.Database.Username;
                textBox4.Text = config.Database.Password;
                textBox5.Text = config.Database.DBName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var config = ConfigManager.LoadConfig();
            config.Database = new DatabaseConfig
            {
                Host = textBox1.Text,
                Port = textBox2.Text,
                Username = textBox3.Text,
                Password = textBox4.Text,
                DBName = textBox5.Text,
            };
            ConfigManager.SaveConfig(config);
            MessageBox.Show("Database settings saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
