using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.DBUtils
{
    public class DBUtilsAllergies
    {
        public static DataTable GetAllergiesById(MySqlConnection conn, int pid)
        {
            string sql = "SELECT AllergyID, allergyName AS Allergy, symptoms " +
                "FROM allergies WHERE patientID=@pid AND deleted=false";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@pid", pid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
