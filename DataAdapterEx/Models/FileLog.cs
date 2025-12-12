using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAdapterEx.Models
{
    internal class FileLog
    {
        // Path to the log file
        private static string logPath = "log.txt";

        // Writes a log entry to the log file
        public static void Write(string message)
        {
            try
            {
                File.AppendAllText(logPath,
                    $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | USER 1 | {message}{Environment.NewLine}");
            }
            catch
            {

            }
        }

    }
}
