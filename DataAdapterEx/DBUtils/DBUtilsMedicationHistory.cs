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
        // ✅ SAME connection format
        public static MySqlConnection MakeConnection()
        {
            string connStr = "server=localhost;uid=root;pwd=toor;database=patientdb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }

        // ✅ SAME DataAdapter → DataTable workflow
        public static DataTable GetByPatientId(MySqlConnection conn, int patientId)
        {
            string sql =
                "SELECT MedicationID, Medication, MedicationAmt, MedicationUnit " +
                "FROM patientmedications " +
                "WHERE PatientID=@pid AND deleted=false";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@pid", patientId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // ✅ INSERT record
        public static void InsertMedication(
            MySqlConnection conn,
            int patientId,
            string medication,
            string amount,
            string unit,
            string instructions)
        {
            string sql =
                "INSERT INTO patientmedications " +
                "(PatientID, Medication, MedicationAmt, MedicationUnit, Instructions) " +
                "VALUES (@pid, @med, @amt, @unit, @inst)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@med", medication);
            cmd.Parameters.AddWithValue("@amt", amount);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@inst", instructions);
            cmd.ExecuteNonQuery();
        }

        // ✅ SOFT DELETE
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
