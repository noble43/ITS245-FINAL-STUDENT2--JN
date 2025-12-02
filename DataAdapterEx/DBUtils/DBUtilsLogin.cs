using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.DBUtils
{
    public class DBUtilsLogin
    {

        public static DataTable AuthenticateUser(MySqlConnection conn, string username, string password)
        {
            DataTable dt = new DataTable();

            string sql = @"SELECT LoginID, UserName 
                           FROM login 
                           WHERE UserName = @uname 
                             AND Password = @pwd 
                             AND Active = 1 
                             AND deleted = 0";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@uname", username);
                cmd.Parameters.AddWithValue("@pwd", password);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
