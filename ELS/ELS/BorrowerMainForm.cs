using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELS
{
    public partial class BorrowerMainForm : Form
    {
        
        public BorrowerMainForm()
        {
            InitializeComponent();
        }
        bool cpe = false;
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

        public void Get_Queue_No()
        {
            string query = "Select count(*) from borrow_list;";
            if (LogIn.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                      cpEControl1.queue_no = Convert.ToInt32(dataReader[0].ToString())+1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LogIn.CloseConnection();
                }
            }
        }



        private void BorrowerMainForm_Load(object sender, EventArgs e)
        {
            Get_Queue_No();
            cpEControl1.Enabled = true;
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
        private void button1_Click(object sender, EventArgs e)
        {
            cpe = true;
            cpEControl1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cpe = false;
            cpEControl1.t_room = "ECE";
            cpEControl1.Enabled = true;
        }

        private void cpEControl1_Click(object sender, EventArgs e)
        {
        }
    }
}
