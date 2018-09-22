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
        public AddItem additem;
        public LenderMainForm()
        {
            InitializeComponent();
            LogIn.Initialize();
        }
        int itemno;

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
        private void LenderMainForm_Load(object sender, EventArgs e)
        {
            Populate_ListView("select item_no,item_name,description,quantity from item_list");
        }


        public void LII(int ID) // LII = Load Item Info
        {
            string query = "Select * from item_list where item_no = " + ID + "";
            if (LogIn.OpenConnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, LogIn.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        edit_Item1.item_number= Convert.ToInt32(reader.GetString("item_no"));
                        edit_Item1.item_name.Text= AES.AES_Encryption.DecryptString(reader.GetString("item_name"), LogIn.strpass);
                        edit_Item1.item_description.Text = AES.AES_Encryption.DecryptString(reader.GetString("description"), LogIn.strpass);
                        edit_Item1.item_quantity.Value=Convert.ToInt32(AES.AES_Encryption.DecryptString(reader.GetString("quantity"), LogIn.strpass));
                        Image dump =edit_Item1.item_pic.BackgroundImage;
                        if (dump != null)
                            dump.Dispose();
                        edit_Item1.item_pic.BackgroundImage = Image.FromFile(AES.AES_Encryption.DecryptString(reader.GetString("image"),LogIn.strpass));
                        edit_Item1.item_pic.BackgroundImageLayout = ImageLayout.Stretch;

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
            addItem1.item_description.Text = "";
            addItem1.item_name.Text = "";
            addItem1.item_pic1.BackgroundImage = ELS.Properties.Resources._default;
            addItem1.item_quantity.Value = 1;
            addItem1.isdefault = true;
            edit_Item1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addItem1.Visible = false;
            
            edit_Item1.Visible = true;
            edit_Item1.button1.Enabled = true;
            edit_Item1.button2.Enabled = true;
            edit_Item1.item_description.Enabled = true;
            edit_Item1.item_name.Enabled = true;
            edit_Item1.item_quantity.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
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
        private void LenderMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                itemno = Convert.ToInt32(item.SubItems[0].Text);
                LII(itemno);
            }
            edit_Item1.Visible = true;
            edit_Item1.button1.Enabled = false;
            edit_Item1.button2.Enabled = false;
            edit_Item1.item_description.Enabled = false;
            edit_Item1.item_name.Enabled = false;
            edit_Item1.item_quantity.Enabled = false;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Populate_ListView("select item_no,item_name,description,quantity from item_list");
        }
    }
}