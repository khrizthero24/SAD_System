using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELS
{
    
    public partial class Register : Form
    {
        string en_username, en_password, en_idnum, en_accttype, strpass = "password";

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(usertxt.Text)) || (string.IsNullOrEmpty(passtxt.Text)) || (string.IsNullOrEmpty(conpasstxt.Text)) || (string.IsNullOrEmpty(idnumtxt.Text))
                || (string.IsNullOrEmpty(acctcmb.Text)))
            {
                MessageBox.Show("MAY KULANG KA!");
            }
            else
            {
                if (passtxt.Text == conpasstxt.Text)
                {
                    en_username = AES.AES_Encryption.EncryptString(usertxt.Text, strpass);
                    en_password = AES.AES_Encryption.EncryptString(passtxt.Text, strpass);
                    en_idnum = AES.AES_Encryption.EncryptString(idnumtxt.Text, strpass);
                    en_accttype = AES.AES_Encryption.EncryptString(acctcmb.Text, strpass);
                    MessageBox.Show(en_username);


                }
                else
                {
                    MessageBox.Show("DI NAG MATCH PASSWORD AND CONFIRM PASS");
                }
            }
        }

        public Register()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
