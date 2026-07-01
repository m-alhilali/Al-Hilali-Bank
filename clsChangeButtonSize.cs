using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Al_Hilali_Bank
{
    internal class clsChangeButtonSize
    {
        public static void RaisButton(object sender)
        {

            if (sender is Guna2Button btn)
            {
                btn.Size = new System.Drawing.Size(btn.Width + 1, btn.Height + 1);
            }
        }
        public static void ResetButton(object sender)
        {

            if (sender is Guna2Button btn)
            {
                btn.Size = new System.Drawing.Size(btn.Width - 1, btn.Height - 1);
            }
        }
    }
}
