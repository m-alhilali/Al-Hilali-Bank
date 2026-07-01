using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLayer.clsBusinessUsers;

namespace Al_Hilali_Bank
{
    public partial class frmAddPermissions : Form
    {
        public clsBusinessUsers _Users;
        private int _Permissions;
        private int _IsUpdate;
        enum enPermissions { All=-1 ,Add_Clients = 1, Update_Clients = 2, Active_Mode_Clients = 4, Add_Users = 8, Update_Users = 16, Active_Mode_Users = 32,Exchanges=64,Transactions=128, Transfers = 256 }

        public frmAddPermissions(clsBusinessUsers Users,int IsUpdate)
        {
            InitializeComponent();
            _Users = Users;
            _IsUpdate = IsUpdate;
        }

        private void frmAddPermissions_Load(object sender, EventArgs e)
        {
            if(_IsUpdate==1)
            {
                _Permissions = _Users.Permissions;
                if (_Permissions!=-1)
                {
                   
                    if ((Convert.ToInt32(enPermissions.Add_Clients) & _Permissions)== Convert.ToInt32(enPermissions.Add_Clients))
                    {
                        chAddClients.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Update_Clients) & _Permissions) == Convert.ToInt32(enPermissions.Update_Clients))
                    {
                        cbUpdateClients.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Active_Mode_Clients) & _Permissions) == Convert.ToInt32(enPermissions.Active_Mode_Clients))
                    {
                       cbActiveClients.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Add_Users) & _Permissions) == Convert.ToInt32(enPermissions.Add_Users))
                    {
                        cbAddUsers.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Update_Users) & _Permissions) == Convert.ToInt32(enPermissions.Update_Users))
                    {
                        cbUpdateUsers.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Active_Mode_Users) & _Permissions) == Convert.ToInt32(enPermissions.Active_Mode_Users))
                    {
                        cbActiveUsers.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Exchanges) & _Permissions) == Convert.ToInt32(enPermissions.Exchanges))
                    {
                        cbExchanges.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Transactions) & _Permissions) == Convert.ToInt32(enPermissions.Transactions))
                    {
                        cbTransactions.Checked = true;
                    }
                    if ((Convert.ToInt32(enPermissions.Transfers) & _Permissions) == Convert.ToInt32(enPermissions.Transfers))
                    {
                        cbTransfsrs.Checked = true;
                    }
                    }

                else
                {
                    cbAll.Checked = true;
                }
                }

            }
        private void cbTransactions_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ChangePermissions()
        {
            _Permissions = 0;
            if (!cbAll.Checked)
            {
                foreach (Guna2CheckBox cb in panelAllPermissions.Controls)
                {
                    
                    if (cb.Checked&&cb.Name== "chAddClients")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Add_Clients);
                    }
                    else if (cb.Checked && cb.Name == "cbUpdateClients")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Update_Clients);
                    }
                    else if(cb.Checked && cb.Name == "cbActiveClients")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Active_Mode_Clients);
                    }
                    else if(cb.Checked && cb.Name == "cbAddUsers")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Add_Users);
                    }
                    else if(cb.Checked && cb.Name == "cbUpdateUsers")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Update_Users);
                    }
                    else if(cb.Checked && cb.Name == "cbActiveUsers")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Active_Mode_Users);
                    }
                    else if(cb.Checked && cb.Name == "cbExchanges")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Exchanges);
                    }
                    else if(cb.Checked && cb.Name == "cbTransactions")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Transactions);
                    }
                    else if(cb.Checked && cb.Name == "cbTransfsrs")
                    {
                        _Permissions += Convert.ToInt32(enPermissions.Transfers);
                    }
                   
                }
            }
            else
            {
                _Permissions = -1;
            }

        }
        private void chAll_CheckedChanged(object sender, EventArgs e)
        {

            panelAllPermissions.Enabled = !cbAll.Checked;
            if (!cbAll.Checked)
            {
                foreach (Guna2CheckBox cb in panelAllPermissions.Controls)
                {
                    cb.Checked = cbAll.Checked;
                }
            }
            else if (cbAll.Checked)
            {
                foreach (Guna2CheckBox cb in panelAllPermissions.Controls)
                {
                    cb.Checked = !cbAll.Checked;
                }
            }
            
        }
            
        

        private void chAddClients_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconbtnBack_Click(object sender, EventArgs e)
        {
            ChangePermissions();
            _Users.Permissions= _Permissions;
            this.Close();
        }
    }
}
