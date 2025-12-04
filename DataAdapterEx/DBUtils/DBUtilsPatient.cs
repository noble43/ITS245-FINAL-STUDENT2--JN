using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAdapterEx.Models;
using MySql.Data.MySqlClient;

namespace DataAdapterEx.DBUtils
{
    public static class DBUtilsPatient
    {
        // ✅ DO NOT auto-open connection (prevents "already open" errors)
        public static MySqlConnection MakeConnection()
        {
            string connStr = "server=localhost;uid=root;pwd=toor;database=patientdb;";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }

        // ✅ STORED PROCEDURE: GetAllPatientsSP
        public static DataTable GetAllPatientsSP(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand("GetAllPatientsSP", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // ✅ STORED PROCEDURE: GetPatientByIdSP
        public static DataTable GetPatientByIdSP(MySqlConnection conn, int pid)
        {
            MySqlCommand cmd = new MySqlCommand("GetPatientByIdSP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // ✅ STORED PROCEDURE: InsertPatientSP
        public static void InsertPatientSP(MySqlConnection conn, Patient patient)
        {
            MySqlCommand cmd = new MySqlCommand("InsertPatientSP", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fname", patient.FirstName);
            cmd.Parameters.AddWithValue("@lname", patient.LastName);
            cmd.Parameters.AddWithValue("@age", patient.Age);

            cmd.ExecuteNonQuery();
        }
    }
}
