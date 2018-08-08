﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELS
{
    public partial class BorrowerMainForm : Form
    {
        public BorrowerMainForm()
        {
            InitializeComponent();
            selectPanel.Height = button1.Height;
            selectPanel.Top = button1.Top;
        }

        private void BorrowerMainForm_Load(object sender, EventArgs e)
        {

        }
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
        private void button1_Click(object sender, EventArgs e)
        {
            selectPanel.Height = button1.Height;
            selectPanel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectPanel.Height = button2.Height;
            selectPanel.Top = button2.Top;
        }
    }
}
