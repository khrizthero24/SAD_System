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
    public partial class LendReport : Form
    {
        public LendReport()
        {
            InitializeComponent();
        }

        int queue_no;
        queue_crystalReports queue_report = new queue_crystalReports();
        defect_crystalReports defect_report = new defect_crystalReports();
        allItem_crystalReports all_item_report = new allItem_crystalReports();
        public void Populate_ListView(string myquery)
        {
            queue_listView.Items.Clear();
            item_listView.Items.Clear();
            defect_listView.Items.Clear();
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
                        if (item_all_items.Checked)
                        {
                            iItem = new ListViewItem(dataReader[0].ToString());
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[1].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[2].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[3].ToString(), LogIn.strpass));
                            item_listView.Items.Add(iItem);
                        }
                        else if(queue_returned.Checked)
                        {
                            iItem = new ListViewItem(dataReader[0].ToString(), LogIn.strpass);
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[1].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[2].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[3].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[4].ToString(), LogIn.strpass));
                            queue_listView.Items.Add(iItem);
                        }
                        else if (queue_not_returned.Checked)
                        {
                            iItem = new ListViewItem(dataReader[0].ToString(), LogIn.strpass);
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[1].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[2].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[3].ToString(), LogIn.strpass));
                            iItem.SubItems.Add(AES.AES_Encryption.DecryptString(dataReader[4].ToString(), LogIn.strpass));
                            queue_listView.Items.Add(iItem);
                        }
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

        private void LendReport_Load(object sender, EventArgs e)
        {
            item_list_groupBox.Visible = false;
            queue_list_groupBox.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                item_list_groupBox.Visible = true;
                item_list_groupBox.BringToFront();

                queue_list_groupBox.Visible = false;
                queue_list_groupBox.SendToBack();
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                queue_list_groupBox.Visible = true;
                queue_list_groupBox.BringToFront();

                item_list_groupBox.Visible = false;
                item_list_groupBox.SendToBack();
            }
            item_all_defects.Checked = false;
            item_all_items.Checked = false;
            queue_not_returned.Checked = false;
            queue_returned.Checked = false;
        }

        private void queue_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void item_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(item_all_items.Checked)
            {
                LogIn.Insert("delete from item_report");
                Populate_ListView("Select item_no, item_name, description, quantity from item_list;");
                foreach (ListViewItem item in item_listView.Items)
                {
                    LogIn.Insert("insert into item_report values (" + item.SubItems[0].Text + ", '" + item.SubItems[1].Text + "', '" + item.SubItems[2].Text + "', '" + item.SubItems[3].Text + "');");
                }
                crystalReportViewer1.ReportSource = all_item_report;
                crystalReportViewer1.RefreshReport();
            }
            else if (item_all_defects.Checked)
            {
                crystalReportViewer1.ReportSource = defect_report;
                crystalReportViewer1.RefreshReport();
            }
            else if (queue_returned.Checked)
            {
                
                Populate_ListView("select queue, name, faculty, room, time from borrow_list where returned != 'Q/H7q5zh6RijRaImEg3zjg==';");
                LogIn.Insert("delete from queue_report");
                foreach(ListViewItem item in queue_listView.Items)
                {
                    LogIn.Insert("insert into queue_report values (" + item.SubItems[0].Text + ", '" + item.SubItems[1].Text + "', '" + item.SubItems[2].Text + "', '" + item.SubItems[3].Text + "', '" + item.SubItems[4].Text + "');");
                }
                crystalReportViewer1.ReportSource = defect_report;
                crystalReportViewer1.RefreshReport();
            }
            else if (queue_not_returned.Checked)
            {
                MessageBox.Show("pasok");
                Populate_ListView("select queue, name, faculty, room, time from borrow_list where returned = 'Q/H7q5zh6RijRaImEg3zjg==';");
                LogIn.Insert("delete from queue_report");
                foreach (ListViewItem item in queue_listView.Items)
                {
                    LogIn.Insert("insert into `queue_report` values (" + item.SubItems[0].Text + ",'" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[4].Text + "');");
                }
                crystalReportViewer1.ReportSource = queue_report;
                crystalReportViewer1.RefreshReport();
            }
            
        }
    }
}
