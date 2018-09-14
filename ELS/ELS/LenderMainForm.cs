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
    public partial class LenderMainForm : Form
    {
        public LenderMainForm()
        {
            InitializeComponent();
            LogIn.Initialize();
        }

        private void LenderMainForm_Load(object sender, EventArgs e)
        {
            Populate_ListView("select item_no,item_name,description,quantity from item_list");
        }
        string itemquantity, itemname;
        public static string decode(string thisDecode)
        {
            return AES.AES_Encryption.DecryptString(thisDecode, LogIn.strpass);
        }
        public void Populate_ListView(string myquery)
        {
            listView1.Items.Clear();
            ListViewItem iItem;
            string query = myquery;
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
                        iItem.SubItems.Add(decode(dataReader[3].ToString()));
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
        private void button1_Click(object sender, EventArgs e)
        {
            addItem1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addItem1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Populate_ListView("select item_no,item_name,quantity from item_list");
        }
    }
}
