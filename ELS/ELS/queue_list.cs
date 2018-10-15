using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELS
{
    public partial class queue_list : UserControl
    {
        public queue_list()
        {
            InitializeComponent();
        }

        int current_quantity, final_quantity;
        string stud_no;
        public void getQuantity(string item)
        {
            string query = "SELECT quantity FROM item_list where item_no = " + item + ";";
            if (LogIn.OpenConnection())
            {

                try
                {
                    MySqlCommand command = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        current_quantity = Convert.ToInt32(AES.AES_Encryption.DecryptString(reader[0].ToString(), LogIn.strpass));
                    }
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


        public static string decode(string thisDecode)
        {
            return AES.AES_Encryption.DecryptString(thisDecode, LogIn.strpass);
        }

        public void Populate_ListView()
        {
            listView1.Items.Clear();
            ListViewItem iItem;
            string query = "select queue, room, date from borrow_list where returned = 'Q/H7q5zh6RijRaImEg3zjg==';";
            if (LogIn.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        iItem = new ListViewItem(dataReader[0].ToString());
                        iItem.SubItems.Add(decode(dataReader[1].ToString()));
                        iItem.SubItems.Add(decode(dataReader[2].ToString()));
                        listView1.Items.Add(iItem);
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
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        public void getBorrow(string queue)
        {
            string query = "select stud_no from borrow_list where queue = "+queue +";";
            if (LogIn.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        stud_no = AES.AES_Encryption.DecryptString(dataReader[0].ToString(), LogIn.strpass);
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

        public void Load_Items(int table)
        {
            listView2.Items.Clear();
            ListViewItem iItem;
            string query = "SELECT * FROM `"+table+"`";
            if (LogIn.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        iItem = new ListViewItem(dataReader.GetString("item_no"));
                        iItem.SubItems.Add(dataReader.GetString("item_name"));
                        iItem.SubItems.Add(dataReader.GetString("quantity"));
                        listView2.Items.Add(iItem);
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
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void queue_list_Load(object sender, EventArgs e)
        {
            Populate_ListView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                Load_Items(Convert.ToInt32(item.SubItems[0].Text));
                getBorrow(item.SubItems[0].Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Populate_ListView();
            listView2.Items.Clear();
        }



        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.MaskCompleted)
            {
                if(maskedTextBox1.Text==stud_no)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView2.SelectedItems)
            {
                LogIn.Insert("insert into item_defect values (" + item.SubItems[0].Text + ",'" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "');");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                foreach(ListViewItem item2 in listView2.Items)
                {
                    getQuantity(item2.SubItems[0].Text);
                    final_quantity = current_quantity + Convert.ToInt32(item2.SubItems[2].Text);
                    LogIn.Insert("update item_list set quantity = '" + AES.AES_Encryption.EncryptString(final_quantity.ToString(), LogIn.strpass) + "' where item_no = " + item2.SubItems[0].Text + ";");
                }
                LogIn.Insert("update borrow_list set returned = '" + AES.AES_Encryption.EncryptString("yes", LogIn.strpass)+"' where queue = "+item.SubItems[0].Text+";");
            }
            Populate_ListView();
            listView2.Items.Clear();
        }
    }
}
