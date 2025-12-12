using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.DBUtils
{
    public static class DBUtilsGeneralMedicalHistory
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
                "SELECT * FROM generalmedicalhistory " +
                "WHERE PatientID=@pid AND deleted=false";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@pid", patientId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void LoadPatientInfo(int patientId)
        {
            using (MySqlConnection conn = MakeConnection())
            {
                string query = @"SELECT PtFirstName, PtLastName, PtMiddleInitial, DOB 
                         FROM patientdemographics 
                         WHERE PatientID = @id";

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


        public static void UpdateHistory(
            MySqlConnection conn,
            int historyId,
            string maritalStatus,
            string education,
            string behavioralHistory,
            string tobacco,
            string tobaccoQuantity,
            string tobaccoDuration,
            string alcohol,
            string alcoholQuantity,
            string alcoholDuration,
            string drug,
            string drugType,
            string drugDuration,
            string dietary,
            string bloodType,
            string rh,
            int numberOfChildren,
            string lmpStatus,
            bool mensesMonthlyYes,
            bool mensesMonthlyNo,
            string mensesFreq,
            string medicalHistoryNotes,
            string hxObtainedBy)
        {
            string sql =
                "UPDATE generalmedicalhistory SET " +
                "MaritalStatus=@ms, Education=@edu, BehavioralHistory=@bh, " +
                "Tobacco=@tob, TobaccoQuantity=@tobQty, TobaccoDuraton=@tobDur, " +
                "Alcohol=@alc, AlcoholQuantity=@alcQty, AlcoholDuration=@alcDur, " +
                "Drug=@drug, DrugType=@drugType, DrugDuration=@drugDur, " +
                "Dietary=@diet, BloodType=@bt, Rh=@rh, NumberOfChildren=@children, LMPStatus=@lmp, " +
                "MensesMonthlyYes=@mYes, MensesMonthlyNo=@mNo, MensesFreq=@mFreq, " +
                "MedicalHistoryNotes=@notes, HxObtainedBy=@hxBy " +
                "WHERE GeneralMedicalHistoryID=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", historyId);

            cmd.Parameters.AddWithValue("@ms", maritalStatus);
            cmd.Parameters.AddWithValue("@edu", education);
            cmd.Parameters.AddWithValue("@bh", behavioralHistory);

            cmd.Parameters.AddWithValue("@tob", tobacco);
            cmd.Parameters.AddWithValue("@tobQty", tobaccoQuantity);
            cmd.Parameters.AddWithValue("@tobDur", tobaccoDuration);

            cmd.Parameters.AddWithValue("@alc", alcohol);
            cmd.Parameters.AddWithValue("@alcQty", alcoholQuantity);
            cmd.Parameters.AddWithValue("@alcDur", alcoholDuration);

            cmd.Parameters.AddWithValue("@drug", drug);
            cmd.Parameters.AddWithValue("@drugType", drugType);
            cmd.Parameters.AddWithValue("@drugDur", drugDuration);

            cmd.Parameters.AddWithValue("@diet", dietary);
            cmd.Parameters.AddWithValue("@bt", bloodType);
            cmd.Parameters.AddWithValue("@rh", rh);
            cmd.Parameters.AddWithValue("@children", numberOfChildren);
            cmd.Parameters.AddWithValue("@lmp", lmpStatus);

            cmd.Parameters.AddWithValue("@mYes", mensesMonthlyYes);
            cmd.Parameters.AddWithValue("@mNo", mensesMonthlyNo);
            cmd.Parameters.AddWithValue("@mFreq", mensesFreq);

            cmd.Parameters.AddWithValue("@notes", medicalHistoryNotes);
            cmd.Parameters.AddWithValue("@hxBy", hxObtainedBy);

            cmd.ExecuteNonQuery();
        }

        public static void InsertHistory(
            MySqlConnection conn,
            int patientId,
            string maritalStatus,
            string education,
            string behavioralHistory,
            string tobacco,
            string tobaccoQuantity,
            string tobaccoDuration,
            string alcohol,
            string alcoholQuantity,
            string alcoholDuration,
            string drug,
            string drugType,
            string drugDuration,
            string dietary,
            string bloodType,
            string rh,
            int numberOfChildren,
            string lmpStatus,
            bool mensesMonthlyYes,
            bool mensesMonthlyNo,
            string mensesFreq,
            string medicalHistoryNotes,
            string hxObtainedBy)
        {
            string sql =
                "INSERT INTO generalmedicalhistory (" +
                "PatientID, MaritalStatus, Education, BehavioralHistory, " +
                "Tobacco, TobaccoQuantity, TobaccoDuraton, " +
                "Alcohol, AlcoholQuantity, AlcoholDuration, " +
                "Drug, DrugType, DrugDuration, " +
                "Dietary, BloodType, Rh, NumberOfChildren, LMPStatus, " +
                "MensesMonthlyYes, MensesMonthlyNo, MensesFreq, " +
                "MedicalHistoryNotes, HxObtainedBy, deleted" +
                ") VALUES (" +
                "@pid, @ms, @edu, @bh, " +
                "@tob, @tobQty, @tobDur, " +
                "@alc, @alcQty, @alcDur, " +
                "@drug, @drugType, @drugDur, " +
                "@diet, @bt, @rh, @children, @lmp, " +
                "@mYes, @mNo, @mFreq, " +
                "@notes, @hxBy, false" +
                ")";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@ms", maritalStatus);
            cmd.Parameters.AddWithValue("@edu", education);
            cmd.Parameters.AddWithValue("@bh", behavioralHistory);

            cmd.Parameters.AddWithValue("@tob", tobacco);
            cmd.Parameters.AddWithValue("@tobQty", tobaccoQuantity);
            cmd.Parameters.AddWithValue("@tobDur", tobaccoDuration);

            cmd.Parameters.AddWithValue("@alc", alcohol);
            cmd.Parameters.AddWithValue("@alcQty", alcoholQuantity);
            cmd.Parameters.AddWithValue("@alcDur", alcoholDuration);

            cmd.Parameters.AddWithValue("@drug", drug);
            cmd.Parameters.AddWithValue("@drugType", drugType);
            cmd.Parameters.AddWithValue("@drugDur", drugDuration);

            cmd.Parameters.AddWithValue("@diet", dietary);
            cmd.Parameters.AddWithValue("@bt", bloodType);
            cmd.Parameters.AddWithValue("@rh", rh);
            cmd.Parameters.AddWithValue("@children", numberOfChildren);
            cmd.Parameters.AddWithValue("@lmp", lmpStatus);

            cmd.Parameters.AddWithValue("@mYes", mensesMonthlyYes);
            cmd.Parameters.AddWithValue("@mNo", mensesMonthlyNo);
            cmd.Parameters.AddWithValue("@mFreq", mensesFreq);

            cmd.Parameters.AddWithValue("@notes", medicalHistoryNotes);
            cmd.Parameters.AddWithValue("@hxBy", hxObtainedBy);

            cmd.ExecuteNonQuery();
        }

        public static void DeleteHistory(MySqlConnection conn, int id)
        {
            string sql =
                "UPDATE generalmedicalhistory SET deleted=true " +
                "WHERE GeneralMedicalHistoryID=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
