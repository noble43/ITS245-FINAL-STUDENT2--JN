using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx
{
    public static class GlobalData
    {
        public static int LoggedInUserID { get; set; } = -1;
        public static string LoggedInUserName { get; set; } = string.Empty;
        public static int CurrentPatientID { get; set; }
        public static string CurrentPatientName { get; set; }
        public static DateTime CurrentPatientDOB { get; set; }
    }
}
