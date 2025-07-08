namespace FingerprintUploader
{
    partial class FingerprintMachineSettingsForm
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
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(19, 22);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 25;
            label6.Text = "Scanner Settings";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(338, 16);
            label5.Name = "label5";
            label5.Size = new Size(20, 21);
            label5.TabIndex = 24;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(208, 314);
            button2.Name = "button2";
            button2.Size = new Size(130, 34);
            button2.TabIndex = 23;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(32, 314);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 22;
            button1.Text = "Test Connection";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 263);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 21;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 210);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 20;
            label3.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 154);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 19;
            label2.Text = "Port :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 18;
            label1.Text = "IP Address :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 258);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(212, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 67);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 27;
            label7.Text = "Model :";
            // 
            // FingerprintMachineSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(371, 367);
            Controls.Add(label7);
            Controls.Add(comboBox1);
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
            Name = "FingerprintMachineSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FingerprintMachineSettingsForm";
            Load += FingerprintMachineSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label7;
    }
}