using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.DBUtils
{
    public static class DBUtilsPatientReport
    {
        public static DataTable GetPatientDemographics(int patientId, MySqlConnection conn)
        {
            string sql = @"SELECT * FROM patientdemographics 
                           WHERE PatientID = @PID AND deleted = 0";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@PID", patientId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetGeneralMedicalHistory(int patientId, MySqlConnection conn)
        {
            string sql = @"SELECT * FROM generalmedicalhistory 
                           WHERE PatientID = @PID AND deleted = 0";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@PID", patientId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetImmunizations(int patientId, MySqlConnection conn)
        {
            string sql = @"SELECT * FROM immunizationshistorytable
                           WHERE PatientID = @PID AND deleted = 0";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@PID", patientId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetMedications(int patientId, MySqlConnection conn)
        {
            string sql = @"SELECT * FROM patientmedications
                           WHERE PatientID = @PID AND deleted = 0";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@PID", patientId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
