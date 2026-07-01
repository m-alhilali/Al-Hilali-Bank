using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Al_Hilali_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control control = this;
            
        }

        private void Raisbtn(object sender, EventArgs e)
        {
            clsChangeButtonSize.RaisButton(sender);
        }
    
        private void Resetbtn(object sender, EventArgs e)
        {
            clsChangeButtonSize.ResetButton(sender);
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            Form frmsignup = new frmSignUp();
            frmsignup.ShowDialog();
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            Form frmmain = new MainScreenBank();
            if (clsBusinessUsers.isUserExists(tbUserName.Text, tbPassword.Text))
            {
                string ErorrMessage = "";
                GlobalUser.CurrentUser = clsBusinessUsers.Find(tbUserName.Text, tbPassword.Text);
                clsBusinessLoginRegister.AddNewRegister(GlobalUser.CurrentUser.ID, ref ErorrMessage);
                frmmain.ShowDialog();
                tbUserName.Text = "";
                tbPassword.Text = "";
            }
            else
            {
                MessageBox.Show("User Dosn't Exists!", "SIGN IN", MessageBoxButtons.OK);

            }
        }
    }
}
