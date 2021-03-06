﻿using System;
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
        public static int user_no;
        bool compAd,correctpass;
        public static MySqlConnection conn;
        public static string mcs;

        public LogIn()
        {
            InitializeComponent();
            Initialize();
        }

        public static void Initialize()
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
        public static void Insert(string q)
        {
            string query = q;
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                        MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }
        public void compareAdmin(string myqueryAd)
        {
            compAd = false;
            user_no = 1;
            if(OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(myqueryAd, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        username = AES.AES_Encryption.DecryptString(reader.GetString("username"), strpass);
                        if (usertxt.Text == username)
                        {
                            compAd = true;
                        }
                        else
                        {
                            if(!compAd)
                            {
                                user_no++;
                            }
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

        public void comparePass()
        {
            string pass, user;
            string checkQueryPass = "SELECT password,user_type FROM users where user_no = " + user_no + ";";
            correctpass = false;
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
                        if (pass==password)
                        {
                            correctpass = true;
                            if ( user == "Toolkeeper")
                            {
                                user_type = "1";
                            }
                            else
                            {
                                user_type = "0";
                            }
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
                Hide();
            }
            else
            {
                if (MessageBox.Show("Do you really want to register?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form register = new Register();
                    register.Show();
                    Hide();
                }
            }
                
            }
                
        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.ExitThread();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
                usertxt.Text = "";
                passtxt.Text = "";
            }
            else
            {
                compareAdmin(checkQueryuser);
                if (compAd)
                {
                    comparePass();                    
                    if (correctpass)
                    {
                        if(user_type == "1")
                        {
                            Form lender = new LenderMainForm();
                            lender.Show();
                            Hide();
                        }
                        else
                        {
                            Form borrow = new BorrowerMainForm();
                            borrow.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Incorrect Password. Forgot Password?", "User Found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Form forgot = new ForgotPass();
                            forgot.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User not Found", "Log - In");
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
