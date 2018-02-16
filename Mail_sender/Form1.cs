using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;

namespace Mail_sender
{
    public partial class Form1 : Form
    {
        public static int size =0;
        public string password, login, email, consignor;
        public Form1()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }
        OpenFileDialog ofd = new OpenFileDialog();

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ofd.Filter = "RAR|*.rar";   // Rar filter
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                FileNameTextBox.Text = ofd.FileName;
                SaveFileNameTextBox.Text = ofd.SafeFileName;
                checkedListBox.Items.Add(ofd.SafeFileName);

                
            }
        }

        private void maskedTextBox2_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteCLick(object sender, EventArgs e)
        {
            foreach ( var item in checkedListBox.CheckedItems.OfType<string>().ToList())
            {
                size = (int)checkedListBox.SizeChanged();
                checkedListBox.Items.Remove(item);
            }
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressAttachmentBar.Increment(size);
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");   //Simple Mail Transfer Protocol
                email = EmailTextBox.Text;
                password = PasswordTextBox.Text;
                consignor = consignorTextBox.Text;
                mail.From = new MailAddress(consignor);   //mail nadawcy
                mail.To.Add(email);                   //mail odbiorcy
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment("attachment");
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(login, password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}
