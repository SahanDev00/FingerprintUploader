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

namespace FingerprintUploader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseSettingsForm databaseSettingsForm = new DatabaseSettingsForm();
            databaseSettingsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FingerprintMachineSettingsForm fingerprintMachineSettingsForm = new FingerprintMachineSettingsForm();
            fingerprintMachineSettingsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HikvisionClient client = new HikvisionClient();
                List<FingerprintRecord> records = client.DownloadLogs();

                // Bind to GridView
                dataGridView1.DataSource = null; // reset first
                dataGridView1.DataSource = records;

                FingerprintTempManager.Save(records);

                MessageBox.Show($"Downloaded {records.Count} records!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Store to temp or pass to uploader
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var records = FingerprintTempManager.Load();
                if (records == null || records.Count == 0)
                {
                    MessageBox.Show("No records found to upload!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MySQLUploader uploader = new MySQLUploader();
                uploader.Upload(records);

                FingerprintTempManager.Clear(); // optional, but recommended

                MessageBox.Show("Upload successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upload failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
