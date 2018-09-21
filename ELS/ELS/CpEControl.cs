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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
