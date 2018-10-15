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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Form login = new LogIn();
                login.Show();
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                LogIn.Insert("update users set password = '" + AES.AES_Encryption.EncryptString(textBox2.Text, LogIn.strpass) + "' where user_no = " + LogIn.user_no + ";");
                MessageBox.Show("Change Password Success","Information",MessageBoxButtons.OK);
                LogIn login = new LogIn();
                login.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK);
                textBox2.Text = null;
                textBox3.Text = null;
            }
        }
    }
}
