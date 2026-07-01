using Al_Hilali_Bank.Properties;
using BusinessLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Hilali_Bank
{
    public partial class frmShowUserPhoto : Form
    {
        public frmShowUserPhoto()
        {
            InitializeComponent();
        }

        private void iconAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Add Photo";
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Filter = "Files(*.png;*.jpg)|*.png;*.jpg|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                userpicture.ImageLocation = openFileDialog1.FileName;
                GlobalUser.CurrentUser.UpdateOrDeletePhoto(userpicture.ImageLocation);
            }
        }

        private void iconDeletePhoto_Click(object sender, EventArgs e)
        {
            string ImagePath = Path.Combine(Application.StartupPath, "MyImage", "a282728431fcf05e2b1102f8da9370c1.png");
            userpicture.ImageLocation = ImagePath;
            GlobalUser.CurrentUser.UpdateOrDeletePhoto(ImagePath);

        }

        private void iconbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUserPhoto_Load(object sender, EventArgs e)
        {
            userpicture.ImageLocation = GlobalUser.CurrentUser.ImagePath;

        }
    }
}
