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
    public partial class frmUpdateRate : Form
    {
        private int _UserID;
        private string _CurrencyCode;
        private string _NameOFLastUserUpdate;
        private DateTime _LastDateTime;
        public frmUpdateRate(int UserID,string CurrencyCode)
        {
            InitializeComponent();
            _UserID = UserID;
            _CurrencyCode = CurrencyCode;
            _LastDateTime= DateTime.Now;
            _NameOFLastUserUpdate = "";
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tbCurrentExchange.Text= nudNewRate.Value.ToString();
        }

        private void frmUpdateRate_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_CurrencyCode))
            {
                cbSelectCountries.Enabled = false;
                if(clsBusinessExchange.GetLasUpdateDateAndNameOfUserByCurrencyCode(_CurrencyCode,ref _NameOFLastUserUpdate,ref _LastDateTime))
                {
                    RefereshByCurrencyCode();
                }
            }
            else
            {
                cbSelectCountries.Enabled = true;
                DataTable dt=clsBusinessCountries.GitListCountries();
                foreach (DataRow dataRow in dt.Rows) 
                {
                    cbSelectCountries.Items.Add(dataRow["CountryName"]);
                }
                cbSelectCountries.SelectedIndex = 0;

            }
            nudNewRate.Focus();

        }

        private void RefereshByCountryName()
        {
            _CurrencyCode = clsBusinessExchange.GetNameOfCurrencyCodeByCountry(cbSelectCountries.Text);
            if (_CurrencyCode != "")
            {
                clsBusinessExchange.GetLasUpdateDateAndNameOfUserByCurrencyCode(_CurrencyCode, ref _NameOFLastUserUpdate, ref _LastDateTime);
                tbCurrencyCode.Text = _CurrencyCode;
                tbLastUser.Text = _NameOFLastUserUpdate;
                tbLastDate.Text = _LastDateTime.ToString();
                nudNewRate.Value = clsBusinessExchange.FindByCode(_CurrencyCode).ExchangeRate;
                tbCurrentExchange.Text = nudNewRate.Value.ToString();
            }
            else
            {
                tbCurrencyCode.Text = "";
                tbLastUser.Text = "";
                tbLastDate.Text = "";
            }
        }
        private void RefereshByCurrencyCode()
        {
            if (_CurrencyCode != "")
            {
                clsBusinessExchange.GetLasUpdateDateAndNameOfUserByCurrencyCode(_CurrencyCode, ref _NameOFLastUserUpdate, ref _LastDateTime);
                tbCurrencyCode.Text = _CurrencyCode;
                tbLastUser.Text = _NameOFLastUserUpdate;
                tbLastDate.Text = _LastDateTime.ToString();
                cbSelectCountries.Items.Add((clsBusinessExchange.FindByCode(_CurrencyCode)).CountryName);
                cbSelectCountries.SelectedIndex = 0;
                nudNewRate.Value = clsBusinessExchange.FindByCode(_CurrencyCode).ExchangeRate;
                tbCurrentExchange.Text = nudNewRate.Value.ToString();
            }
            else
            {
                tbCurrencyCode.Text = "";
                tbLastUser.Text = "";
                tbLastDate.Text = "";
            }
        }
        private bool CheckIsAllEmpty()
        {
            return (string.IsNullOrWhiteSpace(tbCurrencyCode.Text) ||
                string.IsNullOrWhiteSpace(tbCurrentExchange.Text) ||
                string.IsNullOrWhiteSpace(tbLastDate.Text) ||
                string.IsNullOrWhiteSpace(tbLastUser.Text) ||
                string.IsNullOrWhiteSpace(cbSelectCountries.Text) ||
                string.IsNullOrWhiteSpace(nudNewRate.Value.ToString()));
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(!CheckIsAllEmpty())
            {
                clsBusinessExchange _UpdateRate=new clsBusinessExchange();
                _UpdateRate.CurrencyCode = _CurrencyCode;
                _UpdateRate.ExchangeRate = nudNewRate.Value;
                _UpdateRate.LastUserID = GlobalUser.CurrentUser.ID;

                if(_UpdateRate.Save())
                {
                    MessageBox.Show("Updated Done Successfuly!", "Update Rate", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    Console.WriteLine("\a");
                    RefereshByCurrencyCode();
                }
                else
                {
                    MessageBox.Show("Update Failed!", "Update Rate", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void cbSelectCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefereshByCountryName();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
