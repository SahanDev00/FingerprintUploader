using FingerprintUploader.Models;
using FingerprintUploader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FingerprintUploader
{
    public partial class FingerprintMachineSettingsForm : Form
    {
        public FingerprintMachineSettingsForm()
        {
            InitializeComponent();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var config = ConfigManager.LoadConfig();
            config.Scanner = new ScannerConfig
            {
                IPAddress = textBox1.Text,
                Port = textBox2.Text,
                UserName = textBox3.Text,
                Password = textBox4.Text,
                Model = comboBox1.SelectedItem.ToString()
            };
            ConfigManager.SaveConfig(config);
            MessageBox.Show("Scanner settings saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FingerprintMachineSettingsForm_Load(object sender, EventArgs e)
        {
            var config = ConfigManager.LoadConfig();

            comboBox1.Items.AddRange(new string[]
                {
                    "Hikvision",
                    "Realand"
                });

            if (config != null && config.Scanner != null)
            {
                textBox1.Text = config.Scanner.IPAddress;
                textBox2.Text = config.Scanner.Port;
                textBox3.Text = config.Scanner.UserName;
                textBox4.Text = config.Scanner.Password;
                comboBox1.SelectedItem = config.Scanner.Model;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = textBox1.Text.Trim();
                string port = textBox2.Text.Trim();
                string username = textBox3.Text.Trim();
                string password = textBox4.Text.Trim();

                if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
                {
                    MessageBox.Show("IP and Port are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Force TLS 1.2 (or lower if device requires)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string model = comboBox1.SelectedItem?.ToString() ?? "";
                string url = model == "Realand"
                    ? $"http://{ip}:{port}/log/get"
                    : $"https://{ip}:{port}/ISAPI/System/status"; // Try HTTPS first

                var handler = new HttpClientHandler
                {
                    Credentials = new NetworkCredential(username, password),
                    PreAuthenticate = true, // Helps with Digest Auth
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true // Bypass SSL for testing
                };

                using (var client = new HttpClient(handler))
                {
                    client.Timeout = TimeSpan.FromSeconds(15);
                    client.DefaultRequestHeaders.Add("User-Agent", "YourApp/1.0");

                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Device responded with error: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Connection timed out. Check IP, Port, and Network.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
