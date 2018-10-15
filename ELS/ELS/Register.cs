using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ELS
{

    public partial class Register : Form
    {
        string en_username, en_password, en_idnum, en_accttype, strpass = "password";
        public void Initialize()
        {
            LogIn.mcs = "server=localhost;uid=root;pwd=;database=lending_system;";
            LogIn.conn = new MySqlConnection(LogIn.mcs);
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


        private void registerbtn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(usertxt.Text)) || (string.IsNullOrEmpty(passtxt.Text)) || (string.IsNullOrEmpty(conpasstxt.Text)) || (string.IsNullOrEmpty(idnummask.Text))
                || (string.IsNullOrEmpty(acctcmb.Text)))
            {
                MessageBox.Show("Kindly Complete the Information", "Incomplete");
            }
            else
            {
                if (MessageBox.Show("Confirm Registration?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if ((passtxt.Text.Length>=8)&&(conpasstxt.Text.Length>= 8))
                    {
                        if (passtxt.Text == conpasstxt.Text)
                        {
                            en_username = AES.AES_Encryption.EncryptString(usertxt.Text, strpass);
                            en_password = AES.AES_Encryption.EncryptString(passtxt.Text, strpass);
                            en_idnum = AES.AES_Encryption.EncryptString(idnummask.Text, strpass);
                            en_accttype = AES.AES_Encryption.EncryptString(acctcmb.Text, strpass);
                            string query = "INSERT INTO users (username, password, id_num, user_type) VALUES ('" + en_username + "', '" + en_password + "', '" + en_idnum +
                        "', '" + en_accttype + "')";

                            if (LogIn.OpenConnection())
                            {
                                try
                                {
                                    MySqlCommand cmd = new MySqlCommand(query, LogIn.conn);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("You're Registered");
                                    Form login = new LogIn();
                                    login.Show();
                                    this.Hide();
                                    usertxt.Text = null;
                                    passtxt.Text = null;
                                    idnummask.Text = null;
                                    acctcmb.Text = null;
                                }
                                catch (MySqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    LogIn.CloseConnection();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Confirmation didn't Match", "Password Unmatched");
                            conpasstxt.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Length must be at least 8 characters.", "Password Length Error");
                    }


                }
                else
                {
                }
            }
        }

      
        public static bool OpenConnection()
        {
            try
            {
               LogIn.conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                LogIn.conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Pbutton_MouseDown(object sender, MouseEventArgs e)
        {
            passtxt.PasswordChar = '\0';
        }

        private void Pbutton_MouseUp(object sender, MouseEventArgs e)
        {
            passtxt.PasswordChar = '●';
        }

        private void CPbutton_MouseDown(object sender, MouseEventArgs e)
        {
           conpasstxt.PasswordChar = '\0';
        }

        private void CPbutton_MouseUp(object sender, MouseEventArgs e)
        {
            conpasstxt.PasswordChar = '●';
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to stop registraion?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form Login = new LogIn();
                Login.Show();
                this.Hide();
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
