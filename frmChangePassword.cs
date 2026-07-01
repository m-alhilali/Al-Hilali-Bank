using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Hilali_Bank
{
    public partial class frmChangePassword : Form
    {
        int _ChangeType;
        string _Type;
        public frmChangePassword(int ChangeType)
        {
            InitializeComponent();
            _ChangeType = ChangeType;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (_ChangeType == 0)
            {
                lblOldValue.Text = "Old Password";
                lblNewValue.Text = "New Password";
                tbNewValue.PlaceholderText = "New Password";
                tbOldValue.PlaceholderText = "Old Password";
                _Type= "Password";
            }
            if (_ChangeType == 1)
            {
                lblOldValue.Text = "Old UserName";
                lblNewValue.Text = "New UserName";
                tbNewValue.PlaceholderText = "New UserName";
                tbOldValue.PlaceholderText = "Old UserName";
                _Type = "UserName";
            }
        }

        private bool isAnyTextEmpty()
        {
            return (string.IsNullOrWhiteSpace(tbOldValue.Text) || string.IsNullOrWhiteSpace(tbNewValue.Text));
        }
        private bool CheckIsPassword(string Password)
        {

            if (Password.Length > 6)
            {
                return true;
            }
            return false;
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            if (isAnyTextEmpty())
            {
                MessageBox.Show($"You didn't fill all text {_Type}", $"Change {_Type}", MessageBoxButtons.OK);
                return;
            }
            if (_ChangeType == 0)
            {
                if (!(GlobalUser.CurrentUser.Password==tbOldValue.Text))
                {
                    MessageBox.Show($"Old Password is Not True", $"Change Password", MessageBoxButtons.OK);
                    return;
                }
                if (!CheckIsPassword(tbNewValue.Text))
                {
                    MessageBox.Show($"New Password is Week", $"Change Password", MessageBoxButtons.OK);
                    return;
                }
                if (GlobalUser.CurrentUser.ChangePassword(tbNewValue.Text))
                {
                    iconChangeSuccess.Visible = true;
                    lblTypeChange.Text = "Change " + _Type ;
                    lblSubTypeChange.Text = "Change " + _Type + " Successfully!";
                }
                else
                {
                    MessageBox.Show($"We couldn't Change Password", $"Change Password", MessageBoxButtons.OK);

                }

            }
            if (_ChangeType == 1)
            {
                if (!(GlobalUser.CurrentUser.UserName==tbOldValue.Text))
                {
                    MessageBox.Show($"Old UserName is Not True", $"Change UserName", MessageBoxButtons.OK);
                    return;
                }
                if (clsBusinessUsers.isUserExists(tbNewValue.Text))
                {
                    MessageBox.Show($"New UserName is Already Exists", $"Change UserName", MessageBoxButtons.OK);
                    return;
                }
                if(GlobalUser.CurrentUser.ChangeUserName(GlobalUser.CurrentUser.UserName,tbNewValue.Text))
                {
                    iconChangeSuccess.Visible = true;
                    lblTypeChange.Text = "Change " + _Type;
                    lblSubTypeChange.Text = "Change " + _Type + " Successfully!";
                    return;
                }
                else
                {
                    MessageBox.Show($"We couldn't Change UserName", $"Change UserName", MessageBoxButtons.OK);

                }


            }
        }
    }
}
