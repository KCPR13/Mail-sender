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
using System.Net.Mime;

namespace mailSender
{
    
    
    public partial class mailSender : Form
    {
        
        OpenFileDialog ofd = new OpenFileDialog();
        MailMessage msg;
        List<int> sizeAttachement = new List<int>();
        List<string> nameAttachement = new List<string>();
        long size;
        int procentage;
        string path;
     


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
            PasswordTextBox.PasswordChar = '*'; 
            PasswordTextBox.MaxLength = 32; 
            
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
                using (SmtpClient client = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = usernameTextBox.Text,
                        Password = PasswordTextBox.Text

                    };
                    client.Credentials = credential;
                    for (int z = 0; z < smtpCheckedListBox.Items.Count; z++)
                    {
                        if (smtpCheckedListBox.GetItemChecked(z))
                        {
                            string str = (string)smtpCheckedListBox.Items[z];
                            client.Host = str;
                        }
                    }
                    client.Port = Int32.Parse(portDomain.SelectedItem.ToString());
                    client.EnableSsl = sslCheckBox.Checked;
                    msg.To.Add(new MailAddress(toTextBox.Text));
                    msg.From = new MailAddress(emailTextBox.Text);
                    msg.Subject = subjectTextBox.Text;
                    msg.Body = messageTextBox.Text;
                    msg.IsBodyHtml = true;
                    msg.Attachments.Add(new Attachment(path));
                    try
                    {
                        client.Send(msg);
                    }
                    catch
                    {
                        MessageBox.Show(string.Format("Email cannot be sent "), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }
            }
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
            
            ofd.Filter = "All files (*.*)|*.*"; //filtr danych w ofd
            if(ofd.ShowDialog()==DialogResult.OK) //wykonuje sie tylko gdy nacisniesz ok
            {

                 path = ofd.FileName.ToString();
                FileInfo info = new FileInfo(ofd.FileName);
                sizeAttachement.Add(Convert.ToInt32(info.Length / (1024 * 1024)));
                nameAttachement.Add(ofd.FileName);
                size = info.Length/(1024*1024); //zamiana na mb
                attachementProgressBar.Minimum = 0;
                attachementProgressBar.Maximum = 25;
               
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
            if (attachementListBox.SelectedIndex == -1)
            {

            }
            else
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(attachementListBox);
                selectedItems = attachementListBox.SelectedItems;
               

                if (attachementListBox.SelectedIndex != -1)
                {
                    int attachementListBoxindex = attachementListBox.SelectedIndex;
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    attachementListBox.Items.Remove(selectedItems[i]);
                    if(nameAttachement.Count >=0)
                    {
                        msg.Attachments.RemoveAt(attachementListBoxindex);
                    }
                    
                    attachementProgressBar.Increment(-sizeAttachement[attachementListBoxindex]);
                    sizeAttachement.RemoveAt(attachementListBoxindex);
                    procentage = attachementProgressBar.Value * 4;
                    procentageLabel.Text = Convert.ToString(procentage) + "%";

                    
                    //for(int z=0; z<=nameAttachement.Count; z++)
                    //{
                    //    foreach (Attachment attachment in msg.Attachments)
                    //    {   
                    //        if (attachment.Name == Convert.ToString(nameAttachement[z]))
                    //        {
                    //            msg.Attachments.Remove(attachment);
                    //            break;
                    //        }
                    //    }
                      
                    //}


                }
                


            }
        }
    }
}

