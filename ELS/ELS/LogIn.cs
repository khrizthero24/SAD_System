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
    
    public partial class LogIn : Form
    {
        public static string username,user_type, en_username, password, en_password, strpass = "password";
        int user_no;
        bool compAd,correctpass;
        public static MySqlConnection conn;
        public static string mcs;

        public LogIn()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            mcs = "server=localhost;uid=root;pwd=;database=lending_system;sslmode=none;";
            conn = new MySqlConnection(mcs);
        }

        public static bool OpenConnection()
        {
            try
            {
                conn.Open();
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
                conn.Dispose();
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void compareAdmin(string myqueryAd)
        {
            compAd = false;
            if(OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(myqueryAd, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        username = AES.AES_Encryption.DecryptString(reader.GetString("username"), strpass);
                        if (usertxt.Text==username)
                        {
                            compAd = true;
                            
                        }
                        user_no++;
                        
                    }
                        
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public void comparePass()
        {
            string pass, user;
            string checkQueryPass = "SELECT password,user_type FROM users where user_no = " + user_no + ";";
            if (OpenConnection())
            {
                
                try
                {
                    
                    MySqlCommand command = new MySqlCommand(checkQueryPass, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        pass = AES.AES_Encryption.DecryptString(reader[0].ToString(), strpass);
                        user = AES.AES_Encryption.DecryptString(reader[1].ToString(), strpass);
                        MessageBox.Show(pass);
                        if (pass==password)
                        {
                            if ( user == "Toolkeeper")
                            {
                                MessageBox.Show("CHARAN");
                            }
                            else
                            {
                                /*Form Borrow = new BorrowerMainForm();
                                Borrow.Show();
                                this.Hide();*/
                            }
                        }
                        if (MessageBox.Show("Incorrect Password. Forgot Password", "User Found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            
                        }
                    }

                         
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
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
        private void button2_Click(object sender, EventArgs e)
        {
            if ((usertxt.Text == "") && (passtxt.Text == ""))
            {
                Form register = new Register();
                register.Show();
                this.Hide();
            }
            else
            {
                if (MessageBox.Show("Do you really want register?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form register = new Register();
                    register.Show();
                    this.Hide();
                }
            }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
                passtxt.PasswordChar = '\0';
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            passtxt.PasswordChar = '●';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkQueryuser = "SELECT * FROM users;";
           
            password = passtxt.Text;
            if ((usertxt.Text == "") || (passtxt.Text == ""))
            {
                MessageBox.Show("Please complete up the following", "Log - In");
            }
            else
            {
                compareAdmin(checkQueryuser);
                if (compAd == true)
                {
                    MessageBox.Show("Account Found", "User Found");
                    comparePass();
                }
            }
            if((usertxt.Text != "")&&(passtxt.Text != ""))
            {
                usertxt.Text = "";
                passtxt.Text = "";
            }
        }
    }
}
