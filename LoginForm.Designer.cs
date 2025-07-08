namespace FingerprintUploader
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            Login.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ControlLightLight;
            Login.Controls.Add(label2);
            Login.Controls.Add(label1);
            Login.Controls.Add(button1);
            Login.Controls.Add(textBox2);
            Login.Controls.Add(textBox1);
            Login.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = SystemColors.MenuHighlight;
            Login.Location = new Point(93, 50);
            Login.Name = "Login";
            Login.Size = new Size(498, 277);
            Login.TabIndex = 0;
            Login.TabStop = false;
            Login.Text = "Login";
            Login.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 119);
            label2.Name = "label2";
            label2.Size = new Size(56, 13);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 61);
            label1.Name = "label1";
            label1.Size = new Size(58, 13);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Cyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(49, 184);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 139);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(403, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(651, 9);
            label3.Name = "label3";
            label3.Size = new Size(20, 21);
            label3.TabIndex = 1;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(682, 377);
            Controls.Add(label3);
            Controls.Add(Login);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Login;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
