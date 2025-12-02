using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx
{
    public static class GlobalData
    {
        public static int PID { get; set; }
        public static int LoggedInUserID { get; set; } = -1;
        public static string LoggedInUserName { get; set; } = string.Empty;
    }
}
