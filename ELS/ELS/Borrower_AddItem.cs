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
    public partial class Borrower_AddItem : Form
    {
        public CpEControl lender { get; set; }
        public Borrower_AddItem(CpEControl _form1)
        {
            lender = _form1;
            InitializeComponent();
            LogIn.Initialize();
        }
        int itemno;
        string pic_add;
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

        public void Numeric_Item(int Item_No)
        {
            string query = "select quantity,image from item_list where item_no = "+Item_No+";";
            if (LogIn.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(AES.AES_Encryption.DecryptString(dataReader[0].ToString(),LogIn.strpass));
                        pic_add = decode(dataReader[1].ToString());
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

        private void Borrower_AddItem_Load(object sender, EventArgs e)
        {
            Populate_ListView("select item_no,item_name,description,quantity from item_list");
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                itemno = Convert.ToInt32(item.SubItems[0].Text);
                Numeric_Item(itemno);
                Image dump = pictureBox1.BackgroundImage;
                if (dump != null)
                    dump.Dispose();
                pictureBox1.BackgroundImage = Image.FromFile(pic_add);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem iItem;
                iItem = new ListViewItem(numericUpDown1.Value.ToString());
                iItem.SubItems.Add(item.SubItems[1].Text);
                lender.listView1.Items.Add(iItem);
                lender.listView1.Refresh();
                lender.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lender.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                Hide();
            }
            
        }
    }
}
