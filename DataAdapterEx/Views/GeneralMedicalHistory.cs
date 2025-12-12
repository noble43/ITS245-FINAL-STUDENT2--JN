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
using DataAdapterEx.Models;
using DataAdapterEx.Views;

namespace DataAdapterEx.Views
{
    public partial class GeneralMedicalHistory : Form
    {
        private int _patientId;
        private string _patientName;
        private int _patientAge;
        private int _historyId = -1;
        private bool _isAddMode = false;

        public GeneralMedicalHistory(int patientId, string patientName, int patientAge)
        {
            InitializeComponent();
            _patientId = patientId;
            _patientName = patientName;
            _patientAge = patientAge;
            SetEditMode(false);
            if (_patientId != 0)
            {
                LoadHistory();
            }
            dgvHistory.AllowUserToAddRows = false;
        }

        // ============================
        // LOAD HISTORY
        // ============================
        private void LoadHistory()
        {
            using (MySqlConnection conn = DBUtilsGeneralMedicalHistory.MakeConnection())
            {
                DataTable dt = DBUtilsGeneralMedicalHistory.GetByPatientId(conn, _patientId);
                dgvHistory.DataSource = dt;
                dgvHistory.Columns["GeneralMedicalHistoryID"].Visible = false;
                dgvHistory.Columns["deleted"].Visible = false;
            }
            lblPatientHeader.Text = $"{_patientName} | Age: {_patientAge} ";
            SetEditMode(false);
        }

        // ============================
        // GRID SELECTION
        // ============================
        private void dgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvHistory.SelectedRows[0];
            _historyId = Convert.ToInt32(row.Cells["GeneralMedicalHistoryID"].Value);

            txtMaritalStatus.Text = row.Cells["MaritalStatus"].Value.ToString();
            txtEducation.Text = row.Cells["Education"].Value.ToString();
            txtBehavioral.Text = row.Cells["BehavioralHistory"].Value.ToString();
            txtTobacco.Text = row.Cells["Tobacco"].Value.ToString();
            txtTobaccoQty.Text = row.Cells["TobaccoQuantity"].Value.ToString();
            txtTobaccoDur.Text = row.Cells["TobaccoDuraton"].Value.ToString();
            txtAlcohol.Text = row.Cells["Alcohol"].Value.ToString();
            txtAlcoholQty.Text = row.Cells["AlcoholQuantity"].Value.ToString();
            txtAlcoholDur.Text = row.Cells["AlcoholDuration"].Value.ToString();
            txtDrug.Text = row.Cells["Drug"].Value.ToString();
            txtDrugType.Text = row.Cells["DrugType"].Value.ToString();
            txtDrugDur.Text = row.Cells["DrugDuration"].Value.ToString();
            txtDietary.Text = row.Cells["Dietary"].Value.ToString();
            txtBloodType.Text = row.Cells["BloodType"].Value.ToString();
            txtRh.Text = row.Cells["Rh"].Value.ToString();
            txtNumChildren.Text = row.Cells["NumberOfChildren"].Value.ToString();
            txtLMP.Text = row.Cells["LMPStatus"].Value.ToString();
            chkMensesYes.Checked = Convert.ToBoolean(row.Cells["MensesMonthlyYes"].Value);
            chkMensesNo.Checked = Convert.ToBoolean(row.Cells["MensesMonthlyNo"].Value);
            txtMensesFreq.Text = row.Cells["MensesFreq"].Value.ToString();
            txtNotes.Text = row.Cells["MedicalHistoryNotes"].Value.ToString();
            txtHxBy.Text = row.Cells["HxObtainedBy"].Value.ToString();

            SetEditMode(false);
        }

        // ============================
        // ADD
        // ============================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // CHECK IF PATIENT ALREADY HAS A HISTORY RECORD
            if (PatientHasGeneralHistory(_patientId))
            {
                MessageBox.Show(
                    "This patient already has a General Medical History record.\nOnly one record is allowed.",
                    "Please modify the existing History instead.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop Add operation
            }

            // OTHERWISE, ENTER ADD MODE
            _isAddMode = true;
            _historyId = -1;
            ClearFields();
            SetEditMode(true);
        }

        // ============================
        // MODIFY
        // ============================
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (_historyId == -1)
            {
                MessageBox.Show("Select a patient record first.");
                return;
            }
            _isAddMode = false;
            SetEditMode(true);
        }

        // ============================
        // SAVE
        // ============================
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtilsGeneralMedicalHistory.MakeConnection())
            {
                if (_isAddMode)
                {
                    DBUtilsGeneralMedicalHistory.InsertHistory(
                        conn,
                        _patientId,
                        txtMaritalStatus.Text,
                        txtEducation.Text,
                        txtBehavioral.Text,
                        txtTobacco.Text,
                        txtTobaccoQty.Text,
                        txtTobaccoDur.Text,
                        txtAlcohol.Text,
                        txtAlcoholQty.Text,
                        txtAlcoholDur.Text,
                        txtDrug.Text,
                        txtDrugType.Text,
                        txtDrugDur.Text,
                        txtDietary.Text,
                        txtBloodType.Text,
                        txtRh.Text,
                        string.IsNullOrEmpty(txtNumChildren.Text) ? 0 : Convert.ToInt32(txtNumChildren.Text),
                        txtLMP.Text,
                        chkMensesYes.Checked,
                        chkMensesNo.Checked,
                        txtMensesFreq.Text,
                        txtNotes.Text,
                        txtHxBy.Text
                    );
                }
                else
                {
                    DBUtilsGeneralMedicalHistory.UpdateHistory(
                        conn,
                        _historyId,
                        txtMaritalStatus.Text,
                        txtEducation.Text,
                        txtBehavioral.Text,
                        txtTobacco.Text,
                        txtTobaccoQty.Text,
                        txtTobaccoDur.Text,
                        txtAlcohol.Text,
                        txtAlcoholQty.Text,
                        txtAlcoholDur.Text,
                        txtDrug.Text,
                        txtDrugType.Text,
                        txtDrugDur.Text,
                        txtDietary.Text,
                        txtBloodType.Text,
                        txtRh.Text,
                        string.IsNullOrEmpty(txtNumChildren.Text) ? 0 : Convert.ToInt32(txtNumChildren.Text),
                        txtLMP.Text,
                        chkMensesYes.Checked,
                        chkMensesNo.Checked,
                        txtMensesFreq.Text,
                        txtNotes.Text,
                        txtHxBy.Text
                    );
                }
            }
            ClearFields();
            LoadHistory();
        }

        // ============================
        // DELETE
        // ============================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_historyId == -1)
            {
                MessageBox.Show("Select a patient record first.");
                return;
            }

            if (MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (MySqlConnection conn = DBUtilsGeneralMedicalHistory.MakeConnection())
            {
                DBUtilsGeneralMedicalHistory.DeleteHistory(conn, _historyId);
            }

            LoadHistory();
        }

        // ============================
        // UNDO
        // ============================
        private void btnUndo_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        // ============================
        // UI STATE
        // ============================
        private void SetEditMode(bool enabled)
        {
            groupBoxHistory.Enabled = enabled;

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
            txtMaritalStatus.Clear();
            txtEducation.Clear();
            txtBehavioral.Clear();
            txtTobacco.Clear();
            txtTobaccoQty.Clear();
            txtTobaccoDur.Clear();
            txtAlcohol.Clear();
            txtAlcoholQty.Clear();
            txtAlcoholDur.Clear();
            txtDrug.Clear();
            txtDrugType.Clear();
            txtDrugDur.Clear();
            txtDietary.Clear();
            txtBloodType.Clear();
            txtRh.Clear();
            txtNumChildren.Clear();
            txtLMP.Clear();
            chkMensesYes.Checked = false;
            chkMensesNo.Checked = false;
            txtMensesFreq.Clear();
            txtNotes.Clear();
            txtHxBy.Clear();
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
        private bool PatientHasGeneralHistory(int patientId)
        {
            using (MySqlConnection conn = DBUtilsGeneralMedicalHistory.MakeConnection())
            {
                string sql = "SELECT COUNT(*) FROM general_medical_history WHERE PatientID = @pid AND deleted = 0";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", patientId);
                    conn.Open();
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

            DBUtilsGeneralMedicalHistory.LoadPatientInfo(_patientId);

            _patientName = GlobalData.CurrentPatientFullName;
            _patientAge = GlobalData.CurrentPatientAge;

            ClearFields();
            LoadHistory();
        }

        // ============================
        // NAVIGATION
        // ============================
        private void btnSelectPatient_Click(object sender, EventArgs e)
        {
            Form form = new SelectPatientForm();
            form.Show();
            this.Hide();
        }

        private void btnImmunizations_Click(object sender, EventArgs e)
        {
            Form form = new ImmunizationHistoryForm(_patientId);
            form.Show();
            this.Hide();
        }

        private void btnMedications_Click(object sender, EventArgs e)
        {
            Form form = new MedicationHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
            form.Show();
            this.Hide();
        }

        private void btnDemographics_Click(object sender, EventArgs e)
        {
            Form form = new PatientDemographicsForm(_patientId);
            form.Show();
            this.Hide();
        }
    }
}
