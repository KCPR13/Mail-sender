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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailSender));
            this.Email = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.portDomain = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.smtpCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.attachementPictureBox = new System.Windows.Forms.PictureBox();
            this.attachementProgressBar = new System.Windows.Forms.ProgressBar();
            this.procentageLabel = new System.Windows.Forms.Label();
            this.attachementListBox = new System.Windows.Forms.ListBox();
            this.delAtchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.attachementPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.Location = new System.Drawing.Point(5, 20);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(91, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(106, 20);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(552, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(106, 60);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(552, 22);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSend.Location = new System.Drawing.Point(305, 600);
            this.buttonSend.MaximumSize = new System.Drawing.Size(1620, 810);
            this.buttonSend.MinimumSize = new System.Drawing.Size(90, 45);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(90, 45);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // portDomain
            // 
            this.portDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portDomain.Location = new System.Drawing.Point(68, 558);
            this.portDomain.MaximumSize = new System.Drawing.Size(110, 0);
            this.portDomain.MinimumSize = new System.Drawing.Size(110, 0);
            this.portDomain.Name = "portDomain";
            this.portDomain.Size = new System.Drawing.Size(110, 22);
            this.portDomain.TabIndex = 9;
            this.portDomain.Text = "587";
            this.portDomain.SelectedItemChanged += new System.EventHandler(this.portDomain_SelectedItemChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 560);
            this.label2.MaximumSize = new System.Drawing.Size(60, 20);
            this.label2.MinimumSize = new System.Drawing.Size(60, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // smtpLabel
            // 
            this.smtpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smtpLabel.Location = new System.Drawing.Point(203, 491);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(53, 20);
            this.smtpLabel.TabIndex = 11;
            this.smtpLabel.Text = "Smtp:";
            // 
            // sslCheckBox
            // 
            this.sslCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sslCheckBox.AutoSize = true;
            this.sslCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sslCheckBox.Location = new System.Drawing.Point(10, 590);
            this.sslCheckBox.MaximumSize = new System.Drawing.Size(80, 24);
            this.sslCheckBox.MinimumSize = new System.Drawing.Size(80, 24);
            this.sslCheckBox.Name = "sslCheckBox";
            this.sslCheckBox.Size = new System.Drawing.Size(80, 24);
            this.sslCheckBox.TabIndex = 13;
            this.sslCheckBox.Text = "SSL";
            this.sslCheckBox.UseVisualStyleBackColor = true;
            // 
            // smtpCheckedListBox
            // 
            this.smtpCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpCheckedListBox.FormattingEnabled = true;
            this.smtpCheckedListBox.Items.AddRange(new object[] {
            "poczta.interia.pl",
            "poczta.o2.pl",
            "smtp.gmail.com",
            "smtp.live.com",
            "smtp.mail.yahoo.com",
            "smtp.poczta.onet.pl",
            "smtp.wp.pl",
            "smtp-mail.outlook.com"});
            this.smtpCheckedListBox.Location = new System.Drawing.Point(262, 491);
            this.smtpCheckedListBox.Name = "smtpCheckedListBox";
            this.smtpCheckedListBox.Size = new System.Drawing.Size(396, 89);
            this.smtpCheckedListBox.TabIndex = 14;
            this.smtpCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.smtpCheckedListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Subject:";
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Location = new System.Drawing.Point(106, 140);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(552, 22);
            this.toTextBox.TabIndex = 17;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(106, 180);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(552, 22);
            this.subjectTextBox.TabIndex = 18;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Location = new System.Drawing.Point(10, 208);
            this.messageTextBox.MaximumSize = new System.Drawing.Size(3000, 750);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(648, 232);
            this.messageTextBox.TabIndex = 19;
            // 
            // attachementPictureBox
            // 
            this.attachementPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachementPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.attachementPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("attachementPictureBox.Image")));
            this.attachementPictureBox.Location = new System.Drawing.Point(14, 446);
            this.attachementPictureBox.Name = "attachementPictureBox";
            this.attachementPictureBox.Size = new System.Drawing.Size(30, 30);
            this.attachementPictureBox.TabIndex = 20;
            this.attachementPictureBox.TabStop = false;
            this.attachementPictureBox.Click += new System.EventHandler(this.attachementPictureBox_Click);
            // 
            // attachementProgressBar
            // 
            this.attachementProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachementProgressBar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.attachementProgressBar.Location = new System.Drawing.Point(58, 451);
            this.attachementProgressBar.MaximumSize = new System.Drawing.Size(3000, 25);
            this.attachementProgressBar.MinimumSize = new System.Drawing.Size(600, 25);
            this.attachementProgressBar.Name = "attachementProgressBar";
            this.attachementProgressBar.Size = new System.Drawing.Size(600, 25);
            this.attachementProgressBar.TabIndex = 21;
            // 
            // procentageLabel
            // 
            this.procentageLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.procentageLabel.AutoSize = true;
            this.procentageLabel.BackColor = System.Drawing.Color.Transparent;
            this.procentageLabel.Location = new System.Drawing.Point(358, 455);
            this.procentageLabel.Name = "procentageLabel";
            this.procentageLabel.Size = new System.Drawing.Size(28, 17);
            this.procentageLabel.TabIndex = 22;
            this.procentageLabel.Text = "0%";
            // 
            // attachementListBox
            // 
            this.attachementListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachementListBox.FormattingEnabled = true;
            this.attachementListBox.ItemHeight = 16;
            this.attachementListBox.Location = new System.Drawing.Point(10, 356);
            this.attachementListBox.Name = "attachementListBox";
            this.attachementListBox.Size = new System.Drawing.Size(648, 84);
            this.attachementListBox.TabIndex = 23;
            this.attachementListBox.SelectedIndexChanged += new System.EventHandler(this.attachementListBox_SelectedIndexChanged);
            // 
            // delAtchButton
            // 
            this.delAtchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delAtchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delAtchButton.Location = new System.Drawing.Point(10, 482);
            this.delAtchButton.MaximumSize = new System.Drawing.Size(180, 55);
            this.delAtchButton.MinimumSize = new System.Drawing.Size(115, 55);
            this.delAtchButton.Name = "delAtchButton";
            this.delAtchButton.Size = new System.Drawing.Size(115, 55);
            this.delAtchButton.TabIndex = 24;
            this.delAtchButton.Text = "delete attachment";
            this.delAtchButton.UseVisualStyleBackColor = true;
            this.delAtchButton.Click += new System.EventHandler(this.delAtchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(5, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "E-mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(106, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(552, 22);
            this.emailTextBox.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 603);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 22);
            this.textBox1.TabIndex = 29;
            // 
            // mailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.delAtchButton);
            this.Controls.Add(this.attachementListBox);
            this.Controls.Add(this.procentageLabel);
            this.Controls.Add(this.attachementProgressBar);
            this.Controls.Add(this.attachementPictureBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smtpCheckedListBox);
            this.Controls.Add(this.sslCheckBox);
            this.Controls.Add(this.smtpLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portDomain);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "mailSender";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attachementPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.DomainUpDown portDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.CheckBox sslCheckBox;
        private System.Windows.Forms.CheckedListBox smtpCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.PictureBox attachementPictureBox;
        private System.Windows.Forms.ProgressBar attachementProgressBar;
        private System.Windows.Forms.Label procentageLabel;
        private System.Windows.Forms.ListBox attachementListBox;
        private System.Windows.Forms.Button delAtchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

