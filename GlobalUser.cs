using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Hilali_Bank
{
    internal class GlobalUser
    {
        public static clsBusinessUsers CurrentUser=clsBusinessUsers.Find("","");
    }
}
