using Al_Hilali_Bank.Properties;
using BusinessLayer;
using FontAwesome.Sharp;
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
    public partial class frmDepositWithdraw : Form
    {
        enum enTransaction { None=-1, Deposit=0,Withdraw=1};
        clsBusinessTransactions Transactions=new clsBusinessTransactions();
        enTransaction _TransactionType = enTransaction.None;
        public frmDepositWithdraw(string TransactionType)
        {
            InitializeComponent();
            if(TransactionType=="Deposit")
            {
                _TransactionType = enTransaction.Deposit;
                Transactions.TransactionType = TransactionType;
            }
            else if(TransactionType=="Withdraw")
            {
                _TransactionType=enTransaction.Withdraw;
                Transactions.TransactionType = TransactionType;
            }
            else
            {
                _TransactionType=enTransaction.None;
            }
        }

        void FixButton(Color FillColor,Color ForeColor,string Operator)
        {
            btn100.Text =Operator+btn100.Text;
            btn200.Text =Operator+btn200.Text;
            btn500.Text =Operator+btn500.Text;
            btn1000.Text =Operator+btn1000.Text;
            btn100.FillColor =FillColor;
            btn200.FillColor =FillColor;
            btn500.FillColor = FillColor;
            btn1000.FillColor = FillColor;
            btn100.ForeColor = ForeColor;
            btn200.ForeColor = ForeColor;
            btn500.ForeColor = ForeColor;
            btn1000.ForeColor = ForeColor;
        }
        private void RefereshDeposit()
        {
            btnConfirm.Text = "Confirm Deposit";
            btnConfirm.FillColor = Color.Green;
            tbAmount.IconLeft = Resources.Deposit;
            tbAmount.IconLeftSize = new Size(40,40);
            Color fillcolor = Color.FromArgb(192, 255, 192);
            Color forecolor = Color.Green;
            FixButton(fillcolor, forecolor,"+");
        }
        private void RefereshWithdraw()
        {
            btnConfirm.Text = "Confirm Withdraw";
            btnConfirm.FillColor = Color.Red;
            tbAmount.IconLeft = Resources.Whithdrow;
            tbAmount.IconLeftSize = new Size(40, 40);
            Color fillcolor = Color.FromArgb(255, 192, 192);
            Color forecolor = Color.Red;
            FixButton(fillcolor, forecolor, "-");

        }
        private void frmDepositWithdraw_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBusinessClients.GetListClient();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string FulName = Convert.ToString(dr["FirstName"] + " " + dr["LastName"]);
                    cbClients.Items.Add(FulName);
                    cbAccountNumber.Items.Add(dr["AccountNumber"]);
                }
                if (_TransactionType == enTransaction.Deposit)
                {
                    lblSubTitle.Text = "Add funds to your account";
                    lblTransactionTitle.Text = "Deposit Money";
                    lblTransactionTitle.ForeColor = Color.Green;
                    RefereshDeposit();
                }
                else if (_TransactionType == enTransaction.Withdraw)
                {
                    lblSubTitle.Text = "Withdraw funds from your account";
                    lblTransactionTitle.Text = "Withdraw Money";
                    lblTransactionTitle.ForeColor = Color.Red;
                    RefereshWithdraw();
                }
            }
       }

        private void btn100_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            decimal value = Convert.ToDecimal(btn.Tag);
            tbAmount.Text = value.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text.Length > 0 && tbAmount.Text.All(char.IsNumber)&&cbClients.SelectedIndex>=0)
            {
                Transactions.UserID = GlobalUser.CurrentUser.ID;
                Transactions.Amount =Convert.ToDecimal(tbAmount.Text);
                if (_TransactionType == enTransaction.Deposit)
                {
                    if (Transactions.SaveTransaction())
                    {
                        //MessageBox.Show("Done Successfully Added to the Account !", "Deposit", MessageBoxButtons.OK);
                        iconDoneSuccessOperator.Visible = true;
                        iconDoneSuccessOperator.IconChar = IconChar.CircleCheck;
                        iconDoneSuccessOperator.IconColor = Color.DarkGreen;
                        lblDoneSeccessOperator.Text = "Successful Deposit";
                        lblSubDoneSeccessOperator.Text = "The money has been added to the account";
                        lblDoneSeccessOperator.ForeColor = Color.Green;
                        btnConfirm.Enabled = false;
                        lblTotalBalance.Text = "$"+clsBusinessClients.GetClientBalance(Transactions.ClientID).ToString();


                    }
                }
                else if (_TransactionType == enTransaction.Withdraw)
                {
                    if (clsBusinessClients.GetClientBalance(Transactions.ClientID) >= Transactions.Amount)
                    {
                        if(Transactions.SaveTransaction())
                        {
                            //MessageBox.Show("Done Successfully Withdraw the Account !", "Withdraw", MessageBoxButtons.OK);
                            iconDoneSuccessOperator.Visible = true;
                            iconDoneSuccessOperator.IconChar = IconChar.CircleCheck;
                            iconDoneSuccessOperator.IconColor = Color.DarkRed;
                            lblDoneSeccessOperator.Text = "Successful Withdraw";
                            lblDoneSeccessOperator.ForeColor = Color.Red;
                            lblSubDoneSeccessOperator.Text = "The money has been withdrawn from the account";
                            btnConfirm.Enabled = false;
                            lblTotalBalance.Text = "$" + clsBusinessClients.GetClientBalance(Transactions.ClientID).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Amount bigger than Client Balance !", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
                else
                {
                    MessageBox.Show("There is Some thing prevent Operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Amount Of Money Or Choose Client!","Error",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAccountNumber.SelectedIndex = cbClients.SelectedIndex;
            Transactions.ClientID=clsBusinessClients.Find(cbAccountNumber.Text).ID;
            lblTotalBalance.Text ="$"+ clsBusinessClients.GetClientBalance(Transactions.ClientID).ToString("N2");
        }

        private void iconbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
