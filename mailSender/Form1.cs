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
        MailMessage msg = new MailMessage();
        List<int> sizeAttachement = new List<int>();
        List<string> nameAttachement = new List<string>();
        long sizeSelectedAttachment;
        int procentageProgressBar;
        string AttachmentPath;

        public mailSender()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.portDomain.Items;
            collection.Add("587");  //2 typy portow 
            collection.Add("25");
            portDomain.SelectedIndex = 0; //domyslny indeks 0
            attachementListBox.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*'; //szyfrowanie hasła znakiem
            PasswordTextBox.MaxLength = 32;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            int CheckedSMTPAdressCounter;
            CheckedSMTPAdressCounter = smtpCheckedListBox.CheckedItems.Count;
            if (CheckedSMTPAdressCounter > 1) MessageBox.Show(string.Format("Select only one SMTP adress!"), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (CheckedSMTPAdressCounter == 0) MessageBox.Show(string.Format("Select one SMTP adress!"), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (SmtpClient client = new SmtpClient())
                {
                    bool mailSent; //flaga ktora informuje czy mail zostal wyslany
                    client.EnableSsl = sslCheckBox.Checked;
                    if (!sslCheckBox.Checked)
                    {
                        MessageBox.Show(string.Format("Please check SSL box"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
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
                                client.Host = str;  // przypisanie hosta emaila
                            }
                        }
                        client.Port = Int32.Parse(portDomain.SelectedItem.ToString()); //konwersja do inta portu
                        msg.To.Add(new MailAddress(toTextBox.Text));
                        msg.From = new MailAddress(emailTextBox.Text);
                        msg.Subject = subjectTextBox.Text;
                        msg.Body = messageTextBox.Text;
                        msg.IsBodyHtml = true; // ciało wiadomosci jest w HTML
                        client.Send(msg);
                        mailSent = true;
                    }
                    catch
                    {
                        if (sslCheckBox.Checked)
                        {
                            MessageBox.Show(string.Format("Email cannot be sent! "), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        mailSent = false;
                    }
                    if (mailSent)
                    {
                        MessageBox.Show(string.Format("E-mail has been succesfully sent"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void attachementPictureBox_Click(object sender, EventArgs e)
        {
            ofd.Filter = "All files (*.*)|*.*"; //filtr danych w ofd
            if (ofd.ShowDialog() == DialogResult.OK) //wykonuje sie tylko gdy nacisniesz ok
            {
                AttachmentPath = ofd.FileName.ToString();
                FileInfo info = new FileInfo(ofd.FileName);
                sizeAttachement.Add(Convert.ToInt32(info.Length / (1024 * 1024)));
                nameAttachement.Add(ofd.FileName);
                sizeSelectedAttachment = info.Length / (1024 * 1024); //zamiana na mb
                attachementProgressBar.Minimum = 0;
                attachementProgressBar.Maximum = 25;

                if (sizeSelectedAttachment > 25)
                {
                    MessageBox.Show(string.Format("Attachment must be smaller than 25mb!"), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    msg.Attachments.Add(new Attachment(AttachmentPath));
                    attachementProgressBar.Increment(Convert.ToInt32(sizeSelectedAttachment));
                    procentageProgressBar = attachementProgressBar.Value * 4; // mnozenie aby zakres wynosil 0-100%
                    procentageLabel.Text = Convert.ToString(procentageProgressBar) + "%";
                    attachementListBox.Items.Add(info.Name);
                    attachementListBox.Show();
                }
            }
        }
        private void delAtchButton_Click(object sender, EventArgs e)
        {
            if (attachementListBox.SelectedIndex != -1)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(attachementListBox);
                selectedItems = attachementListBox.SelectedItems;

                int attachementListBoxIndex = attachementListBox.SelectedIndex;
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    attachementListBox.Items.Remove(selectedItems[i]);
                }
                
                msg.Attachments.RemoveAt(attachementListBoxIndex); //usuwanie wybranego załącznika
                attachementProgressBar.Increment(-sizeAttachement[attachementListBoxIndex]); //dekrementacja progressbara
                sizeAttachement.RemoveAt(attachementListBoxIndex); // usuwa wage pliku z listy
                procentageProgressBar = attachementProgressBar.Value * 4; // uaktualnij wartosc progressbara
                procentageLabel.Text = Convert.ToString(procentageProgressBar) + "%";         
            }
        }
    }
}

