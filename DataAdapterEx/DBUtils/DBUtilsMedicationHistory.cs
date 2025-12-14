using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.DBUtils
{
    public static class DBUtilsMedicationHistory
    {
        public static MySqlConnection MakeConnection()
        {
            //Home Password: toor
            string connStr = "server=localhost;uid=root;pwd=toor;database=patientdb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public static DataTable GetByPatientId(MySqlConnection conn, int patientId)
        {
            string sql =
                "SELECT * FROM patientmedications " +
                "WHERE PatientID=@pid AND deleted=false";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@pid", patientId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void InsertMedication(
            MySqlConnection conn,
            int patientId,
            string medication,
            string amount,
            string unit,
            string instructions,
            string StartDate,
            string EndDate,
            string HCP)
        {
            string sql =
                "INSERT INTO patientmedications " +
                "(PatientID, Medication, MedicationAmt, MedicationUnit, Instructions, MedicationStartDate, MedicationEndDate, PrescriptionHCP) " +
                "VALUES (@pid, @med, @amt, @unit, @inst, @start, @end, @hcp)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@med", medication);
            cmd.Parameters.AddWithValue("@amt", amount); 
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@inst", instructions);
            cmd.Parameters.AddWithValue("@start", StartDate);
            cmd.Parameters.AddWithValue("@end", EndDate);
            cmd.Parameters.AddWithValue("@hcp", HCP);
            cmd.ExecuteNonQuery();
        }

        public static void LoadPatientInfo(int patientId)
        {
            using (MySqlConnection conn = MakeConnection())
            {
                string query = @"SELECT PtFirstName, PtLastName, PtMiddleInitial, DOB 
                         FROM patientdemographics 
                         WHERE PatientID = @id AND deleted = 0";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", patientId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string first = reader["PtFirstName"]?.ToString();
                            string last = reader["PtLastName"]?.ToString();
                            string mi = reader["PtMiddleInitial"]?.ToString();
                            DateTime dob = Convert.ToDateTime(reader["DOB"]);

                            GlobalData.CurrentPatientFullName =
                                $"{last}, {first} {mi}".Trim();

                            GlobalData.CurrentPatientDOB = dob;
                            GlobalData.CurrentPatientAge = CalculateAge(dob);
                        }
                        else
                        {
                            throw new Exception("Patient not found in database.");
                        }
                    }
                }
            }
        }

        private static int CalculateAge(DateTime dob)
        {
            int age = DateTime.Today.Year - dob.Year;
            if (dob > DateTime.Today.AddYears(-age))
                age--;
            return age;
        }

        public static void UpdateMedication(
            MySqlConnection conn,
            int medicationID,
            string medication,
            string amount,
            string unit,
            string instructions,
            string startDate,
            string endDate,
            string HCP)
        {
            string sql =
                "UPDATE generalmedicalhistory SET " +
                "Medication=@med, MedicationAmt=@amt, MedicationUnit=@unit, " +
                "Instructions=@inst, MedicationStartDate=@start, MedicationEndDate=@end, PrescriptionHCP=@hcp " +
                "WHERE MedicationID=@mid";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@mid", medicationID);

            cmd.Parameters.AddWithValue("@med", medication);
            cmd.Parameters.AddWithValue("@amt", amount);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@inst", instructions);

            cmd.Parameters.AddWithValue("@start", startDate);
            cmd.Parameters.AddWithValue("@end", endDate);
            cmd.Parameters.AddWithValue("@hcp", HCP);

            cmd.ExecuteNonQuery();
        }

        public static void DeleteMedication(MySqlConnection conn, int id)
        {
            string sql =
                "UPDATE patientmedications SET deleted=true " +
                "WHERE MedicationID=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
