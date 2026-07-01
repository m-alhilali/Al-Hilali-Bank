using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Al_Hilali_Bank
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBusinessCountries.GitListCountries();
            foreach (DataRow dataRow in dt.Rows)
            {
                cbFromCurrency.Items.Add(dataRow["CountryName"]);
                cbToCurrency.Items.Add(dataRow["CountryName"]);
                
            }

        }

        private void cbFromCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, "Flag", cbFromCurrency.Text + ".png");
            if (File.Exists(path))
            {

                iconFromCurrency.Image = Image.FromFile(path);
                iconFromCurrency.Size = new Size(30,30);
            }

            lblAmount.Text = $"Amount({clsBusinessExchange.GetNameOfCurrencyCodeByCountry(cbFromCurrency.Text)})";
        }

        private void cbToCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, "Flag", cbToCurrency.Text + ".png");
            if (File.Exists(path))
            {
                iconToCurrency.Image = Image.FromFile(path);
                iconToCurrency.Size = new Size(30, 30);


            }
            lblYouWillGet.Text = $"You Will Get({clsBusinessExchange.GetNameOfCurrencyCodeByCountry(cbToCurrency.Text)})";
            

        }

        private void GetRate()
        {
            if (tbFromMoney.Text == "")
                return;
            if (!string.IsNullOrWhiteSpace(cbToCurrency.Text) && !string.IsNullOrWhiteSpace(cbFromCurrency.Text))
            {
                string CodeFrom = clsBusinessExchange.GetNameOfCurrencyCodeByCountry(cbFromCurrency.Text).ToUpper();
                string CodeTo = clsBusinessExchange.GetNameOfCurrencyCodeByCountry(cbToCurrency.Text).ToUpper();
                decimal RateFrom = clsBusinessExchange.GetRate(CodeFrom);
                decimal RateTo = clsBusinessExchange.GetRate(CodeTo);
                if(RateFrom<=0 || RateTo<=0)
                {
                    MessageBox.Show("Invalid Country", "Exchange Rate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                lblExchangeRate.Text = $"1 {CodeFrom} = {Math.Round((RateTo/RateFrom),3)} {CodeTo}";

                if (clsBusinessExchange.GetNameOfCurrencyCodeByCountry(cbFromCurrency.Text).ToUpper() == "USD")
                {
                    tbGetMoney.Text = Math.Round(RateTo * Convert.ToDecimal(tbFromMoney.Text), 4).ToString("N2");
                }
                else 
                {
                    decimal temp = 0m;
                    temp = RateTo / RateFrom;
                    tbGetMoney.Text = Math.Round(Convert.ToDecimal(tbFromMoney.Text) * temp, 4).ToString("N2");

                }


            }
        }

        private void nudFromMoney_ValueChanged(object sender, EventArgs e)
        {
            if (tbFromMoney.Text.All(char.IsNumber))
                GetRate();
        }

        private void ChangeRates(object sender, EventArgs e)
        {
            if (tbFromMoney.Text.All(char.IsNumber))
                GetRate();
        }

      
    }
}
