using DataAdapterEx.DBUtils;
using DataAdapterEx.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterEx.Views
{
    public partial class MedicationHistory : Form
    {
        private int _patientId;
        private string _patientName;
        private int _patientAge;
        private int _medicationId = -1;
        private bool _isAddMode = false;

        public MedicationHistory(int patientId, string patientName, int patientAge)
        {
            InitializeComponent();
            _patientId = patientId;
            _patientName = patientName;
            _patientAge = patientAge;
            SetEditMode(false);
            if (_patientId != 0)
            {
                LoadMedication();
            }
            dgvMedication.AllowUserToAddRows = false;
        }

        // ============================
        // LOAD Medication
        // ============================
        private void LoadMedication()
        {
            using (MySqlConnection conn = DBUtilsMedicationHistory.MakeConnection())
            {
                DataTable dt = DBUtilsMedicationHistory.GetByPatientId(conn, _patientId);
                dgvMedication.DataSource = dt;
                dgvMedication.Columns["MedicationID"].Visible = false;
                dgvMedication.Columns["PatientID"].Visible = false;
                dgvMedication.Columns["MedicationAmt"].Visible = false;
                dgvMedication.Columns["MedicationUnit"].Visible = false;
                dgvMedication.Columns["Instructions"].Visible = false;
                dgvMedication.Columns["MedicationStartDate"].Visible = false;
                dgvMedication.Columns["MedicationEndDate"].Visible = false;
                dgvMedication.Columns["PrescriptionHCP"].Visible = false;
                dgvMedication.Columns["deleted"].Visible = false;
            }

            FileLog.Write($"Loaded Medication History record for Patient ID {_patientId} by UserID: {GlobalData.LoggedInUserID}");
            lblPatientHeader.Text = $"{_patientName} | Age: {_patientAge} ";
            SetEditMode(false);
        }

        // ============================
        // GRID SELECTION
        // ============================
        private void dgvMedication_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedication.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvMedication.SelectedRows[0];
            _medicationId = Convert.ToInt32(row.Cells["MedicationID"].Value);

            txtMedication.Text = row.Cells["Medication"].Value.ToString();
            txtAmount.Text = row.Cells["MedicationAmt"].Value.ToString();
            txtUnit.Text = row.Cells["MedicationUnit"].Value.ToString();
            txtInstructions.Text = row.Cells["Instructions"].Value.ToString();
            txtStartDate.Text = row.Cells["MedicationStartDate"].Value.ToString();
            txtEndDate.Text = row.Cells["MedicationEndDate"].Value.ToString();
            txtHCP.Text = row.Cells["PrescriptionHCP"].Value.ToString();

            SetEditMode(false);
        }

        // ============================
        // ADD
        // ============================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FileLog.Write($"Entered Add mode on Medication History form for Patient ID {_patientId} by UserID: {GlobalData.LoggedInUserID}");
            _isAddMode = true;
            _medicationId = -1;
            ClearFields();
            SetEditMode(true);
        }

        // ============================
        // MODIFY
        // ============================
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (_medicationId == -1)
            {
                MessageBox.Show("Select a patient record first.");
                return;
            }

            FileLog.Write($"Entered Modify mode on Medication History form for Patient ID {_patientId} by UserID: {GlobalData.LoggedInUserID}");
            _isAddMode = false;
            SetEditMode(true);
        }

        // ============================
        // SAVE
        // ============================
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtilsMedicationHistory.MakeConnection())
            {
                if (_isAddMode)
                {
                    DBUtilsMedicationHistory.InsertMedication(
                        conn,
                        _patientId,
                        txtMedication.Text,
                        txtAmount.Text,
                        txtUnit.Text,
                        txtInstructions.Text,
                        txtStartDate.Text,
                        txtEndDate.Text,
                        txtHCP.Text
                    );
                }
                else
                {
                    DBUtilsMedicationHistory.UpdateMedication(
                        conn,
                        _medicationId,
                        txtMedication.Text,
                        txtAmount.Text,
                        txtUnit.Text,
                        txtInstructions.Text,
                        txtStartDate.Text,
                        txtEndDate.Text,
                        txtHCP.Text
                    );
                }
            }

            FileLog.Write($"Saved Medication History record for Patient ID {_patientId} by UserID: {GlobalData.LoggedInUserID}");
            ClearFields();
            LoadMedication();
        }

        // ============================
        // DELETE + FileLog integration by JN
        // ============================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_medicationId == -1)
            {
                MessageBox.Show("Select a patient record first.");
                return;
            }

            if (MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (MySqlConnection conn = DBUtilsMedicationHistory.MakeConnection())
            {
                DBUtilsMedicationHistory.DeleteMedication(conn, _medicationId);
            }

            FileLog.Write($"Deleted Medication History record for Patient ID {_patientId} by UserID: {GlobalData.LoggedInUserID}");
            LoadMedication();
        }

        // ============================
        // UNDO + FileLog integration by JN
        // ============================
        private void btnUndo_Click(object sender, EventArgs e)
        {
            FileLog.Write($"Undid changes on Medication History form for Patient ID {_patientId} by UserID: {GlobalData.LoggedInUserID}");
            LoadMedication();
        }

        // ============================
        // UI STATE
        // ============================
        private void SetEditMode(bool enabled)
        {
            groupBoxMedication.Enabled = enabled;

            btnSave.Enabled = enabled;
            btnUndo.Enabled = enabled;

            btnAdd.Enabled = !enabled;
            btnModify.Enabled = !enabled;
            btnDelete.Enabled = !enabled;
        }

        // ============================
        // CLEAR FIELDS
        // ============================
        private void ClearFields()
        {
            txtMedication.Clear();
            txtAmount.Clear();
            txtUnit.Clear();
            txtInstructions.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtHCP.Clear();
        }

        private bool PatientExists(int patientId)
        {
            using (MySqlConnection conn = DBUtilsMedicationHistory.MakeConnection())
            {
                string query = "SELECT COUNT(*) FROM patientdemographics WHERE PatientID = @id AND deleted = 0";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", patientId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void btnPatientIDSelect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientIDSelect.Text))
            {
                MessageBox.Show("Please enter a Patient ID.");
                return;
            }
            else
            {
                try
                {
                    _patientId = Convert.ToInt32(txtPatientIDSelect.Text);
                    GlobalData.CurrentPatientID = _patientId;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Patient ID format. Please enter a valid integer.");
                    return;
                }
                if (!PatientExists(_patientId))
                {
                    MessageBox.Show("No patient found with that ID.");
                    return;
                }
            }

            DBUtilsMedicationHistory.LoadPatientInfo(_patientId);

            _patientName = GlobalData.CurrentPatientFullName;
            _patientAge = GlobalData.CurrentPatientAge;

            ClearFields();
            LoadMedication();
        }

        // ============================
        // NAVIGATION + FileLog integration by JN
        // ============================
        private void btnSelectPatient_Click(object sender, EventArgs e)
        {
            FileLog.Write($"Opened Patient Selection Form by by UserID: {GlobalData.LoggedInUserID}");

            Form form = new SelectPatientForm();
            form.Show();
            this.Hide();
        }

        private void btnImmunizations_Click(object sender, EventArgs e)
        {
            FileLog.Write($"Opened Immunization History Form for Patient ID {GlobalData.CurrentPatientID} by UserID: {GlobalData.LoggedInUserID}");

            Form form = new ImmunizationHistoryForm(GlobalData.CurrentPatientID);
            form.Show();
            this.Hide();
        }

        private void btnGenMedHistory_Click(object sender, EventArgs e)
        {
            FileLog.Write($"Opened General Medical History Form for Patient ID {GlobalData.CurrentPatientID} by UserID: {GlobalData.LoggedInUserID}");

            Form form = new Views.GeneralMedicalHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
            form.Show();
            this.Hide();
        }

        private void btnDemographics_Click(object sender, EventArgs e)
        {
            FileLog.Write($"Opened Patient Demographics Form for Patient ID {GlobalData.CurrentPatientID} by UserID: {GlobalData.LoggedInUserID}");

            Form form = new PatientDemographicsForm(GlobalData.CurrentPatientID);
            form.Show();
            this.Hide();
        }
    }
}
