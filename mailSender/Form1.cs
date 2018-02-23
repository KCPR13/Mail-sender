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
        string password;
        public mailSender()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*'; //password character
            textBox2.MaxLength = 16; //maximum 16 characters
        }

        private void Save_CheckedChanged(object sender, EventArgs e)
        {
            if(savePassword.Checked)
            { 
                password=textBox2.Text;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void portDomain_Load (object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.portDomain.Items;
            collection.Add("Gmail");

        }
    }
}
