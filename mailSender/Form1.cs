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
using System.IO;

namespace mailSender
{
    
    public partial class mailSender : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        long size;
       

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
            attachementListBox.Hide();





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

        private void portDomain_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void attachementPictureBox_Click(object sender, EventArgs e)
        {
            
            //ofd.Filter = "JPG|*.jpg"; //filtr danych w ofd
            if(ofd.ShowDialog()==DialogResult.OK) //wykonuje sie tylko gdy nacisniesz ok
            {
                
                Attachment atch = new Attachment(ofd.FileName);
                FileInfo info = new FileInfo(ofd.FileName);

                size = info.Length/(1024*1024); //zamiana na mb
                attachementProgressBar.Minimum = 0;
                attachementProgressBar.Maximum = 25;
                int procentage;

                if (size > 25)
                {
                    MessageBox.Show(string.Format("Attachment must be smaller than 25mb!"), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    attachementProgressBar.Increment(Convert.ToInt32(size));
                    procentage = attachementProgressBar.Value * 4;
                    procentageLabel.Text = Convert.ToString(procentage) + "%";
                    attachementListBox.Items.Add(info.Name);
                    attachementListBox.Show();
                }
                
            }

        }

        private void attachementListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void delAtchButton_Click(object sender, EventArgs e)
        {
            if (attachementListBox.Items.Count<=0)
            {
               
            }
            else
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(attachementListBox);
                selectedItems = attachementListBox.SelectedItems;
                FileInfo info2 = new FileInfo(attachementListBox.SelectedItem.ToString());
                // long size2 = info2.Length / (1024 * 1024);

                if (attachementListBox.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        attachementListBox.Items.Remove(selectedItems[i]);
                    // attachementProgressBar.Increment(-Convert.ToInt32(info2.Length/(1024*1024)));

                }
            }
        }

        

        
    }
}
