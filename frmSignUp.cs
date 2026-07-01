using BusinessLayer;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Al_Hilali_Bank
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
        }
        private bool CheckIsAllEmpty()
        {
            return (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbUserName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text) ||
                string.IsNullOrWhiteSpace(cmGender.Text));
        }
        private bool CheckIsRightNumber(string Number)
        {
            string FullNumber = Number;
            if (Number.StartsWith("7") && Number.All(char.IsDigit)&& Number.Length==9)
            {
                return true;
            }
            return false;
        }
        private bool CheckIsPassword(string Password)
        {
            
            if (Password.Length>6) 
            {
                return true;
            }
            return false;
        }
        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void Raisbtn(object sender, EventArgs e)
        {
            clsChangeButtonSize.RaisButton(sender);
        }
        private void Resetbtn(object sender, EventArgs e)
        {
            clsChangeButtonSize.ResetButton(sender);
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ChangeArrowBack(object sender, EventArgs e)
        {
            IconButton IB=sender as IconButton;
            IB.Size=new Size(IB.Width+1, IB.Height+1);
        }
        private void ResetArrowBack(object sender, EventArgs e)
        {
            IconButton IB=sender as IconButton;
            IB.Size=new Size(IB.Width+1, IB.Height+1);
        }
        private void ResetFormInfo()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbUserName.Text = "";
            tbPassword.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            iconUserPhoto.ImageLocation = null ;
            dtmbiker.Value = DateTime.Now;
            cmGender.SelectedIndex = 1;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSignIN_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (!CheckIsAllEmpty())
            {
                if(!CheckIsRightNumber(tbPhone.Text))
                {
                    errorProvider1.SetError(tbPhone, "Validate Number!");
                    return;
                }
                if(!CheckIsPassword(tbPassword.Text))
                {
                    errorProvider1.SetError(tbPassword, "Password must bt to bigger!");
                    return;
                }
                clsBusinessUsers users = new clsBusinessUsers();
                users.Email=tbEmail.Text;
                users.FirstName=tbFirstName.Text;
                users.LastName=tbLastName.Text;
                users.UserName=tbUserName.Text;
                users.Password=tbPassword.Text;
                users.Phone = tbPhone.Text;
                users.DateOfBirth = dtmbiker.Value;
                users.Gender = cmGender.Text;
                if (string.IsNullOrWhiteSpace(users.ImagePath))
                {
                    string ImagePath = Path.Combine(Application.StartupPath, "MyImage", "a282728431fcf05e2b1102f8da9370c1.png");
                    iconUserPhoto.ImageLocation = ImagePath;
                }
                else
                {
                    users.ImagePath = iconUserPhoto.ImageLocation;
                }
                if (users.Save(ref ErrorMessage))
                {
                    users.UpdateOrDeletePhoto(users.ImagePath);
                    MessageBox.Show("User Added Successfully!", "Add New User", MessageBoxButtons.OK);
                    ResetFormInfo();

                }
                else
                { 
                    if (ErrorMessage.Contains("Email"))
                    {
                        errorProvider1.SetError(tbEmail, ErrorMessage);
                    }
                    else if (ErrorMessage.Contains("UserName"))
                    {
                       errorProvider1.SetError(tbUserName, ErrorMessage);
                    }
                    else if (ErrorMessage.Contains("Age"))
                    {
                        errorProvider1.SetError(dtmbiker, ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("There Something Wronge!", "Add New User", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Miss Something", "Add New User", MessageBoxButtons.OK);

            }
        }
        private void ReserErrorProvider(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox tb)
            {
                ReserErrorProvider(tb);

            }
            if (sender is Guna2DateTimePicker tb2)
            {
                ReserErrorProvider(tb2);

            }

        }
        private void ReserErrorProvider(object tb)
        {
            if (tb is Guna2TextBox tb2)
                errorProvider1.SetError(tb2, "");
            else if (tb is Guna2DateTimePicker tb3)
                errorProvider1.SetError(tb3, "");
        }

       
        private void iconDeletePhoto_Click(object sender, EventArgs e)
        {
           
            string ImagePath = Path.Combine(Application.StartupPath, "MyImage", "a282728431fcf05e2b1102f8da9370c1.png");
            iconUserPhoto.ImageLocation = ImagePath;

        }

        private void iconAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Add Photo";
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Filter = "Files(*.png;*.jpg)|*.png;*.jpg|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                iconUserPhoto.ImageLocation = openFileDialog1.FileName;
                iconUserPhoto.SizeMode=PictureBoxSizeMode.Zoom;
            }

        }
    }
}
