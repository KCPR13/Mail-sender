namespace mailSender
{
    partial class mailSender
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
            this.Email = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savePassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.portDomain = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.smtpCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.Location = new System.Drawing.Point(194, 9);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(62, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "E-mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 29);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(408, 22);
            this.emailTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 83);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(408, 22);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(181, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // savePassword
            // 
            this.savePassword.AutoSize = true;
            this.savePassword.Location = new System.Drawing.Point(12, 149);
            this.savePassword.Name = "savePassword";
            this.savePassword.Size = new System.Drawing.Size(163, 21);
            this.savePassword.TabIndex = 6;
            this.savePassword.Text = "Remember password";
            this.savePassword.UseVisualStyleBackColor = true;
            this.savePassword.CheckedChanged += new System.EventHandler(this.Save_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(180, 201);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 45);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // portDomain
            // 
            this.portDomain.Location = new System.Drawing.Point(56, 121);
            this.portDomain.Name = "portDomain";
            this.portDomain.Size = new System.Drawing.Size(110, 22);
            this.portDomain.TabIndex = 9;
            this.portDomain.Text = "587";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // smtpLabel
            // 
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smtpLabel.Location = new System.Drawing.Point(172, 123);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(53, 20);
            this.smtpLabel.TabIndex = 11;
            this.smtpLabel.Text = "Smtp:";
            // 
            // sslCheckBox
            // 
            this.sslCheckBox.AutoSize = true;
            this.sslCheckBox.Location = new System.Drawing.Point(12, 176);
            this.sslCheckBox.Name = "sslCheckBox";
            this.sslCheckBox.Size = new System.Drawing.Size(56, 21);
            this.sslCheckBox.TabIndex = 13;
            this.sslCheckBox.Text = "SSL";
            this.sslCheckBox.UseVisualStyleBackColor = true;
            // 
            // smtpCheckedListBox
            // 
            this.smtpCheckedListBox.FormattingEnabled = true;
            this.smtpCheckedListBox.Items.AddRange(new object[] {
            "poczta.interia.pl",
            "poczta.o2.pl",
            "smtp.gmail.com",
            "smtp.live.com",
            "smtp.mail.yahoo.com",
            "smtp.poczta.onet.pl",
            "smtp.wp.pl",
            "smtp-mail.outlook.com",
            "",
            "",
            ""});
            this.smtpCheckedListBox.Location = new System.Drawing.Point(223, 123);
            this.smtpCheckedListBox.Name = "smtpCheckedListBox";
            this.smtpCheckedListBox.Size = new System.Drawing.Size(197, 72);
            this.smtpCheckedListBox.TabIndex = 14;
            this.smtpCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.smtpCheckedListBox_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(408, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.smtpCheckedListBox);
            this.Controls.Add(this.sslCheckBox);
            this.Controls.Add(this.smtpLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portDomain);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.savePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.Email);
            this.Name = "mailSender";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox savePassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.DomainUpDown portDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.CheckBox sslCheckBox;
        private System.Windows.Forms.CheckedListBox smtpCheckedListBox;
        private System.Windows.Forms.TextBox textBox3;
    }
}

