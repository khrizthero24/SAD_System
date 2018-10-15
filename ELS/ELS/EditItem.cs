using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ELS
{
    public partial class Edit_Item : UserControl
    {
        public Edit_Item()
        {
            InitializeComponent();
            LogIn.Initialize();
        }
        //Image variables
        string pickedImage = "";
        string location = @"C:\ELS\";
        string fileName = "";
        bool isdefault = true;
        public int item_number;

        private string item_req()
        {
            string query = "item_name ='";
            query = query + AES.AES_Encryption.EncryptString(item_name.Text, LogIn.strpass);
            query = query + "', description ='" + AES.AES_Encryption.EncryptString(item_description.Text, LogIn.strpass);
            if (fileName=="")
            {
                query = query + "', quantity ='" + AES.AES_Encryption.EncryptString(item_quantity.Value.ToString(), LogIn.strpass);
            }
            else
            {
                query = query + "', image ='" + AES.AES_Encryption.EncryptString(location + fileName, LogIn.strpass);
                query = query + "', quantity ='" + AES.AES_Encryption.EncryptString(item_quantity.Value.ToString(), LogIn.strpass);
            }

            return query;
        }

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
                item_pic.BackgroundImage = Image.FromFile(pickedImage);
                item_pic.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(fileName=="")
            {
                LogIn.Insert("update item_list set " + item_req() + "' where item_no = " + item_number + ";");
            }
            else
            {
                File.Copy(pickedImage, @"C:\ELS\" + fileName);
                LogIn.Insert("update item_list set " + item_req() + "' where item_no = " + item_number + ";");
            }
        }

        private void item_pic_BackgroundImageChanged(object sender, EventArgs e)
        {
            isdefault = false;
        }
    }
}
