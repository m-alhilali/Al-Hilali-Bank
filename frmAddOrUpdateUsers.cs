using BusinessLayer;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Hilali_Bank
{
    public partial class frmAddOrUpdateUsers : Form
    {
        private int _Mode;
        private int _User;
        private clsBusinessUsers User;
        private int _Permissions;
        enum enMode { Add = 0, Update = 1 }
        
        private enMode Mode = enMode.Add;
        public frmAddOrUpdateUsers(int Mode, int ClientID)
        {
            InitializeComponent();
            _Mode = Mode;
            _User = ClientID;
            if (_Mode == 0)
            {
                this.Mode = enMode.Add;
            }
            else
            {
                this.Mode = enMode.Update;
                User = clsBusinessUsers.Find(_User);

            }
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private bool CheckIsAllEmpty()
        {
            return (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbUserName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text) ||
                string.IsNullOrWhiteSpace(cmGender.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text));
        }
        private bool CheckIsRightNumber(string Number)
        {
            string FullNumber = Number;
            if (Number.StartsWith("7") && Number.All(char.IsDigit) && Number.Length == 9)
            {
                return true;
            }
            return false;
        }
        private bool CheckIsPassword(string Password)
        {

            if (Password.Length > 6)
            {
                return true;
            }
            return false;
        }
        private void FillFormWithDataToUpdate()
        {
            if (this.Mode == enMode.Update)
            {
                lblTitle.Text = "UPDATE USER = " + User.ID.ToString();
                tbUserName.Text = User.UserName;
                tbEmail.Text = User.Email;
                tbFirstName.Text = User.FirstName;
                tbLastName.Text = User.LastName;
                tbPassword.Text = User.Password;
                tbPhone.Text = User.Phone;
                cbStatus.SelectedIndex = User.UserStatus;
                dtmbiker.Value = User.DateOfBirth;
                cmGender.Text = (User.Gender == "M") ? "Male" : "Female";

            }
        }
        private void frmAddOrUpdateUsers_Load(object sender, EventArgs e)
        {
            if (this.Mode == enMode.Update)
            {
                FillFormWithDataToUpdate();
            }
            else
            {
                User = new clsBusinessUsers();

            }
        }
        private void btnSignIN_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (!CheckIsAllEmpty())
            {
                if (!CheckIsRightNumber(tbPhone.Text))
                {
                    errorProvider1.SetError(tbPhone, "Validate Number!");
                    return;
                }
                if (!CheckIsPassword(tbPassword.Text))
                {
                    errorProvider1.SetError(tbPassword, "Password must bt to bigger!");
                    return;
                }
                User.Email = tbEmail.Text;
                User.FirstName = tbFirstName.Text;
                User.LastName = tbLastName.Text;
                User.UserName = tbUserName.Text;
                User.Password = tbPassword.Text;
                User.Phone = tbPhone.Text;
                User.DateOfBirth = dtmbiker.Value;
                User.Gender = cmGender.Text;
                User.UserStatus = Convert.ToByte(cbStatus.Text);
                if (User.Save(ref ErrorMessage))
                {
                    MessageBox.Show("User Done Successfully!", "Update / Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    FillFormWithDataToUpdate();
                }
                else
                {
                    if (ErrorMessage.Contains("Email"))
                    {
                        errorProvider1.SetError(tbEmail, ErrorMessage);
                    }
                    else if (ErrorMessage.Contains("AccountNumber"))
                    {
                        errorProvider1.SetError(tbUserName, ErrorMessage);
                    }
                    else if (ErrorMessage.Contains("Age"))
                    {
                        errorProvider1.SetError(dtmbiker, ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("There Something Wronge!", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Miss Something", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnaddPermissions_Click(object sender, EventArgs e)
        {
            Form form = new frmAddPermissions(User,1);
            form.ShowDialog();
        }

        private void iconbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIN_Click_1(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (!CheckIsAllEmpty())
            {
                if (!CheckIsRightNumber(tbPhone.Text))
                {
                    errorProvider1.SetError(tbPhone, "Validate Number!");
                    return;
                }
                if (!CheckIsPassword(tbPassword.Text))
                {
                    errorProvider1.SetError(tbPassword, "Password must bt to bigger!");
                    return;
                }
                User.Email = tbEmail.Text;
                User.FirstName = tbFirstName.Text;
                User.LastName = tbLastName.Text;
                User.UserName = tbUserName.Text;
                User.Password = tbPassword.Text;
                User.Phone = tbPhone.Text;
                User.DateOfBirth = dtmbiker.Value;
                User.Gender = cmGender.Text;
                if (string.IsNullOrWhiteSpace(User.ImagePath))
                {
                    string ImagePath = Path.Combine(Application.StartupPath, "MyImage", "a282728431fcf05e2b1102f8da9370c1.png");
                    iconUserPhoto.ImageLocation = ImagePath;
                }
                else
                {
                    User.ImagePath = iconUserPhoto.ImageLocation;
                }
                User.UserStatus = Convert.ToInt32(cbStatus.Text);
                if (User.Save(ref ErrorMessage))
                {
                    MessageBox.Show("User Done Successfully!", "Update / Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    FillFormWithDataToUpdate();
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
                        MessageBox.Show("There Something Wronge!", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Miss Something", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

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
                iconUserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }
    }
}
