namespace FingerprintUploader
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1")
            {
                this.Hide(); // hide login form
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog(); // block until closed
                this.Close(); // then safely close login form
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
