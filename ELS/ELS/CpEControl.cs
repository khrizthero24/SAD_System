using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ELS
{
    public partial class CpEControl : UserControl
    {

        public CpEControl()
        {
            //borrow = _form1;
            InitializeComponent();
            LogIn.Initialize();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count==1)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
                button4.Enabled = false;
                button5.Enabled = false;
            }
            else
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form borrow_additem = new Borrower_AddItem(this);
            borrow_additem.Show();
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void CpEControl_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
        }


       

        private string Borrow_List()
        {
            string query = null;

            query = AES.AES_Encryption.EncryptString(BorrowerMainForm.t_room, LogIn.strpass);
            query = query + AES.AES_Encryption.EncryptString(BorrowerMainForm.name, LogIn.strpass);
            query = query + AES.AES_Encryption.EncryptString(BorrowerMainForm.stud_no, LogIn.strpass);
            query = query + AES.AES_Encryption.EncryptString(BorrowerMainForm.subj_sect, LogIn.strpass);
            query = query + AES.AES_Encryption.EncryptString(BorrowerMainForm.room_time, LogIn.strpass);
            query = query + AES.AES_Encryption.EncryptString(BorrowerMainForm.date, LogIn.strpass);


            query = query + AES.AES_Encryption.EncryptString(BorrowerMainForm.faculty, LogIn.strpass);
            query = query + AES.AES_Encryption.EncryptString(BorrowerMainForm.exp_title, LogIn.strpass);

            return query;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Is all parameters correct?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk))
            {
                BorrowerMainForm.name = textBox5.Text;
                BorrowerMainForm.stud_no = textBox6.Text;
                BorrowerMainForm.subj_sect = textBox1.Text;
                BorrowerMainForm.room_time = textBox3.Text;
                BorrowerMainForm.date = dateTimePicker1.Value.ToShortDateString();


                BorrowerMainForm.faculty = textBox4.Text;
                BorrowerMainForm.exp_title = textBox2.Text;
            }
            else
            {
                
            }
        }
    }
}
