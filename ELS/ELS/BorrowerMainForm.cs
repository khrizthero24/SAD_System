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
            selectPanel.Height = button1.Height;
            selectPanel.Top = button1.Top;
        }
        bool cpe = false;

        
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
            selectPanel.Height = button1.Height;
            selectPanel.Top = button1.Top;
           cpEControl1.t_room= "CPE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cpe = false;
            selectPanel.Height = button2.Height;
            selectPanel.Top = button2.Top;
            cpEControl1.t_room = "ECE";
        }
    }
}
