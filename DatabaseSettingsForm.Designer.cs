namespace FingerprintUploader
{
    partial class DatabaseSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 65);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 113);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 164);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(212, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(119, 217);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(212, 23);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 67);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Host :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 113);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Port :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 169);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 222);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Password :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(25, 320);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 8;
            button1.Text = "Test Connection";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(201, 320);
            button2.Name = "button2";
            button2.Size = new Size(130, 34);
            button2.TabIndex = 9;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(331, 5);
            label5.Name = "label5";
            label5.Size = new Size(20, 21);
            label5.TabIndex = 10;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(12, 11);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 11;
            label6.Text = "DB Settings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 272);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 13;
            label7.Text = "DB Name :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(119, 267);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(212, 23);
            textBox5.TabIndex = 12;
            // 
            // DatabaseSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(357, 377);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatabaseSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatabaseSettingsForm";
            Load += DatabaseSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
    }
}