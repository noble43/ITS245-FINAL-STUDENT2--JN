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
        public static MySqlConnection MakeConnection()
        {
            string connStr = "server=127.0.0.1;user=root;" +
                "database=ehr;port=3306;password=password";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public static DataTable GetAllPatients(MySqlConnection conn)
        {
            string sql = "SELECT PID, LastName, FirstName, Age " +
                "FROM patient WHERE deleted=false";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetAllPatientsSP(
            MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand(
                "GetAllPatientsSP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetPatientById(MySqlConnection conn, int pid)
        {
            string sql = "SELECT PID, LastName, FirstName, Age " +
                "FROM patient WHERE PID=@pid AND deleted=false";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@pid", pid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void InsertPatientSP(MySqlConnection conn, 
            Patient patient)
        {
            MySqlCommand cmd = new MySqlCommand(
                "InsertPatientSP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", patient.FirstName);
            cmd.Parameters.AddWithValue("@lname", patient.LastName);
            cmd.Parameters.AddWithValue("@age", patient.Age);
            cmd.ExecuteNonQuery();
        }


    }
}
