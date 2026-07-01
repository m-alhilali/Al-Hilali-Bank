using BusinessLayer;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;
using static BusinessLayer.clsBusinessUsers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Al_Hilali_Bank
{
    public partial class MainScreenBank : Form
    {
        private DataView _dvClients;
        private DataView _dvUsers;
        private DataView _dvExchange;
        private DataView _dvRecentTransaction;
        private DataView _dvTransfer;


        private bool CheckFromPerrmissions(clsBusinessUsers.enPermissions Permissions)
        {
            return (GlobalUser.CurrentUser.CheckAccessPermissions(Permissions));
        }
        public MainScreenBank()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer|ControlStyles.UserPaint|ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

        }

        //From Here For DashBoard

        private void RefereshToFillDashBoard()
        {
            DataTable dt1client = clsBusinessClients.GetListClient();
            if (dt1client != null)
            {
                lblTotalCustomerInDashboard.Text = dt1client.Rows.Count.ToString();
            }
            DataTable dt2user = clsBusinessUsers.GitListUsers();
            if (dt2user != null)
            {
                lblTotalUserInDashboard.Text = dt2user.Rows.Count.ToString();
            }

            DataTable dt3depositorwithdraw = clsBusinessTransactions.GetListTransactions();
            decimal TotalDeposite = 0, TotalWithdraw = 0;

            if (dt3depositorwithdraw != null)
            {
                TotalDeposite = Convert.ToInt32(dt3depositorwithdraw.Compute("SUM(Amount)", "TransactionType='Deposit'"));
                TotalWithdraw = Convert.ToInt32(dt3depositorwithdraw.Compute("SUM(Amount)", "TransactionType='Withdraw'"));
                lblTotalDepositInDashboard.Text = "$ " + TotalDeposite.ToString("N2");
                lblTotalWithdrawInDashboars.Text = "$ " + TotalWithdraw.ToString("N2");
            }

            DataTable dataTableRecentTransaction = clsBusinessTransactions.GetRecentTransaction();
            if (dataTableRecentTransaction != null)
            {

                _dvRecentTransaction = dataTableRecentTransaction.DefaultView;
                dgvRecentTransactionDashboard.DataSource = _dvRecentTransaction;


            }

        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ShowDetailsTransactions(sender, e);
        }

        private void btnViewAllCustomers_Click(object sender, EventArgs e)
        {
            ChangeToCustomersTab(sender, e);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ShowDetailsTransactions(sender, e);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ChangeToUserTab(sender, e);
        }






        //Here All Tab and main scren bank load
        private void ChangeToCustomersTab(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tabControl.SelectedIndex = 0;
            cbFilterUsers.SelectedText = "FirstName";
            Focus(sender);
            RefereshToFillDataGridViewWithClients();
            this.ResumeLayout();

        }
        private void ChangeToUserTab(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tabControl.SelectedIndex = 1;
            cbFilterUsers.SelectedText = "FirstName";
            RefereshToFillDataGridViewWithUsers();
            Focus(sender);
            this.ResumeLayout();


        }
        private void ChangeToAccountTab(object sender, EventArgs e)
        {

            this.SuspendLayout();
            tabControl.SelectedIndex = 2;
            RefereshToFillDataInTabAccountExchange();
            this.ResumeLayout();


        }
        private void ChangeToTransferTab(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tabControl.SelectedIndex = 3;
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Transfers))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            RefereshAllToFillDataGridViewWithTransfers();
            this.ResumeLayout();

        }
        private void ChangeToTransactionTab(object sender, EventArgs e)
        {
            this.SuspendLayout();

            tabControl.SelectedIndex = 4;
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Transactions))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            Focus(sender);
            this.ResumeLayout();


        }
        private void ChangeToExchangeTab(object sender, EventArgs e)
        {
            this.SuspendLayout();

            tabControl.SelectedIndex = 5;
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Exchanges))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            RefereshToFillDataGridViewWithExchange();
            this.ResumeLayout();

        }
        private void ChangeToHomeTab(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tabControl.SelectedIndex = 6;
            lblWelcome.Text = "Hi, (" + GlobalUser.CurrentUser.UserName + ") " + GlobalUser.CurrentUser.FirstName + " " + GlobalUser.CurrentUser.LastName;
            RefereshToFillDashBoard();
            this.ResumeLayout();
        }
        private void MainScreenBank_Load(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 6;
            iconUserPhoto2.ImageLocation = GlobalUser.CurrentUser.ImagePath;
            btnDashBoard.PerformClick();
            cbFilterClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterClients.SelectedIndex = 3;
            if (GlobalUser.CurrentUser != null)
                lblUserName.Text = GlobalUser.CurrentUser.UserName;

        }



        //From Here For Clients

        private void dgvClients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvClients.Columns.Count)
            {
                if (dgvClients.Columns[e.ColumnIndex].Name == "AccountStatus" && e.Value != null)
                {
                    string cellvalue = e.Value.ToString();
                    if (cellvalue == "1")
                    {
                        e.Value = "Active";
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        e.FormattingApplied = true;
                    }
                    else if (cellvalue == "0")
                    {
                        e.Value = "InActive";
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

                        e.FormattingApplied = true;
                    }
                }
            }
            if (dgvClients.Columns[e.ColumnIndex].Name == "CurrentSenderClientBalance" && e.Value != null)
            {
                string value = e.Value.ToString();
                e.Value = "+" + value;
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.FormattingApplied = true;
            }
        }
        private void RefereshToFillDataGridViewWithClients()
        {
            DataTable dataTable = clsBusinessClients.GetListClient();
            decimal TotalBalance = 0m;
            int TotalActive = 0, TotalInactive = 0;
            if (dataTable != null)
            {
                lblTotalCustomers.Text = dataTable.Rows.Count.ToString();
                lblNewCustomersTotal.Text = clsBusinessClients.GetLastClientAddInLastMonth().ToString();
                TotalBalance = Convert.ToDecimal(dataTable.Compute("SUM(Balance)", string.Empty));
                TotalActive = Convert.ToInt32(dataTable.Compute("COUNT(AccountStatus)", "AccountStatus=1"));
                TotalInactive = Convert.ToInt32(dataTable.Compute("COUNT(AccountStatus)", "AccountStatus=0"));
                lblTotalBalanceClients.Text = TotalBalance.ToString();
                lblTotalActiveClients.Text = TotalActive.ToString();
                lblInActiveClients.Text = TotalInactive.ToString();
                _dvClients = dataTable.DefaultView;
                dgvClients.DataSource = _dvClients;


            }


        }
        private void Focus(object sender)
        {
            ((Control)sender).Focus();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Add_Clients))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            Form frmAdd = new frmUpdateORAddNewClient(0, 0);
            frmAdd.ShowDialog();
            RefereshToFillDataGridViewWithClients();
            GlobalUser.CurrentUser = clsBusinessUsers.Find(GlobalUser.CurrentUser.ID);


        }
        private void tbSearchCLient_TextChanged(object sender, EventArgs e)
        {
            SearchClientsByFilter(cbFilterClients.Text, ((Guna2TextBox)sender).Text);
        }
        private void SearchClientsByFilter(string CloumnName, string ValueToSearch)
        {

            try
            {
                if (CloumnName == "ClientID" || CloumnName == "AccountStatus")
                {
                    if (int.TryParse(ValueToSearch, out int value))
                    {
                        _dvClients.RowFilter = $"{cbFilterClients.Text} = {value}";

                    }
                    else
                    {
                        _dvClients.RowFilter = "";
                    }
                }
                else
                {
                    _dvClients.RowFilter = $"{cbFilterClients.Text} Like '{tbSearchCLient.Text}%'";

                }
            }
            catch (Exception ex)
            {
                _dvClients.RowFilter = "";
            }

        }
        private void ChangeFilterSearch(object sender, EventArgs e)
        {
            tbSearchCLient.PlaceholderText = "Search By " + cbFilterClients.Text;
        }
        private void ShowAll(DataView dv, Guna2TextBox tb)
        {
            dv.RowFilter = "";
            tb.Text = "";
        }
        private void btnShwoAll_Click(object sender, EventArgs e)
        {
            ShowAll(_dvClients, tbSearchCLient);
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Update_Clients))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            int ID = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);
            Form frm = new frmUpdateORAddNewClient(1, ID);
            frm.ShowDialog();
            RefereshToFillDataGridViewWithClients();

        }
        private void ActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Active_Mode_Clients))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            int ID = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);
            clsBusinessClients.ActiveModeClient(ID);
            RefereshToFillDataGridViewWithClients();

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SearchUsersByFilter(cbFilterClients.Text, ((Guna2TextBox)sender).Text);

        }










        //From Here For Users
        private void RefereshToFillDataGridViewWithUsers()
        {

            DataTable dataTable = clsBusinessUsers.GitListUsers();
            int TotalAdminstrator = 0, TotalRegular = 0;
            if (dataTable != null)
            {
                lblTotalUsers.Text = dataTable.Rows.Count.ToString();
                lblTotalNewUusers.Text = clsBusinessUsers.GetLastUsersAddInLastMonth().ToString();
                _dvUsers = dataTable.DefaultView;
                dgvUsers.DataSource = _dvUsers;
                TotalAdminstrator = Convert.ToInt32(dataTable.Compute("COUNT(Permissions)", "Permissions=-1"));
                TotalRegular = Convert.ToInt32(dataTable.Compute("COUNT(UserID)", "AccountStatus=1 Or AccountStatus =0"));
                lblTotalAdministrators.Text = TotalAdminstrator.ToString();
                lblTotalRegular.Text = TotalRegular.ToString();


            }
        }
        private void tbSearchUser_TextChanged(object sender, EventArgs e)
        {
            SearchUsersByFilter(cbFilterUsers.Text, ((Guna2TextBox)sender).Text);
        }
        private void SearchUsersByFilter(string CloumnName, string ValueToSearch)
        {

            try
            {
                if (CloumnName == "UserID" || CloumnName == "AccountStatus" || CloumnName == "Permissions")
                {
                    if (int.TryParse(ValueToSearch, out int value))
                    {
                        _dvUsers.RowFilter = $"{cbFilterUsers.Text} = {value}";

                    }
                    else
                    {
                        _dvUsers.RowFilter = "";
                    }
                }
                else
                {
                    _dvUsers.RowFilter = $"{cbFilterUsers.Text} Like '{tbSearchUsers.Text}%'";

                }
            }
            catch (Exception ex)
            {
                _dvUsers.RowFilter = "";
            }

        }
        private void cbFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchUsers.PlaceholderText = "Search By " + cbFilterUsers.Text;
            tbSearchUsers.Focus();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //ShowAll(_dvUsers, tbSearchUsers);

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Add_Users))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            Form frmAdd = new frmAddOrUpdateUsers(0, 0);
            frmAdd.ShowDialog();
            RefereshToFillDataGridViewWithUsers();
        }
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvUsers.Columns.Count)
            {
                if (dgvUsers.Columns[e.ColumnIndex].Name == "AccountStatus" && e.Value != null)
                {
                    string cellvalue = e.Value.ToString();
                    if (cellvalue == "1")
                    {
                        e.Value = "Active";
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Black;
                        e.FormattingApplied = true;

                    }
                    else if (cellvalue == "0")
                    {
                        e.Value = "InActive";
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                        e.FormattingApplied = true;
                    }
                }
            }

            if (dgvUsers.Columns[e.ColumnIndex].Name == "Permissions" && e.Value != null)
            {
                if (Convert.ToInt32(e.Value) == -1 || Convert.ToInt32(e.Value) >= 1023)
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Active_Mode_Users))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            int ID = 0;
            ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
            clsBusinessUsers.ActiveModeUser(ID);
            RefereshToFillDataGridViewWithUsers();

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Update_Users))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            int ID = 0;
            ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
            Form frmAdd = new frmAddOrUpdateUsers(1, ID);
            frmAdd.ShowDialog();
            GlobalUser.CurrentUser = clsBusinessUsers.Find(GlobalUser.CurrentUser.ID);
            RefereshToFillDataGridViewWithUsers();

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (iconButton1.Tag.ToString() == "1")
            {
                iconButton1.Tag = 0;
                guna2Panel1.Width = 2;
            }
            else
            {
                iconButton1.Tag = 1;
                guna2Panel1.Width = 255;
            }
        }

        private void tabExchanges_Click(object sender, EventArgs e)
        {

        }





        //From Here For Exchange
        private void RefereshToFillDataGridViewWithExchange()
        {
            DataTable dataTable = clsBusinessExchange.GitListExchange();
            if (dataTable != null)
            {
                dataTable.Columns.Add(" ", typeof(Image));
                dataTable.Columns[" "].SetOrdinal(1);

                //foreach (DataRow dataRow in dataTable.Rows)
                //{
                //    string countryname = dataRow["CountryName"].ToString().ToLower();
                //    string path = Path.Combine(Application.StartupPath, "Flag", countryname + ".png");
                //    if (File.Exists(path))
                //    {
                //        dataRow[" "] = Image.FromFile(path);
                //    }
                //}

                dgvExchange.RowTemplate.Height = 30;
                dgvExchange.AutoGenerateColumns = true;
                _dvExchange = dataTable.DefaultView;
                dgvExchange.DataSource = _dvExchange;

                lblTotalCountries.Text = dataTable.Rows.Count.ToString();
                lblTotalCurrencies.Text = clsBusinessExchange.GetTotalDistinctCurrencyCode().ToString();

                string NameOfUser = "";
                DateTime LastUpdateRate = DateTime.Now;
                clsBusinessExchange.GetLasUpdateDateByUser(ref NameOfUser, ref LastUpdateRate);
                lblLastUpdateRate.Text = LastUpdateRate.Date.ToString();
                lblLastUpdate.Text = "By " + NameOfUser;

            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            Form form = new frmUpdateRate(9, "");
            form.ShowDialog();
            RefereshToFillDataGridViewWithExchange();

        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string CurrencyCode = Convert.ToString(dgvExchange.CurrentRow.Cells[2].Value);
            Form form = new frmUpdateRate(9, CurrencyCode);
            form.ShowDialog();
            RefereshToFillDataGridViewWithExchange();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            string Name = "";
            clsBusinessExchange.GetLasUpdateDateByUser(ref Name, ref Date);
            int ID = Convert.ToInt32(dgvExchange.CurrentRow.Cells[0].Value);
            MessageBox.Show(Date + " BY " + Name, "Last Update", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            if (cbFilterExchange.Text == "CurrencyCode" || cbFilterExchange.Text == "CurrencyName" || cbFilterExchange.Text == "CountryName")
            {

                _dvExchange.RowFilter = $"{cbFilterExchange.Text} Like '{tbSearchExchange.Text}%'";

            }


        }
        private void cbFilterExchange_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchExchange.PlaceholderText = "Search By " + cbFilterExchange.Text;
            tbSearchExchange.Focus();
        }
        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            Form frm = new frmCurrencyExchange();
            frm.ShowDialog();
        }
        private void dgvExchange_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach (DataRow dataRow in dataTable.Rows)
            //{
            //    string countryname = dataRow["CountryName"].ToString().ToLower();
            //    string path = Path.Combine(Application.StartupPath, "Flag", countryname + ".png");
            //    if (File.Exists(path))
            //    {
            //        dataRow[" "] = Image.FromFile(path);
            //    }
            //}

            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvExchange.Columns.Count)
            {
                if (dgvExchange.Columns[e.ColumnIndex].Name == " " && e.Value != null)
                {
                    string Countryname = dgvExchange.Rows[e.RowIndex].Cells["CountryName"].Value.ToString();
                    string path = Path.Combine(Application.StartupPath, "Flag", Countryname + ".png");
                    Image image = null;
                    if (File.Exists(path))
                    {
                        image = Image.FromFile(path);
                        if (image != null)
                        {
                            int W = 40;
                            int H = 40;
                            Bitmap resize = new Bitmap(image, new Size(W, H));
                            e.Value = resize;
                            e.FormattingApplied = true;
                        }
                    }
                }

            }
        }



        //From Here For Transaction

        private void ShowDetailsTransactions(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Active_Mode_Users))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            Form frm = new frmDetailsTransaction(0);
            frm.ShowDialog();
        }
        private void DepositOrWithdrawMoney(object sender, EventArgs e)
        {
            if (!CheckFromPerrmissions(clsBusinessUsers.enPermissions.Transactions))
            {
                MessageBox.Show("You Don't Have Permission To Do This!", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            Guna2Button btn = sender as Guna2Button;
            Form frm = new frmDepositWithdraw(btn.Text);
            frm.ShowDialog();
        }
        private void ShowUserPhoto(object sender, EventArgs e)
        {

            Form frm = new frmShowUserPhoto();
            frm.ShowDialog();
            GlobalUser.CurrentUser.ImagePath = clsBusinessUsers.Find(GlobalUser.CurrentUser.ID).ImagePath;
            iconUserPhoto.ImageLocation = GlobalUser.CurrentUser.ImagePath;
            iconUserPhoto2.ImageLocation = GlobalUser.CurrentUser.ImagePath;
        }






        //From Here For Account
        public enum Permission { Add_Clients = 1, Update_Clients = 2, Active_Mode_Clients = 4, Add_Users = 8, Update_Users = 16, Active_Mode_Users = 32, Exchanges = 64, Transactions = 128, Transfers = 256 };
        private void ShowUserPermissions()
        {

            int Permission = GlobalUser.CurrentUser.Permissions;
            if ((Convert.ToInt32(enPermissions.Add_Clients) & Permission) == Convert.ToInt32(enPermissions.Add_Clients))
            {
                chAddClients.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Update_Clients) & Permission) == Convert.ToInt32(enPermissions.Update_Clients))
            {
                cbUpdateClients.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Active_Mode_Clients) & Permission) == Convert.ToInt32(enPermissions.Active_Mode_Clients))
            {
                cbActiveClients.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Add_Users) & Permission) == Convert.ToInt32(enPermissions.Add_Users))
            {
                cbAddUsers.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Update_Users) & Permission) == Convert.ToInt32(enPermissions.Update_Users))
            {
                cbUpdateUsers.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Active_Mode_Users) & Permission) == Convert.ToInt32(enPermissions.Active_Mode_Users))
            {
                cbActiveUsers.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Exchanges) & Permission) == Convert.ToInt32(enPermissions.Exchanges))
            {
                cbExchanges.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Transactions) & Permission) == Convert.ToInt32(enPermissions.Transactions))
            {
                cbTransactions.Checked = true;
            }
            if ((Convert.ToInt32(enPermissions.Transfers) & Permission) == Convert.ToInt32(enPermissions.Transfers))
            {
                cbTransfsrs.Checked = true;
            }
        }
        private void RefereshToFillDataInTabAccountExchange()
        {
            GlobalUser.CurrentUser = clsBusinessUsers.Find(GlobalUser.CurrentUser.ID);
            iconUserPhoto.ImageLocation = GlobalUser.CurrentUser.ImagePath;
            lblFullName.Text = "Name: " + GlobalUser.CurrentUser.FirstName + " " + GlobalUser.CurrentUser.LastName;
            lblAccountNumber.Text = "UserName: " + GlobalUser.CurrentUser.UserName;
            lblUserID.Text = "ID: " + GlobalUser.CurrentUser.ID.ToString();
            lblPhoneNumber.Text = GlobalUser.CurrentUser.Phone;
            ShowUserPermissions();


        }
        private void cbUpdateUsers_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void NotToChangePermission(object sender, EventArgs e)
        {
            Guna2CheckBox cb = sender as Guna2CheckBox;
            cb.Checked = !cb.Checked;
        }
        private void NotToChangePermission(object sender, MouseEventArgs e)
        {
            Guna2CheckBox cb = sender as Guna2CheckBox;
            cb.Checked = !cb.Checked;
        }
        private void ChangeUserPassword(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl.Tag != null)
            {
                if (short.TryParse(ctrl.Tag.ToString(), out short typechange))
                    ChangeUserNameOrPassword(typechange);

            }

        }
        private void ChangeUserNameOrPassword(int ChangeType)
        {

            Form form = new frmChangePassword(ChangeType);
            form.ShowDialog();
            GlobalUser.CurrentUser = clsBusinessUsers.Find(GlobalUser.CurrentUser.ID);
            RefereshToFillDataInTabAccountExchange();
        }






        //From Here For Account
        private void FillTransferDetails(int RowIdex)
        {
            decimal Amount = Convert.ToDecimal(_dvTransfer[RowIdex]["Amount"]);
            decimal SenderBalanceAfter = Convert.ToDecimal(_dvTransfer[RowIdex]["SourcePostBalance"]);
            decimal SenderBalanceBefor = SenderBalanceAfter + Amount;
            decimal ReceiverBalanceAfter = Convert.ToDecimal(_dvTransfer[RowIdex]["DestinationPostBalance"]);
            decimal ReceiverBalanceBefor = ReceiverBalanceAfter - Amount;

            lblTransferID.Text = _dvTransfer[RowIdex]["TransferLogID"].ToString();
            lblTransferDateTime.Text = _dvTransfer[RowIdex]["TransferDate"].ToString();
            lblTransferSender.Text = clsBusinessClients.GetClientName(Convert.ToInt32(_dvTransfer[RowIdex]["SourceClientID"]));
            lblTransferReceiver.Text = clsBusinessClients.GetClientName(Convert.ToInt32(_dvTransfer[RowIdex]["DestinationClientID"]));

            lblTransferAmount.Text = "$ " + Amount.ToString("N2");
            lblTransferSenderBalanceAfter.Text = "$ " + SenderBalanceAfter.ToString("N2");
            lblTransferSenderBalanceBefor.Text = "$ " + SenderBalanceBefor.ToString("N2");
            lblTransferReceiverBalanceBefore.Text = "$ " + ReceiverBalanceBefor.ToString("N2");
            lblTransferReceiverBalanceAfter.Text = "$ " + ReceiverBalanceAfter.ToString("N2");

            lblTransferPerformedUserID.Text = clsBusinessUsers.GetNameOfUser(Convert.ToInt32(_dvTransfer[RowIdex]["PerformingUserID"]));

        }
        private void RefereshAllToFillDataGridViewWithTransfers()
        {

            DataTable dataTable = clsBusinessTransferLog.GetListTransferLogs();
            DataTable dtClient = clsBusinessClients.GetListClient();
            if (dtClient != null)
            {
                cbSenderClients.Items.Clear();
                cbRecieverClients.Items.Clear();
                cbSenderAccountNumber.Items.Clear();
                cbReceirverAccountNumber.Items.Clear();
                foreach (DataRow dtrow in dtClient.Rows)
                {
                    cbSenderClients.Items.Add(dtrow["FirstName"] + " " + dtrow["LastName"]);
                    cbRecieverClients.Items.Add(dtrow["FirstName"] + " " + dtrow["LastName"]);
                    cbSenderAccountNumber.Items.Add(dtrow["AccountNumber"]);
                    cbReceirverAccountNumber.Items.Add(dtrow["AccountNumber"]);
                }
            }
            if (dataTable != null)
            {
                _dvTransfer = dataTable.DefaultView;
                dgvTransfer.DataSource = _dvTransfer;
                dgvTransfer.Rows[0].Selected = true;
                dgvTransfer.CurrentCell = dgvTransfer.Rows[0].Cells[0];
                FillTransferDetails(dgvTransfer.CurrentCell.RowIndex);


            }
        }
        private void RefereshandFillDataGridViewWithNewTransfer()
        {

            DataTable dataTable = clsBusinessTransferLog.GetListTransferLogs();
            if (dataTable != null)
            {
                _dvTransfer = dataTable.DefaultView;
                dgvTransfer.DataSource = _dvTransfer;
                dgvTransfer.Rows[dgvTransfer.RowCount - 1].Selected = true;
                dgvTransfer.CurrentCell = dgvTransfer.Rows[dgvTransfer.RowCount - 1].Cells[0];
                FillTransferDetails(dgvTransfer.CurrentCell.RowIndex);


            }
        }
        private void cbFilterTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchTransfer.PlaceholderText = "Search By " + cbFilterTransfer.Text;
            tbSearchTransfer.Focus();
        }
        private void tbSearchTransfer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFilterTransfer.Text == "SourceClientID" || cbFilterTransfer.Text == "PerformingUserID" || cbFilterTransfer.Text == "DestinationClientID")
                {
                    if (int.TryParse(tbSearchTransfer.Text, out int value))
                    {
                        _dvTransfer.RowFilter = $"{cbFilterTransfer.Text} = {value}";

                    }
                    else
                    {
                        _dvTransfer.RowFilter = "";
                    }
                }
                else
                {
                    _dvTransfer.RowFilter = $"{cbFilterTransfer.Text} Like '{tbSearchTransfer.Text}%'";

                }
            }
            catch
            {
                _dvTransfer.RowFilter = "";
            }
        }

        private void FillPanelNewTransfer(Guna2ComboBox cbClient, Guna2ComboBox cbAccountNumber)
        {
            cbAccountNumber.SelectedIndex = cbClient.SelectedIndex;
            if (cbAccountNumber.Tag.ToString().ToLower() == "sender")
                lblTotalCurrentBalanceSender.Text = "$ " + clsBusinessClients.GetClientBalance(cbAccountNumber.Text).ToString("N2");
            else if (cbAccountNumber.Tag.ToString().ToLower() == "receiver")
                lblTotalCurrentBalanceReceiver.Text = "$ " + clsBusinessClients.GetClientBalance(cbAccountNumber.Text).ToString("N2");
        }
        private void cbSenderClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPanelNewTransfer(cbSenderClients, cbSenderAccountNumber);

        }

        private void cbRecieverClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPanelNewTransfer(cbRecieverClients, cbReceirverAccountNumber);

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void dgvTransfer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransfer.CurrentCell != null)
                FillTransferDetails(dgvTransfer.CurrentCell.RowIndex);
        }
        private bool isInfoTransferEmpty()
        {
            return (string.IsNullOrWhiteSpace(cbSenderClients.Text) || string.IsNullOrWhiteSpace(cbReceirverAccountNumber.Text) || string.IsNullOrWhiteSpace(tbTransferAmount.Text));
        }
        private void btnTransferNow_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbTransferAmount.Text, out decimal Amount))
            {
                tbTransferAmount.Text = Amount.ToString("N2");
            }
            if (isInfoTransferEmpty())
            {

                MessageBox.Show("You Miss Some thing!", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbTransferAmount.Text.All(char.IsNumber))
            {
                MessageBox.Show("You entered wrong amount!", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal CurrentSenderClientBalance = clsBusinessClients.GetClientBalance(cbSenderAccountNumber.Text);
            decimal CurrentReceiverClientBalance = clsBusinessClients.GetClientBalance(cbReceirverAccountNumber.Text);
            if (CurrentSenderClientBalance <= Convert.ToDecimal(tbTransferAmount.Text))
            {

                MessageBox.Show($"You cann't transfer up to {CurrentSenderClientBalance}!", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsBusinessTransferLog transfer = new clsBusinessTransferLog();
            transfer.Amount = Amount;
            transfer.SourcePostBalance = CurrentSenderClientBalance - Amount;
            transfer.DestinationPostBalance = CurrentReceiverClientBalance + Amount;
            transfer.SourceClientID = clsBusinessClients.Find(cbSenderAccountNumber.Text).ID;
            transfer.DestinationClientID = clsBusinessClients.Find(cbReceirverAccountNumber.Text).ID;
            transfer.DateTime = DateTime.Now;
            transfer.PerformingUserID = GlobalUser.CurrentUser.ID;
            if (MessageBox.Show("Are you Sure You Want To Transfer ?", "Transfer", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (transfer.SaveTransferLog())
                {
                    MessageBox.Show($"Done Transfer Successfully !", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    lblTotalBalanceSenderAfterTransfer.Text = clsBusinessClients.GetClientBalance(cbSenderAccountNumber.Text).ToString();
                    lblTotalBalanceReceiverAfterTransfer.Text = clsBusinessClients.GetClientBalance(cbReceirverAccountNumber.Text).ToString();
                    RefereshandFillDataGridViewWithNewTransfer();
                    return;
                }
            }




        }

        private void RefereshNewTransfer(object sender, EventArgs e)
        {
            RefereshNewTransfer();
        }
        private void RefereshNewTransfer()
        {
            cbRecieverClients.SelectedIndex = -1;
            cbSenderClients.SelectedIndex = -1;
            tbTransferAmount.Text = string.Empty;
            lblTotalBalanceReceiverAfterTransfer.Text = string.Empty;
            lblTotalBalanceSenderAfterTransfer.Text = string.Empty;
        }

        private void GoToAddNewCustomerFromDashboars(object sender, EventArgs e)
        {
            btnAddCustomer_Click(sender, e);
        }

        private void GoToAddNewUserFromDashboars(object sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
        }

        private void GoToAddNewDepositFromDashboars(object sender, EventArgs e)
        {
            Guna2Button btn = new Guna2Button();
            btn.Text = "Deposit";
            DepositOrWithdrawMoney(btn, e);
        }

        private void GoToAddNewWithdrawFromDashboars(object sender, EventArgs e)
        {
            Guna2Button btn = new Guna2Button();
            btn.Text = "Withdraw";
            DepositOrWithdrawMoney(btn, e);
        }

        private void GoToAddNewTransferFromDashboars(object sender, EventArgs e)
        {
            ChangeToTransferTab(sender, e);
        }

        private void GoToExchangeDifferentFromDashboars(object sender, EventArgs e)
        {
            btnCurrencyExchange_Click(sender, e);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            GlobalUser.CurrentUser = clsBusinessUsers.Find(0);
            this.Close();
        }

        

    }
}
