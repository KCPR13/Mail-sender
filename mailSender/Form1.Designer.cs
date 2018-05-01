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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.portDomain = new System.Windows.Forms.DomainUpDown();
            this.portLabel = new System.Windows.Forms.Label();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.smtpCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.attachementPictureBox = new System.Windows.Forms.PictureBox();
            this.attachementProgressBar = new System.Windows.Forms.ProgressBar();
            this.procentageLabel = new System.Windows.Forms.Label();
            this.attachementListBox = new System.Windows.Forms.ListBox();
            this.delAtchButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.attachementPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(5, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
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
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(5, 60);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
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
            // 
            // portLabel
            // 
            this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portLabel.Location = new System.Drawing.Point(8, 560);
            this.portLabel.MaximumSize = new System.Drawing.Size(60, 20);
            this.portLabel.MinimumSize = new System.Drawing.Size(60, 20);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(60, 20);
            this.portLabel.TabIndex = 10;
            this.portLabel.Text = "Port:";
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
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toLabel.Location = new System.Drawing.Point(5, 140);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(33, 20);
            this.toLabel.TabIndex = 15;
            this.toLabel.Text = "To:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectLabel.Location = new System.Drawing.Point(5, 180);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(70, 20);
            this.subjectLabel.TabIndex = 16;
            this.subjectLabel.Text = "Subject:";
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
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.Location = new System.Drawing.Point(5, 100);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 20);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "E-mail:";
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
            // mailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.delAtchButton);
            this.Controls.Add(this.attachementListBox);
            this.Controls.Add(this.procentageLabel);
            this.Controls.Add(this.attachementProgressBar);
            this.Controls.Add(this.attachementPictureBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.smtpCheckedListBox);
            this.Controls.Add(this.sslCheckBox);
            this.Controls.Add(this.smtpLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portDomain);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.DomainUpDown portDomain;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.CheckBox sslCheckBox;
        private System.Windows.Forms.CheckedListBox smtpCheckedListBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.PictureBox attachementPictureBox;
        private System.Windows.Forms.ProgressBar attachementProgressBar;
        private System.Windows.Forms.Label procentageLabel;
        private System.Windows.Forms.ListBox attachementListBox;
        private System.Windows.Forms.Button delAtchButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}

