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

namespace DataAdapterEx
{
    public partial class SelectPatientForm : Form
    {
        //loads form, writes to log, loads patients into grid
        public SelectPatientForm()
        {
            InitializeComponent();
            FileLog.Write("Opened Select Patient Form");
            LoadPatients();
        }

        // search button click and reloads patients based on search
        private void btn_Search_Click(object sender, EventArgs e)
        {
            FileLog.Write("Searched for: " + txt_Search.Text.Trim());
            LoadPatients(txt_Search.Text.Trim());
        }

        // Loads patient list from database
        private void LoadPatients(string search = "")
        {
            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT PatientID, PtFirstName, PtLastName, PtHomePhone " +
                        "FROM patientdemographics WHERE deleted = 0";

                    // Adds search filter if needed
                    if (!string.IsNullOrEmpty(search))
                    {
                        query += " AND (PatientID LIKE @search OR PtLastName LIKE @search)";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(search))
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt); // fills the datatable

                    dgv_Patients.DataSource = dt; // loads results into grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Opens demographics form for selected patient
        private void btn_OpenDemo_Click(object sender, EventArgs e)
        {
            if (dgv_Patients.CurrentRow != null)
            {
                int patientID = Convert.ToInt32(dgv_Patients.CurrentRow.Cells["PatientID"].Value);

                FileLog.Write("Opened Demographics Form for Patient ID " + patientID);

                PatientDemographicsForm demoForm = new PatientDemographicsForm(patientID);
                demoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }


        private void dgv_Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Opens Demographics Form
        private void btn_Add_Click(object sender, EventArgs e)
        {
            FileLog.Write("Opened Demographics Form to ADD new patient");

            PatientDemographicsForm form = new PatientDemographicsForm();
            form.ShowDialog();

            LoadPatients(); // refreshs list
        }

        //Patient Report button added by JN + FileLog integration
        private void btn_btnPatientReport_Click(object sender, EventArgs e)
        {
            if (dgv_Patients.CurrentRow != null)
            {
                int patientID = Convert.ToInt32(dgv_Patients.CurrentRow.Cells["PatientID"].Value);

                FileLog.Write($"Generated Patient Report for Patient ID {patientID} by {GlobalData.LoggedInUserName}");
                PatientReport report = new PatientReport();
                report.GenerateReport(patientID, GlobalData.LoggedInUserName);
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }

        //Nav buttons added by JN + FileLog integration
        private void btn_btnGenMedHistory_Click(object sender, EventArgs e)
        {
            if (dgv_Patients.CurrentRow != null)
            {
                int patientID = Convert.ToInt32(dgv_Patients.CurrentRow.Cells["PatientID"].Value);
                GlobalData.CurrentPatientID = patientID;

                FileLog.Write($"Opened General Medical History Form for Patient ID {patientID} by {GlobalData.LoggedInUserID}");

                Form form = new GeneralMedicalHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }

        private void btn_btnImmunizations_Click(object sender, EventArgs e)
        {
            if (dgv_Patients.CurrentRow != null)
            {
                int patientID = Convert.ToInt32(dgv_Patients.CurrentRow.Cells["PatientID"].Value);
                GlobalData.CurrentPatientID = patientID;

                FileLog.Write($"Opened Immunizations History Form for Patient ID {patientID} by {GlobalData.LoggedInUserID}");

                Form form = new ImmunizationHistoryForm(patientID);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }

        private void btn_btnMedicationHistory_Click(object sender, EventArgs e)
        {
            if (dgv_Patients.CurrentRow != null)
            {
                int patientID = Convert.ToInt32(dgv_Patients.CurrentRow.Cells["PatientID"].Value);
                GlobalData.CurrentPatientID = patientID;

                FileLog.Write($"Opened Medication History Form for Patient ID {patientID} by {GlobalData.LoggedInUserID}");

                Form form = new MedicationHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }
    }
}
