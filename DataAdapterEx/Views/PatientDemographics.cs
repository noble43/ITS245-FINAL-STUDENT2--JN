using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DataAdapterEx.DBUtils;
using DataAdapterEx.Models;
using DataAdapterEx.Views;
//Added DataAdapterEx.Views by JN
//AddedDataAdaperEx.Models by JN

namespace DataAdapterEx.Views
{
    public partial class PatientDemographicsForm : Form
    {
        private bool isNew = false;
        private int patientID;
        private string formMode = "VIEW";

        // Runs when form loads
        private void PatientDemographicsForm_Load(object sender, EventArgs e)
        {
            FileLog.Write("Opened Patient Demographics Form");
        }

        // used when editing an existing patient
        public PatientDemographicsForm(int selectedPatientID)
        {
            InitializeComponent();

            isNew = false;
            patientID = selectedPatientID;

            FileLog.Write($"Opened Patient Demographics Form for Patient ID {patientID}");

            LoadPatientData();
            SetMode("VIEW");
        }

        //7 used when adding a new patient
        public PatientDemographicsForm()
        {
            InitializeComponent();

            isNew = true;
            FileLog.Write("Opened Patient Demographics Form to ADD new patient");

            SetMode("ADD");
        }

        // Loads patient data from the database into form fields
        private void LoadPatientData()
        {
            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM patientdemographics WHERE PatientID=@id AND deleted=0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", patientID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_FirstName.Text = reader["PtFirstName"].ToString();
                        txt_LastName.Text = reader["PtLastName"].ToString();
                        txt_Phone.Text = reader["PtHomePhone"].ToString();

                        DateTime dob = DateTime.MinValue;

                        if (reader["DOB"] != DBNull.Value)
                        {
                            dob = Convert.ToDateTime(reader["DOB"]);
                            txt_DateOfBirth.Text = dob.ToString("MM/dd/yyyy");
                        }
                        else txt_DateOfBirth.Text = "";

                        txt_Gender.Text = reader["Gender"].ToString();
                        txt_Address.Text = reader["HomeAddress"].ToString();
                        txt_City.Text = reader["HomeCity"].ToString();
                        txt_State.Text = reader["HomeState/Province/Region"].ToString();
                        txt_Zip.Text = reader["HomeZip"].ToString();
                        txt_Email.Text = reader["EmailAddress"].ToString();

                        // Build header with name & age
                        string first = reader["PtFirstName"].ToString();
                        string last = reader["PtLastName"].ToString();
                        int age = (dob != DateTime.MinValue) ? CalculateAge(dob) : 0;

                        lbl_Header.Text = $"{first} {last}, Age {age}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient: " + ex.Message);
                    FileLog.Write("ERROR loading patient: " + ex.Message);
                }
            }
        }

        // Saves the patient record insert or update
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query;

                if (isNew)
                {
                    // Insert new patient
                    query = @"INSERT INTO patientdemographics 
                        (PtFirstName, PtLastName, PtHomePhone, DOB, Gender, HomeAddress, HomeCity,
                         `HomeState/Province/Region`, HomeZip, EmailAddress)
                        VALUES
                        (@fn, @ln, @phone, @dob, @gender, @addr, @city, @state, @zip, @email)";
                }
                else
                {
                    // Update existing patient
                    query = @"UPDATE patientdemographics SET
                        PtFirstName=@fn,
                        PtLastName=@ln,
                        PtHomePhone=@phone,
                        DOB=@dob,
                        Gender=@gender,
                        HomeAddress=@addr,
                        HomeCity=@city,
                        `HomeState/Province/Region`=@state,
                        HomeZip=@zip,
                        EmailAddress=@email
                        WHERE PatientID=@id";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Shared parameters
                cmd.Parameters.AddWithValue("@fn", txt_FirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@ln", txt_LastName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txt_Phone.Text.Trim());

                // Convert DOB
                DateTime.TryParse(txt_DateOfBirth.Text.Trim(), out DateTime dob);
                cmd.Parameters.AddWithValue("@dob", dob);

                cmd.Parameters.AddWithValue("@gender", txt_Gender.Text.Trim());
                cmd.Parameters.AddWithValue("@addr", txt_Address.Text.Trim());
                cmd.Parameters.AddWithValue("@city", txt_City.Text.Trim());
                cmd.Parameters.AddWithValue("@state", txt_State.Text.Trim());
                cmd.Parameters.AddWithValue("@zip", txt_Zip.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txt_Email.Text.Trim());

                if (!isNew)
                    cmd.Parameters.AddWithValue("@id", patientID);

                cmd.ExecuteNonQuery();

                FileLog.Write(isNew
                    ? $"Added new patient: {txt_FirstName.Text} {txt_LastName.Text}"
                    : $"Updated patient {patientID}");

                MessageBox.Show(isNew ? "Patient added." : "Patient updated.");

                LoadPatientData();
                SetMode("VIEW");
                isNew = false;
            }
        }

        // Ensures required fields are valid before saving
        private bool ValidateFields()
        {
            if (txt_FirstName.Text.Trim() == "")
            {
                MessageBox.Show("First name is required.");
                return false;
            }
            if (txt_LastName.Text.Trim() == "")
            {
                MessageBox.Show("Last name is required.");
                return false;
            }
            if (!DateTime.TryParse(txt_DateOfBirth.Text.Trim(), out _))
            {
                MessageBox.Show("DOB must be a valid date (MM/DD/YYYY).");
                return false;
            }

            return true;
        }

        // enables and disables fields depending on mode
        private void SetMode(string mode)
        {
            formMode = mode;

            bool isEditing = (mode == "EDIT" || mode == "ADD");

            foreach (Control c in Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Enabled = isEditing;
                    tb.BackColor = isEditing ? Color.White : Color.LightGray;
                }
            }

            btn_Add.Enabled = (mode == "VIEW");
            btn_Modify.Enabled = (mode == "VIEW");
            btn_Delete.Enabled = (mode == "VIEW");

            btn_Save.Enabled = isEditing;
            btn_Undo.Enabled = isEditing;

            FileLog.Write($"Form mode changed to {mode}");
        }

        // Clears fields and enables ADD mode
        private void btn_Add_Click(object sender, EventArgs e)
        {
            isNew = true;
            patientID = 0;

            foreach (Control c in Controls)
            {
                if (c is TextBox tb)
                    tb.Text = "";
            }

            FileLog.Write("Clicked ADD on Demographics Form");

            SetMode("ADD");
        }

        // Switches to edit mode
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            isNew = false;
            FileLog.Write($"Clicked MODIFY for patient {patientID}");

            SetMode("EDIT");
        }

        // goes back to previous values and returns to VIEW mode
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            FileLog.Write("Undo clicked — changes reverted");

            LoadPatientData();
            SetMode("VIEW");
        }

        // Marks record as deleted
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE patientdemographics SET deleted=1 WHERE PatientID=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                cmd.ExecuteNonQuery();
            }

            FileLog.Write($"Marked patient {patientID} as deleted");

            MessageBox.Show("Record marked as deleted.");
            this.Close();
        }

        // Closes demographics form
        private void btn_Close_Click(object sender, EventArgs e)
        {
            FileLog.Write("Closed PatientDemographicsForm");
            this.Close();
        }

        // Opens immunization history form for selected patient
        private void btn_OpenImmunization_Click(object sender, EventArgs e)
        {
            if (patientID <= 0)
            {
                MessageBox.Show("No patient selected.");
                return;
            }

            FileLog.Write($"Opened Immunization History Form for PatientID {patientID}");

            ImmunizationHistoryForm immForm = new ImmunizationHistoryForm(patientID);
            immForm.ShowDialog();
        }

        // Opens select patient form
        private void btn_OpenSelectPatient_Click(object sender, EventArgs e)
        {
            FileLog.Write("Opened Select Patient Form from Demographics.");

            SelectPatientForm f = new SelectPatientForm();
            f.Show();
            this.Close();
        }

        // Calculates age from DOB
        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now < dob.AddYears(age)) age--;
            return age;
        }

        // Added Nav buttons by JN
        private void btn_btnMedication_click(object sender, EventArgs e)
        {
            if (patientID <= 0)
            {
                MessageBox.Show("No patient selected.");
                return;
            }

            GlobalData.CurrentPatientID = patientID;
            DBUtilsMedicationHistory.LoadPatientInfo(GlobalData.CurrentPatientID);

            FileLog.Write($"Opened Medication Form for PatientID {patientID} by UserID: {GlobalData.LoggedInUserID}");
            Form form = new MedicationHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
            form.Show();
            this.Hide();

        }
        private void btn_btnGenMedHistory_click(object sender, EventArgs e)
        {
            if (patientID <= 0)
            {
                MessageBox.Show("No patient selected.");
                return;
            }

            GlobalData.CurrentPatientID = patientID;
            DBUtilsGeneralMedicalHistory.LoadPatientInfo(GlobalData.CurrentPatientID);

            FileLog.Write($"Opened General Medical History Form for PatientID {patientID} by UserID: {GlobalData.LoggedInUserID}");
            Form form = new GeneralMedicalHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
            form.Show();
            this.Hide();
        }
    }
}
