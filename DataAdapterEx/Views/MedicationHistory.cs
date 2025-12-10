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

        public MedicationHistoryForm(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
        }

        private void MedicationHistoryForm_Load(object sender, EventArgs e)
        {
            LoadMedications();
            SetViewMode();
        }

        // =========================
        // LOAD DATA
        // =========================
        private void LoadMedications()
        {
            var conn = DBUtilsMedicationHistory.MakeConnection();
            dgvMedications.DataSource = DBUtilsMedicationHistory.GetByPatientId(conn, _patientId);
        }

        // =========================
        // MODE CONTROL
        // =========================
        private void SetViewMode()
        {
            txtMedication.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtUnit.ReadOnly = true;
            txtInstructions.ReadOnly = true;

            txtMedication.BackColor = System.Drawing.Color.LightGray;
            txtAmount.BackColor = System.Drawing.Color.LightGray;
            txtUnit.BackColor = System.Drawing.Color.LightGray;
            txtInstructions.BackColor = System.Drawing.Color.LightGray;
        }

        private void SetEditMode()
        {
            txtMedication.ReadOnly = false;
            txtAmount.ReadOnly = false;
            txtUnit.ReadOnly = false;
            txtInstructions.ReadOnly = false;

            txtMedication.BackColor = System.Drawing.Color.White;
            txtAmount.BackColor = System.Drawing.Color.White;
            txtUnit.BackColor = System.Drawing.Color.White;
            txtInstructions.BackColor = System.Drawing.Color.White;
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
            }
        }

        // =========================
        // BUTTON EVENTS
        // =========================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetEditMode();
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var conn = DBUtilsMedicationHistory.MakeConnection();

            DBUtilsMedicationHistory.InsertMedication(
                conn,
                _patientId,
                txtMedication.Text,
                txtAmount.Text,
                txtUnit.Text,
                txtInstructions.Text
            );

            LoadMedications();
            SetViewMode();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedications.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(
                    dgvMedications.SelectedRows[0].Cells["MedicationID"].Value);

                var conn = DBUtilsMedicationHistory.MakeConnection();
                DBUtilsMedicationHistory.DeleteMedication(conn, id);

                LoadMedications();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            SetViewMode();
            ClearFields();
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
        }

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
