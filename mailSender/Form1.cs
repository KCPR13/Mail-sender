using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace mailSender
{
    
    public partial class mailSender : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        string password;
        
        public mailSender()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.portDomain.Items;
            
            collection.Add("587");
            collection.Add("25");
            this.portDomain.Text = "587";
           

           
           
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*'; //password character
            PasswordTextBox.MaxLength = 16; //maximum 16 characters
        }

        private void Save_CheckedChanged(object sender, EventArgs e)
        {
            if(savePassword.Checked)
            { 
                password=PasswordTextBox.Text;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int counter;
            counter = smtpCheckedListBox.CheckedItems.Count;
            if (counter > 1) MessageBox.Show(string.Format("Select only one SMTP adress!"), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (counter == 0) MessageBox.Show(string.Format("Select one SMTP adress!"), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    login = new NetworkCredential(emailTextBox.Text, PasswordTextBox.Text);
                    foreach (string strSelected in smtpCheckedListBox.CheckedItems)
                    {
                        client = new SmtpClient(strSelected);
                    }
                    client.Port = Convert.ToInt32(portDomain.SelectedItem);
                    client.EnableSsl = sslCheckBox.Checked;
                    client.Credentials = login;
                     MessageBox.Show(string.Format("You've succeeded in logging in"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Equals(DialogResult.OK, DialogResult.OK))
                    {
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                     MessageBox.Show(string.Format("Wrong e-mail or password !"), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 


            }
            //foreach (string s in smtpCheckedListBox.CheckedItems)
            //{
            //    textBox3.Paste(s);
            //}
           // textBox3.Paste(portDomain.SelectedItem.ToString());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void smtpCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void smtpCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

    }
}
