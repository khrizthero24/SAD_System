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
            InitializeComponent();
            LogIn.Initialize();
        }

        public string t_room = "none", subj_sect, exp_title, room_time, date, faculty, name, stud_no;
        public int queue_no;
        int max_item;

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
            name = textBox5.Text;
            stud_no = textBox6.Text;
            subj_sect = textBox1.Text;
            room_time = textBox3.Text;
            date = dateTimePicker1.Value.ToShortDateString();
            faculty = textBox4.Text;
            exp_title = textBox2.Text;
            max_item = listView1.Items.Count;
            string query = null;
            query = AES.AES_Encryption.EncryptString(t_room, LogIn.strpass);
            query = query + "','" + AES.AES_Encryption.EncryptString(name, LogIn.strpass);
            query = query + "','" + AES.AES_Encryption.EncryptString(stud_no, LogIn.strpass);
            query = query + "','" + AES.AES_Encryption.EncryptString(subj_sect, LogIn.strpass);
            query = query + "','" + AES.AES_Encryption.EncryptString(room_time, LogIn.strpass);
            query = query + "','" + AES.AES_Encryption.EncryptString(date, LogIn.strpass);
            query = query + "','" + AES.AES_Encryption.EncryptString(faculty, LogIn.strpass);
            query = query + "','" + AES.AES_Encryption.EncryptString(exp_title, LogIn.strpass);
            MessageBox.Show(query);
            return query;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Is all parameters correct?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk))
            {
                if (t_room != "none")
                {
                    LogIn.Insert("CREATE TABLE `" + queue_no + "` ( `item_no` INT(20) NOT NULL , `item_name` VARCHAR(255) NOT NULL , `quantity` VARCHAR(255) NOT NULL , PRIMARY KEY (`item_no`));");
                    LogIn.Insert("insert into borrow_list (tool_room, name, stud_no, subj_sect, room_time,date,faculty,exp_title) values ('" + Borrow_List() + "');");

                    foreach (ListViewItem item in listView1.Items)
                    {
                        LogIn.Insert("INSERT INTO `" + queue_no + "` (`item_no`, `item_name`, `quantity`) VALUES ('" + item.SubItems[0].Text.ToString() + "','" + item.SubItems[1].Text.ToString() + "','" + item.SubItems[2].Text.ToString() + "');");
                    }
                }
                else
                {
                    MessageBox.Show("pili ka muna course");
                }
            }
            else
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
