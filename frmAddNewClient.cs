using BusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmUpdateORAddNewClient : Form
    {
        private int _Mode;
        private int _ClientID;
        private clsBusinessClients Client;
        enum enMode {Add=0,Update=1}
        private enMode Mode=enMode.Add;
        public frmUpdateORAddNewClient(int Mode,int ClientID)
        {
            InitializeComponent();
            _Mode = Mode;
            _ClientID = ClientID;
            if(_Mode==0)
            {
                this.Mode = enMode.Add;
            }
            else
            {
                this.Mode=enMode.Update;
                Client= clsBusinessClients.Find(_ClientID);

            }
        }

        private void frmAddNewClient_Load(object sender, EventArgs e)
        {
            if(this.Mode==enMode.Update)
            {
                FillFormWithDataToUpdate();
            }
            else
            {
                Client = new clsBusinessClients();

            }
        }
        private void FillFormWithDataToUpdate()
        {
            if (this.Mode == enMode.Update)
            {
                lblTitle.Text = "UPDATE CLIENT = " + Client.ID.ToString();
                tbAccountNumber.Text = Client.AccountNumber;
                tbEmail.Text = Client.Email;
                tbFirstName.Text = Client.FirstName;
                tbLastName.Text = Client.LastName;
                tbPassword.Text = Client.Password;
                tbPhone.Text = Client.Phone;
                tbPinCode.Text = Client.PinCode;
                cbStatus.SelectedIndex = Client.AccoustStatus;
                dtmbiker.Value = Client.DateOfBirth;
                cmGender.Text=(Client.Gender=="M")?"Male":"Female";
                
                mtbBalance.Text = Convert.ToInt32(Client.Balance).ToString();

            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
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
        private bool CheckIsAllEmpty()
        {
            return (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbAccountNumber.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text) ||
                string.IsNullOrWhiteSpace(cmGender.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text) ||
                string.IsNullOrWhiteSpace(mtbBalance.Text) ||
                string.IsNullOrWhiteSpace(tbPinCode.Text));
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
                Client.Email = tbEmail.Text;
                Client.FirstName = tbFirstName.Text;
                Client.LastName = tbLastName.Text;
                Client.AccountNumber = tbAccountNumber.Text;
                Client.Password = tbPassword.Text;
                Client.Phone = tbPhone.Text;
                Client.DateOfBirth = dtmbiker.Value;
                Client.Gender = cmGender.Text;
                Client.Balance = Convert.ToDecimal(mtbBalance.Text);
                Client.PinCode = tbPinCode.Text;
                Client.AccoustStatus = Convert.ToInt32(cbStatus.Text);
                if (Client.Save(ref ErrorMessage))
                {
                    MessageBox.Show("User Done Successfully!", "Update / Add User", MessageBoxButtons.OK);
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
                        errorProvider1.SetError(tbAccountNumber, ErrorMessage);
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

        private void iconbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
