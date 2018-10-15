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
        int[] quantity_item = null;
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
            string query = "select quantity,image from item_list where item_no = " + Item_No + ";";
            if (LogIn.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        numericUpDown1.Maximum = Convert.ToInt32(AES.AES_Encryption.DecryptString(dataReader[0].ToString(), LogIn.strpass));
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
            int arraysize = 2;
            quantity_item = new int[arraysize];
            quantity_item[0] = 1;
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
                string search = item.SubItems[1].Text;
                ListViewItem itm = lender.listView1.FindItemWithText(search);
                if (itm != null)
                {
                    int i = itm.Index;
                    lender.listView1.Items[i].SubItems[2].Text = Convert.ToString(Convert.ToInt32(lender.listView1.Items[i].SubItems[2].Text) + Convert.ToInt32(numericUpDown1.Value.ToString()));
                }
                else
                {
                    ListViewItem iItem;
                    iItem = new ListViewItem(item.SubItems[0].Text);
                    iItem.SubItems.Add(item.SubItems[1].Text);
                    iItem.SubItems.Add(numericUpDown1.Value.ToString());
                    lender.listView1.Items.Add(iItem);
                    lender.listView1.Refresh();
                    lender.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lender.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            /*if (textBox1.Text != "")
            {
                foreach (ListViewItem item in listView1.Items)
                {

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            item.BackColor = SystemColors.Highlight;
                            item.ForeColor = SystemColors.HighlightText;
                        }
                        else
                        {
                            item.BackColor = SystemColors.Window;
                            item.ForeColor = SystemColors.WindowText;
                        }

                    }
                }

            }
            else
                Populate_ListView("select item_no,item_name,description,quantity from item_list");*/
            foreach (ListViewItem item in listView1.Items)
            {
                //Selected = true, won't show until the listview has focus, but setting it to true puts it in the 
                //SelectedItems collection.
                if (item.SubItems[0].Text.ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = SystemColors.Highlight;
                    item.ForeColor = SystemColors.HighlightText;
                }
                else if (item.SubItems[1].Text.ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = SystemColors.Highlight;
                    item.ForeColor = SystemColors.HighlightText;
                }
                else if (item.SubItems[2].Text.ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = SystemColors.Highlight;
                    item.ForeColor = SystemColors.HighlightText;
                }
                else if (item.SubItems[3].Text.ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = SystemColors.Highlight;
                    item.ForeColor = SystemColors.HighlightText;
                }
                else
                {
                    item.Selected = false;
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
            }
            //When the selection is narrowed to one the user can stop typing

            if(textBox1.Text=="")
                Populate_ListView("select item_no,item_name,description,quantity from item_list");
        }
    }
}

