using DataAdapterEx.DBUtils;
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
    public partial class GeneralMedicalHistory : Form
    {
        private int _patientId;

        public GeneralMedicalHistory(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
        }

        private void GeneralMedicalHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
            SetViewMode();
        }

        // =========================
        // LOAD DATA
        // =========================
        private void LoadHistory()
        {
            var conn = DBUtilsGeneralMedicalHistory.MakeConnection();

            dgvHistory.DataSource =
                DBUtilsGeneralMedicalHistory.GetByPatientId(conn, _patientId);
        }

        // =========================
        // MODE CONTROL
        // =========================
        private void SetViewMode()
        {
            txtMaritalStatus.ReadOnly = true;
            txtEducation.ReadOnly = true;
            txtBehavioral.ReadOnly = true;

            txtMaritalStatus.BackColor = System.Drawing.Color.LightGray;
            txtEducation.BackColor = System.Drawing.Color.LightGray;
            txtBehavioral.BackColor = System.Drawing.Color.LightGray;
        }

        private void SetEditMode()
        {
            txtMaritalStatus.ReadOnly = false;
            txtEducation.ReadOnly = false;
            txtBehavioral.ReadOnly = false;

            txtMaritalStatus.BackColor = System.Drawing.Color.White;
            txtEducation.BackColor = System.Drawing.Color.White;
            txtBehavioral.BackColor = System.Drawing.Color.White;
        }

        // =========================
        // GRID SELECTION
        // =========================
        private void dgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count > 0)
            {
                txtMaritalStatus.Text =
                    dgvHistory.SelectedRows[0].Cells["MaritalStatus"].Value.ToString();

                txtEducation.Text =
                    dgvHistory.SelectedRows[0].Cells["Education"].Value.ToString();

                txtBehavioral.Text =
                    dgvHistory.SelectedRows[0].Cells["BehavioralHistory"].Value.ToString();
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
            var conn = DBUtilsGeneralMedicalHistory.MakeConnection();

            DBUtilsGeneralMedicalHistory.InsertHistory(
                conn,
                _patientId,
                txtMaritalStatus.Text,
                txtEducation.Text,
                txtBehavioral.Text
            );

            LoadHistory();
            SetViewMode();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(
                    dgvHistory.SelectedRows[0].Cells["GeneralMedicalHistoryID"].Value);

                var conn = DBUtilsGeneralMedicalHistory.MakeConnection();
                DBUtilsGeneralMedicalHistory.DeleteHistory(conn, id);

                LoadHistory();
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
            txtMaritalStatus.Clear();
            txtEducation.Clear();
            txtBehavioral.Clear();
        }
    }
}
