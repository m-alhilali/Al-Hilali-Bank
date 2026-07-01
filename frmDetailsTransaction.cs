using Al_Hilali_Bank.Properties;
using BusinessLayer;
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
    public partial class frmDetailsTransaction : Form
    {
        int _ClientID;
        DataView _dvTransaction;
        public frmDetailsTransaction(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

        }

        private void guna2ShadowPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefereshData()
        {
            DataTable dt = new DataTable();
            if (_ClientID <= 0)
            {
                dt = clsBusinessTransactions.GetListTransactions();
            }
            else
            {
                dt = clsBusinessTransactions.GetClientListTransactions(_ClientID);

            }
            int TotalDeposit = 0, TotalWithdrow = 0;
            if (dt != null)
            {
                dt.Columns.Add(" ", typeof(Image));
                dt.Columns[" "].SetOrdinal(4);
                dgvTransaction.RowTemplate.Height = 30;
                dgvTransaction.AutoGenerateColumns = true;
                lblTotalTransaction.Text = dt.Rows.Count.ToString();
                _dvTransaction = dt.DefaultView;
                dgvTransaction.DataSource = _dvTransaction;
                if (_ClientID <= 0)
                {
                    lblCurrentBalance.Text = Convert.ToInt32(dt.Compute("COUNT(TransactionType)", "TransactionType='Deposit'")).ToString();
                }

                else
                {
                    lblCurrentBalance.Text = clsBusinessTransactions.GetPostBalancebyClientID(_ClientID).ToString();
                }
                TotalDeposit = Convert.ToInt32(dt.Compute("COUNT(TransactionType)", "TransactionType='Deposit'"));
                TotalWithdrow = Convert.ToInt32(dt.Compute("COUNT(TransactionType)", "TransactionType='Withdraw'"));
                lblTotalDeposit.Text = TotalDeposit.ToString();
                lblTotalWithdrow.Text = TotalWithdrow.ToString();


            }
        }

        private void frmDetailsTransaction_Load(object sender, EventArgs e)
        {

            RefereshData();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            if (cbFilterTransaction.Text == "TransactionType")
            {

                _dvTransaction.RowFilter = $"{cbFilterTransaction.Text} Like '{tbSearchTransaction.Text}%'";
                return;
            }
            try
            {
                if (cbFilterTransaction.Text == "ClientID")
                {
                    if (int.TryParse(tbSearchTransaction.Text, out int value))
                    {
                        _dvTransaction.RowFilter = $"{tbSearchTransaction.Text} = {value}";

                    }
                    else
                    {
                        _dvTransaction.RowFilter = "";
                    }
                }
                else
                {
                    _dvTransaction.RowFilter = $"{tbSearchTransaction.Text} Like '{tbSearchTransaction.Text}%'";

                }
            }
            catch (Exception ex)
            {
                _dvTransaction.RowFilter = "";
            }


        }

        private void iconbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTransaction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvTransaction.Columns.Count)
            {
                if (dgvTransaction.Columns[e.ColumnIndex].Name=="Amount" && e.Value != null)
                {
                    object columnname = dgvTransaction.Rows[e.RowIndex].Cells["TransactionType"].Value;
                    if (columnname != null && columnname != DBNull.Value)
                    {

                        string transactionname = columnname.ToString().Trim();
                        if(transactionname == "Deposit")
                        {
                            string value=e.Value.ToString();
                            e.Value = "+" + value;
                            e.FormattingApplied = true;
                            e.CellStyle.ForeColor = Color.Green;
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }
                        else if(transactionname == "Withdraw")
                        {
                            string value=e.Value.ToString();
                            e.Value = "-" + value;
                            e.FormattingApplied = true;
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);


                        }
                    }

                }
                if (dgvTransaction.Columns[e.ColumnIndex].Name==" " && e.Value != null)
                {
                    object columnname = dgvTransaction.Rows[e.RowIndex].Cells["TransactionType"].Value;
                    Image image = null;
                    if (columnname != null && columnname != DBNull.Value)
                    {

                        string transactionname = columnname.ToString().Trim();
                        if(transactionname == "Deposit")
                        {
                            
                            image =Properties.Resources.Deposit;

                        }
                        else if(transactionname == "Withdraw")
                        {
                            image = Properties.Resources.Whithdrow;

                        }
                        if(image != null)
                        {
                            int imageW = 35;
                            int imageH = 35;
                            Bitmap resizeimage = new Bitmap(image, new Size(imageW, imageH));
                            e.Value = resizeimage;
                            e.FormattingApplied = true;
                        }
                    }

                }
            }
        }
    }
}
