using System;
using System.IO;
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
    public partial class AddItem : UserControl
    {
        public LenderMainForm lender{ get; set;}
        public AddItem(LenderMainForm _form1)
        {
        lender = _form1;
        InitializeComponent();
            LogIn.Initialize();
        }

        //Image variables
        public string pickedImage = "";
        public string location = @"C:\ELS\";
        public string fileName = "";
        public bool isdefault=true;


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Insert an Image";
            openFileDialog1.InitialDirectory = location;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|TIFF Images|*.tif|PNG Images|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                fileName = openFileDialog1.SafeFileName;
                pickedImage = openFileDialog1.FileName;
                item_pic1.BackgroundImage = Image.FromFile(pickedImage);
                item_pic1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        string query = "";
        private string item_req()
        {
            
            if (isdefault)
            {         
                query = AES.AES_Encryption.EncryptString(item_name.Text, LogIn.strpass);
                query = query + "','" + AES.AES_Encryption.EncryptString(item_description.Text, LogIn.strpass);
                query = query + "','" + AES.AES_Encryption.EncryptString(item_quantity.Value.ToString(), LogIn.strpass);
            }
            else
            {
                query = AES.AES_Encryption.EncryptString(item_name.Text, LogIn.strpass);
                query = query + "','" + AES.AES_Encryption.EncryptString(item_description.Text, LogIn.strpass);
                query = query + "','" + AES.AES_Encryption.EncryptString(location + fileName, LogIn.strpass);
                query = query + "','" + AES.AES_Encryption.EncryptString(item_quantity.Value.ToString(), LogIn.strpass);
            }
            
            return query;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(isdefault)
            {
                LogIn.Insert("insert into item_list (item_name,description,quantity) values ('" + item_req() + "');");
                item_name.Text = null;
                item_description.Text = null;
                item_pic1.BackgroundImage = ELS.Properties.Resources._default;
                item_quantity.Value = 1;
                lender.button4_Click(this, e);
            }
            else
            {
                LogIn.Insert("insert into item_list (item_name,description,image,quantity) values ('" + item_req() + "');");
                File.Copy(pickedImage, @"C:\ELS\" + fileName);
                item_name.Text = null;
                item_description.Text = null;
                item_pic1.BackgroundImage = ELS.Properties.Resources._default;
                item_quantity.Value = 1;
            }
        }

        private void item_pic1_BackgroundImageChanged(object sender, EventArgs e)
        {
            isdefault = false;
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void item_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
