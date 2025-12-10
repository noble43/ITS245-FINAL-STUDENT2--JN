using DataAdapterEx.DBUtils;
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
    public partial class MedicationHistoryForm : Form
    {
        private int _patientId;
        private string _patientName;
        private int _patientAge;
        private int _medicationId = -1;
        private bool _isAddMode = false;

        public MedicationHistoryForm(int patientId, string patientName, int patientAge)
        {
            InitializeComponent();
            _patientId = patientId;
            _patientName = patientName;
            _patientAge = patientAge;
            SetEditMode(false);
            if (_patientId != 0)
            {
                LoadMedications();
            }
            dgvMedications.AllowUserToAddRows = false;
        }

        // =========================
        // LOAD DATA
        // =========================
        private void LoadMedications()
        {
            using (MySqlConnection conn = DBUtilsMedicationHistory.MakeConnection())
            {
                DataTable dt = DBUtilsMedicationHistory.GetByPatientId(conn, _patientId);
                dgvMedications.DataSource = dt;
            }
            //lblPatientHeader.Text = $"{_patientName} | Age: {_patientAge} ";
            SetEditMode(false);
        }

        // =========================
        // MODE CONTROL
        // =========================
        private void SetEditMode(bool enabled)
        {
            groupBoxMedications.Enabled = enabled;

            btnSave.Enabled = enabled;
            btnUndo.Enabled = enabled;

            btnAdd.Enabled = !enabled;
            //btnModify.Enabled = !enabled;
            btnDelete.Enabled = !enabled;
        }

        // =========================
        // GRID SELECTION
        // =========================
        private void dgvMedications_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedications.SelectedRows.Count > 0)
            {
                txtMedication.Text =
                    dgvMedications.SelectedRows[0].Cells["Medication"].Value.ToString();

                txtAmount.Text =
                    dgvMedications.SelectedRows[0].Cells["MedicationAmt"].Value.ToString();

                txtUnit.Text =
                    dgvMedications.SelectedRows[0].Cells["MedicationUnit"].Value.ToString();
                
                txtInstructions.Text =
                    dgvMedications.SelectedRows[0].Cells["Instructions"].Value.ToString();

                txtMedicationStartDate.Text =
                    dgvMedications.SelectedRows[0].Cells["MedicationStartDate"].Value.ToString();

                txtMedicationEndDate.Text =
                    dgvMedications.SelectedRows[0].Cells["MedicationEndDate"].Value.ToString();

                txtPrescriptionHCP.Text =
                    dgvMedications.SelectedRows[0].Cells["PrescriptionHCP"].Value.ToString();
            }
        }

        // =========================
        // BUTTON EVENTS
        // =========================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _isAddMode = true;
            _medicationId = -1;
            ClearFields();
            SetEditMode(true);
        }

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
                        txtMedicationStartDate.Text,
                        txtMedicationEndDate.Text,
                        txtPrescriptionHCP.Text
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
                        txtMedicationStartDate.Text,
                        txtMedicationEndDate.Text,
                        txtPrescriptionHCP.Text
                    );
                }
            }
            ClearFields();
            LoadMedications();
        }


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

            LoadMedications();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            LoadMedications();
        }

        // =========================
        // HELPERS
        // =========================
        private void ClearFields()
        {
            txtMedication.Clear();
            txtAmount.Clear();
            txtUnit.Clear();
            txtInstructions.Clear();
            txtMedicationStartDate.Clear();
            txtMedicationEndDate.Clear();
            txtPrescriptionHCP.Clear();
        }

        private bool PatientExists(int patientId)
        {
            using (MySqlConnection conn = DBUtilsGeneralMedicalHistory.MakeConnection())
            {
                string query = "SELECT COUNT(*) FROM patientdemographics WHERE PatientID = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", patientId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        //private void btnPatientIDSelect_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtPatientIDSelect.Text))
        //    {
        //        MessageBox.Show("Please enter a Patient ID.");
        //        return;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            _patientId = Convert.ToInt32(txtPatientIDSelect.Text);
        //            GlobalData.CurrentPatientID = _patientId;
        //        }
        //        catch (FormatException)
        //        {
        //            MessageBox.Show("Invalid Patient ID format. Please enter a valid integer.");
        //            return;
        //        }
        //        if (!PatientExists(_patientId))
        //        {
        //            MessageBox.Show("No patient found with that ID.");
        //            return;
        //        }
        //    }

        //    DBUtilsGeneralMedicalHistory.LoadPatientInfo(_patientId);

        //    _patientName = GlobalData.CurrentPatientFullName;
        //    _patientAge = GlobalData.CurrentPatientAge;

        //    ClearFields();
        //    LoadMedications();
        //}

        // =========================
        // NAVIGATION
        // =========================
        private void btnSelectPatient_Click(object sender, EventArgs e)
        {
            Form form = new Form1(this);
            this.Hide();
        }

        private void btnImmunizations_Click(object sender, EventArgs e)
        {
            Form form = new Form1(this);
            this.Hide();
        }

        private void btnMedications_Click(object sender, EventArgs e)
        {
            Form form = new Form1(this);
            this.Hide();
        }

        private void btnDemographics_Click(object sender, EventArgs e)
        {
            Form form = new Form1(this);
            this.Hide();
        }
    }
}
