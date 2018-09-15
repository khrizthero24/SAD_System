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
        string en_t_room, en_subj_sect, en_exp_title, en_room_time, en_date, en_faculty, en_name, en_stud_no, en_quan_item;

        private void CpEControl_Load(object sender, EventArgs e)
        {
            LogIn.mcs = "server=localhost;uid=root;pwd=;database=lending_system;";
            LogIn.conn = new MySqlConnection(LogIn.mcs);
        }

        public CpEControl()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
