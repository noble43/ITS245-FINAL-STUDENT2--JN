using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterEx.DBUtils
{
    public static class DBUtilsGeneralMedicalHistory
    {
        #region SQL Statements

        private const string SQL_SelectByPatientID = @"
            SELECT *
            FROM generalmedicalhistory
            WHERE PatientID = @PatientID AND deleted = 0;
        ";

        private const string SQL_SelectByID = @"
            SELECT *
            FROM generalmedicalhistory
            WHERE GeneralMedicalHistoryID = @GeneralMedicalHistoryID AND deleted = 0;
        ";

        private const string SQL_Insert = @"
            INSERT INTO generalmedicalhistory
            (
                PatientID, MaritalStatus, Education, BehavioralHistory, Tobacco,
                TobaccoQuantity, TobaccoDuraton, Alcohol, AlcoholQuantity, AlcoholDuration,
                Drug, DrugType, DrugDuration, Dietary, BloodType, Rh,
                NumberOfChildren, LMPStatus, MensesMonthlyYes, MensesMonthlyNo, MensesFreq,
                MedicalHistoryNotes, HxObtainedBy, DateEntered, deleted
            )
            VALUES
            (
                @PatientID, @MaritalStatus, @Education, @BehavioralHistory, @Tobacco,
                @TobaccoQuantity, @TobaccoDuraton, @Alcohol, @AlcoholQuantity, @AlcoholDuration,
                @Drug, @DrugType, @DrugDuration, @Dietary, @BloodType, @Rh,
                @NumberOfChildren, @LMPStatus, @MensesMonthlyYes, @MensesMonthlyNo, @MensesFreq,
                @MedicalHistoryNotes, @HxObtainedBy, @DateEntered, @deleted
            );
            SELECT LAST_INSERT_ID();
        ";

        private const string SQL_Update = @"
            UPDATE generalmedicalhistory SET
                PatientID = @PatientID,
                MaritalStatus = @MaritalStatus,
                Education = @Education,
                BehavioralHistory = @BehavioralHistory,
                Tobacco = @Tobacco,
                TobaccoQuantity = @TobaccoQuantity,
                TobaccoDuraton = @TobaccoDuraton,
                Alcohol = @Alcohol,
                AlcoholQuantity = @AlcoholQuantity,
                AlcoholDuration = @AlcoholDuration,
                Drug = @Drug,
                DrugType = @DrugType,
                DrugDuration = @DrugDuration,
                Dietary = @Dietary,
                BloodType = @BloodType,
                Rh = @Rh,
                NumberOfChildren = @NumberOfChildren,
                LMPStatus = @LMPStatus,
                MensesMonthlyYes = @MensesMonthlyYes,
                MensesMonthlyNo = @MensesMonthlyNo,
                MensesFreq = @MensesFreq,
                MedicalHistoryNotes = @MedicalHistoryNotes,
                HxObtainedBy = @HxObtainedBy,
                DateEntered = @DateEntered
            WHERE GeneralMedicalHistoryID = @GeneralMedicalHistoryID;
        ";

        private const string SQL_SoftDelete = @"
            UPDATE generalmedicalhistory
            SET deleted = 1
            WHERE GeneralMedicalHistoryID = @GeneralMedicalHistoryID;
        ";

        #endregion

        #region Read Methods

        /// <summary>
        /// Returns a DataTable containing general medical history rows for a patient (most apps expect 0..1 rows).
        /// </summary>
        public static DataTable GetGeneralMedHxByPatientID(MySqlConnection conn, int patientID)
        {
            if (conn == null) throw new ArgumentNullException(nameof(conn));

            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(SQL_SelectByPatientID, conn))
            {
                cmd.Parameters.Add("@PatientID", MySqlDbType.Int32).Value = patientID;
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Returns a DataTable with a single general medical history row found by GeneralMedicalHistoryID.
        /// </summary>
        public static DataTable GetGeneralMedHxByID(MySqlConnection conn, int generalMedHxID)
        {
            if (conn == null) throw new ArgumentNullException(nameof(conn));

            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(SQL_SelectByID, conn))
            {
                cmd.Parameters.Add("@GeneralMedicalHistoryID", MySqlDbType.Int32).Value = generalMedHxID;
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        #endregion

        #region Insert / Update / Delete

        /// <summary>
        /// Inserts a new general medical history row. Returns the newly inserted GeneralMedicalHistoryID.
        /// Note: pass DateTime.Now for DateEntered if you want current date/time saved.
        /// </summary>
        public static int InsertGeneralMedHx(
            MySqlConnection conn,
            int patientID,
            string maritalStatus,
            string education,
            string behavioralHistory,
            string tobacco,
            string tobaccoQuantity,
            string tobaccoDuraton,
            string alcohol,
            string alcoholQuantity,
            string alcoholDuration,
            string drug,
            string drugType,
            string drugDuration,
            string dietary,
            string bloodType,
            string rh,
            int? numberOfChildren,
            string lmpStatus,
            bool mensesMonthlyYes,
            bool mensesMonthlyNo,
            string mensesFreq,
            string medicalHistoryNotes,
            string hxObtainedBy,
            DateTime? dateEntered = null
            )
        {
            if (conn == null) throw new ArgumentNullException(nameof(conn));

            using (MySqlCommand cmd = new MySqlCommand(SQL_Insert, conn))
            {
                cmd.Parameters.Add("@PatientID", MySqlDbType.Int32).Value = patientID;
                cmd.Parameters.Add("@MaritalStatus", MySqlDbType.VarChar).Value = (object)maritalStatus ?? DBNull.Value;
                cmd.Parameters.Add("@Education", MySqlDbType.VarChar).Value = (object)education ?? DBNull.Value;
                cmd.Parameters.Add("@BehavioralHistory", MySqlDbType.VarChar).Value = (object)behavioralHistory ?? DBNull.Value;
                cmd.Parameters.Add("@Tobacco", MySqlDbType.VarChar).Value = (object)tobacco ?? DBNull.Value;
                cmd.Parameters.Add("@TobaccoQuantity", MySqlDbType.VarChar).Value = (object)tobaccoQuantity ?? DBNull.Value;
                cmd.Parameters.Add("@TobaccoDuraton", MySqlDbType.VarChar).Value = (object)tobaccoDuraton ?? DBNull.Value;
                cmd.Parameters.Add("@Alcohol", MySqlDbType.VarChar).Value = (object)alcohol ?? DBNull.Value;
                cmd.Parameters.Add("@AlcoholQuantity", MySqlDbType.VarChar).Value = (object)alcoholQuantity ?? DBNull.Value;
                cmd.Parameters.Add("@AlcoholDuration", MySqlDbType.VarChar).Value = (object)alcoholDuration ?? DBNull.Value;
                cmd.Parameters.Add("@Drug", MySqlDbType.VarChar).Value = (object)drug ?? DBNull.Value;
                cmd.Parameters.Add("@DrugType", MySqlDbType.VarChar).Value = (object)drugType ?? DBNull.Value;
                cmd.Parameters.Add("@DrugDuration", MySqlDbType.VarChar).Value = (object)drugDuration ?? DBNull.Value;
                cmd.Parameters.Add("@Dietary", MySqlDbType.VarChar).Value = (object)dietary ?? DBNull.Value;
                cmd.Parameters.Add("@BloodType", MySqlDbType.VarChar).Value = (object)bloodType ?? DBNull.Value;
                cmd.Parameters.Add("@Rh", MySqlDbType.VarChar).Value = (object)rh ?? DBNull.Value;
                cmd.Parameters.Add("@NumberOfChildren", MySqlDbType.Int32).Value = (object)numberOfChildren ?? DBNull.Value;
                cmd.Parameters.Add("@LMPStatus", MySqlDbType.VarChar).Value = (object)lmpStatus ?? DBNull.Value;
                cmd.Parameters.Add("@MensesMonthlyYes", MySqlDbType.Bit).Value = mensesMonthlyYes ? 1 : 0;
                cmd.Parameters.Add("@MensesMonthlyNo", MySqlDbType.Bit).Value = mensesMonthlyNo ? 1 : 0;
                cmd.Parameters.Add("@MensesFreq", MySqlDbType.VarChar).Value = (object)mensesFreq ?? DBNull.Value;
                cmd.Parameters.Add("@MedicalHistoryNotes", MySqlDbType.Text).Value = (object)medicalHistoryNotes ?? DBNull.Value;
                cmd.Parameters.Add("@HxObtainedBy", MySqlDbType.VarChar).Value = (object)hxObtainedBy ?? DBNull.Value;
                cmd.Parameters.Add("@DateEntered", MySqlDbType.DateTime).Value = (object)(dateEntered ?? DateTime.Now) ?? DBNull.Value;
                cmd.Parameters.Add("@deleted", MySqlDbType.Bit).Value = 0;

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int newId))
                {
                    return newId;
                }
                else
                {
                    throw new Exception("InsertGeneralMedHx failed to return new ID.");
                }
            }
        }

        /// <summary>
        /// Updates an existing general medical history record by GeneralMedicalHistoryID.
        /// Returns number of rows affected.
        /// </summary>
        public static int UpdateGeneralMedHx(
            MySqlConnection conn,
            int generalMedicalHistoryID,
            int patientID,
            string maritalStatus,
            string education,
            string behavioralHistory,
            string tobacco,
            string tobaccoQuantity,
            string tobaccoDuraton,
            string alcohol,
            string alcoholQuantity,
            string alcoholDuration,
            string drug,
            string drugType,
            string drugDuration,
            string dietary,
            string bloodType,
            string rh,
            int? numberOfChildren,
            string lmpStatus,
            bool mensesMonthlyYes,
            bool mensesMonthlyNo,
            string mensesFreq,
            string medicalHistoryNotes,
            string hxObtainedBy,
            DateTime? dateEntered = null
            )
        {
            if (conn == null) throw new ArgumentNullException(nameof(conn));

            using (MySqlCommand cmd = new MySqlCommand(SQL_Update, conn))
            {
                cmd.Parameters.Add("@GeneralMedicalHistoryID", MySqlDbType.Int32).Value = generalMedicalHistoryID;
                cmd.Parameters.Add("@PatientID", MySqlDbType.Int32).Value = patientID;
                cmd.Parameters.Add("@MaritalStatus", MySqlDbType.VarChar).Value = (object)maritalStatus ?? DBNull.Value;
                cmd.Parameters.Add("@Education", MySqlDbType.VarChar).Value = (object)education ?? DBNull.Value;
                cmd.Parameters.Add("@BehavioralHistory", MySqlDbType.VarChar).Value = (object)behavioralHistory ?? DBNull.Value;
                cmd.Parameters.Add("@Tobacco", MySqlDbType.VarChar).Value = (object)tobacco ?? DBNull.Value;
                cmd.Parameters.Add("@TobaccoQuantity", MySqlDbType.VarChar).Value = (object)tobaccoQuantity ?? DBNull.Value;
                cmd.Parameters.Add("@TobaccoDuraton", MySqlDbType.VarChar).Value = (object)tobaccoDuraton ?? DBNull.Value;
                cmd.Parameters.Add("@Alcohol", MySqlDbType.VarChar).Value = (object)alcohol ?? DBNull.Value;
                cmd.Parameters.Add("@AlcoholQuantity", MySqlDbType.VarChar).Value = (object)alcoholQuantity ?? DBNull.Value;
                cmd.Parameters.Add("@AlcoholDuration", MySqlDbType.VarChar).Value = (object)alcoholDuration ?? DBNull.Value;
                cmd.Parameters.Add("@Drug", MySqlDbType.VarChar).Value = (object)drug ?? DBNull.Value;
                cmd.Parameters.Add("@DrugType", MySqlDbType.VarChar).Value = (object)drugType ?? DBNull.Value;
                cmd.Parameters.Add("@DrugDuration", MySqlDbType.VarChar).Value = (object)drugDuration ?? DBNull.Value;
                cmd.Parameters.Add("@Dietary", MySqlDbType.VarChar).Value = (object)dietary ?? DBNull.Value;
                cmd.Parameters.Add("@BloodType", MySqlDbType.VarChar).Value = (object)bloodType ?? DBNull.Value;
                cmd.Parameters.Add("@Rh", MySqlDbType.VarChar).Value = (object)rh ?? DBNull.Value;
                cmd.Parameters.Add("@NumberOfChildren", MySqlDbType.Int32).Value = (object)numberOfChildren ?? DBNull.Value;
                cmd.Parameters.Add("@LMPStatus", MySqlDbType.VarChar).Value = (object)lmpStatus ?? DBNull.Value;
                cmd.Parameters.Add("@MensesMonthlyYes", MySqlDbType.Bit).Value = mensesMonthlyYes ? 1 : 0;
                cmd.Parameters.Add("@MensesMonthlyNo", MySqlDbType.Bit).Value = mensesMonthlyNo ? 1 : 0;
                cmd.Parameters.Add("@MensesFreq", MySqlDbType.VarChar).Value = (object)mensesFreq ?? DBNull.Value;
                cmd.Parameters.Add("@MedicalHistoryNotes", MySqlDbType.Text).Value = (object)medicalHistoryNotes ?? DBNull.Value;
                cmd.Parameters.Add("@HxObtainedBy", MySqlDbType.VarChar).Value = (object)hxObtainedBy ?? DBNull.Value;
                cmd.Parameters.Add("@DateEntered", MySqlDbType.DateTime).Value = (object)(dateEntered ?? DateTime.Now) ?? DBNull.Value;

                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Soft-delete a general medical history record by setting deleted = 1.
        /// Returns rows affected.
        /// </summary>
        public static int SoftDeleteGeneralMedHx(MySqlConnection conn, int generalMedicalHistoryID)
        {
            if (conn == null) throw new ArgumentNullException(nameof(conn));

            using (MySqlCommand cmd = new MySqlCommand(SQL_SoftDelete, conn))
            {
                cmd.Parameters.Add("@GeneralMedicalHistoryID", MySqlDbType.Int32).Value = generalMedicalHistoryID;
                return cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}
