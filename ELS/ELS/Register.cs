using System;
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
    
    public partial class Register : Form
    {
        string en_username, en_password, en_idnum, en_accttype, strpass = "password";

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(usertxt.Text)) || (string.IsNullOrEmpty(passtxt.Text)) || (string.IsNullOrEmpty(conpasstxt.Text)) || (string.IsNullOrEmpty(idnumtxt.Text))
                || (string.IsNullOrEmpty(acctcmb.Text)))
            {
                MessageBox.Show("MAY KULANG KA!");
            }
            else
            {
                if (passtxt.Text == conpasstxt.Text)
                {
                    en_username = AES.AES_Encryption.EncryptString(usertxt.Text, strpass);
                    en_password = AES.AES_Encryption.EncryptString(passtxt.Text, strpass);
                    en_idnum = AES.AES_Encryption.EncryptString(idnumtxt.Text, strpass);
                    en_accttype = AES.AES_Encryption.EncryptString(acctcmb.Text, strpass);
                    MessageBox.Show(en_username);


                }
                else
                {
                    MessageBox.Show("DI NAG MATCH PASSWORD AND CONFIRM PASS");
                }
            }
        }

        public Register()
        {
            InitializeComponent();
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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*public void Insert()
        {
            nameF = NameBox.Text;
            nameM = NameBox1.Text;
            nameL = NameBox2.Text;
            reMARKs = remarkss.Text;
            // If-Else statement of Gender Button to be thrown in the database
            if (Mbtn.Checked == true)
            {
                G = "M";
            }
            else if (FBtn.Checked == true)
            {
                G = "F";
            }
            if (PatientPicture.Image == null)
                pickedImage = @"C:\\Users\\Clark Nejal\\Pictures\\DentalPatientImage\\no-image.jpg";

            else
            {
                pickedImage = location + "\\\\" + openFileDialog1.SafeFileName;
            }

            if (remarkss.Text == "")
                reMARKs = "No Findings";

            string query = "INSERT INTO patients (name, address, emailad, Birthdata, Gender, celnum, telnum, PatientImage, Remarks) VALUES ('" + nameL + ", " + nameF + " " + nameM +
                "', '" + AddBox.Text + "', '" + emailBox.Text + "', '" + BdayBox.Text + "', '" + G + "', '" + cel + "', '" + tel + "', '" + pickedImage + "', '" + reMARKs + "')";

            if (this.OpenCon())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("New Patient has been added. Do you want again to insert a patient?", "Registration Complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Clear();

                    else
                    {
                        this.Hide();
                        Form AdminInterface = new AdminInterface();
                        AdminInterface.Show();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.CloseCon();
                    Clear();
                }
            }
        }*/
    }
}
