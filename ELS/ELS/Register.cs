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
        string username, en_username, password, con_password, en_password, idnum, en_idnum, accttype, en_accttype;

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(usertxt.Text)) || (string.IsNullOrEmpty(passtxt.Text)) || (string.IsNullOrEmpty(conpasstxt.Text)) || (string.IsNullOrEmpty(idnumtxt.Text))
                || (string.IsNullOrEmpty(acctcmb.Text)))
            {          
                usertxt.Text = "MAY KULANG KA!";
            }
            else
            {
                if (passtxt.Text == conpasstxt.Text)
                {
                    //REGISTER
                }
                else
                {
                    usertxt.Text = "DI NAG MATCH PASSWORD AND CONFIRM PASS";
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
