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
        string username, en_username, password, en_password;
        bool compAd;
        public MySqlConnection conn;
        string mcs;

        public LogIn()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            mcs = "server=localhost;uid=root;pwd=;database=lending_system;";
            conn = new MySqlConnection(mcs);
        }

        public bool OpenConnection()
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

        public bool CloseConnection()
        {
            try
            {
                conn.Close();
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
            if(this.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(myqueryAd, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        compAd = true;
                        password = reader.GetString("password");
                    }
                    else
                        MessageBox.Show("Account Not Found", "User Not Found");
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public void comparePass(string myqueryPass)
        {
           if(this.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(myqueryPass, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.GetString("password")==password)
                        {
                            if (reader.GetBoolean("user_type") == false)
                                MessageBox.Show("CHARAN");
                            else
                                MessageBox.Show("CHURON");
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Incorrect Password. Forgot Password", "User Found",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Form ForgotPass = new ForgotPass();
                            ForgotPass.Show();
                            this.Hide();
                        }
                    }     
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.CloseConnection();
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
            Form register = new Register();
            register.Show();
            this.Hide();
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
            string checkQueryuser = "SELECT * FROM users WHERE username = '";
            string checkQueryPass = "SELECT * FROM users WHERE password = '";
            en_username = usertxt.Text.ToString();
            en_password = passtxt.Text.ToString();

            if ((en_username == "") || (en_password == ""))
                MessageBox.Show("Please complete up the following", "Log - In");
            else
            {
                checkQueryuser += en_username + "'";
                checkQueryPass += en_password + "'";
                compareAdmin(checkQueryuser);
                if (compAd == true)
                    comparePass(checkQueryPass);
            }
            if((usertxt.Text != "")&&(passtxt.Text != ""))
            {
                usertxt.Text = "";
                passtxt.Text = "";
            }
        }
    }
}
