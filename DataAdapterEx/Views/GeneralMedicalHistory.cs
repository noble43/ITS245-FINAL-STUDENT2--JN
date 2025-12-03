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
    public partial class GeneralMedicationHistoryForm : Form
    {
        private MySqlConnection conn;
        private int patientID = 0;
        private int currentMedicationID = 0;
        private bool isEditMode = false;

        public GeneralMedicationHistoryForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;database=patientdb;uid=root;pwd=yourpassword;");
        }

        private void GeneralMedicationHistoryForm_Load(object sender, EventArgs e)
        {
            SetViewMode();
        }

        private void SetViewMode()
        {
            txtMedication.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtUnit.ReadOnly = true;
            txtInstructions.ReadOnly = true;
            txtStartDate.ReadOnly = true;
            txtEndDate.ReadOnly = true;
            txtPrescriptionHCP.ReadOnly = true;

            txtMedication.BackColor = System.Drawing.Color.LightGray;
            txtAmount.BackColor = System.Drawing.Color.LightGray;
            txtUnit.BackColor = System.Drawing.Color.LightGray;
            txtInstructions.BackColor = System.Drawing.Color.LightGray;
            txtStartDate.BackColor = System.Drawing.Color.LightGray;
            txtEndDate.BackColor = System.Drawing.Color.LightGray;
            txtPrescriptionHCP.BackColor = System.Drawing.Color.LightGray;

            isEditMode = false;
        }

        private void SetEditMode()
        {
            txtMedication.ReadOnly = false;
            txtAmount.ReadOnly = false;
            txtUnit.ReadOnly = false;
            txtInstructions.ReadOnly = false;
            txtStartDate.ReadOnly = false;
            txtEndDate.ReadOnly = false;
            txtPrescriptionHCP.ReadOnly = false;

            txtMedication.BackColor = System.Drawing.Color.White;
            txtAmount.BackColor = System.Drawing.Color.White;
            txtUnit.BackColor = System.Drawing.Color.White;
            txtInstructions.BackColor = System.Drawing.Color.White;
            txtStartDate.BackColor = System.Drawing.Color.White;
            txtEndDate.BackColor = System.Drawing.Color.White;
            txtPrescriptionHCP.BackColor = System.Drawing.Color.White;

            isEditMode = true;
        }

        private void LoadMedications()
        {
            if (patientID == 0) return;

            lstMedications.Items.Clear();

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT MedicationID, Medication FROM patientmedications WHERE PatientID=@PatientID AND deleted=0", conn);
                cmd.Parameters.AddWithValue("@PatientID", patientID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstMedications.Items.Add(new ListItem(reader.GetInt32("MedicationID"), reader.GetString("Medication")));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medications: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lstMedications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedications.SelectedItem == null) return;

            ListItem selected = (ListItem)lstMedications.SelectedItem;
            currentMedicationID = selected.ID;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM patientmedications WHERE MedicationID=@MedicationID", conn);
                cmd.Parameters.AddWithValue("@MedicationID", currentMedicationID);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMedication.Text = reader["Medication"].ToString();
                    txtAmount.Text = reader["MedicationAmt"].ToString();
                    txtUnit.Text = reader["MedicationUnit"].ToString();
                    txtInstructions.Text = reader["Instructions"].ToString();
                    txtStartDate.Text = reader["MedicationStartDate"].ToString();
                    txtEndDate.Text = reader["MedicationEndDate"].ToString();
                    txtPrescriptionHCP.Text = reader["PrescriptionHCP"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medication details: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            SetViewMode();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentMedicationID = 0;
            ClearFields();
            SetEditMode();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (currentMedicationID == 0) return;
            SetEditMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (patientID == 0)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            try
            {
                conn.Open();
                MySqlCommand cmd;

                if (currentMedicationID == 0) // Add
                {
                    cmd = new MySqlCommand(
                        "INSERT INTO patientmedications (PatientID, Medication, MedicationAmt, MedicationUnit, Instructions, MedicationStartDate, MedicationEndDate, PrescriptionHCP) " +
                        "VALUES (@PatientID,@Medication,@Amt,@Unit,@Instructions,@StartDate,@EndDate,@HCP)", conn);
                }
                else // Update
                {
                    cmd = new MySqlCommand(
                        "UPDATE patientmedications SET Medication=@Medication, MedicationAmt=@Amt, MedicationUnit=@Unit, Instructions=@Instructions, " +
                        "MedicationStartDate=@StartDate, MedicationEndDate=@EndDate, PrescriptionHCP=@HCP WHERE MedicationID=@MedicationID", conn);
                    cmd.Parameters.AddWithValue("@MedicationID", currentMedicationID);
                }

                cmd.Parameters.AddWithValue("@PatientID", patientID);
                cmd.Parameters.AddWithValue("@Medication", txtMedication.Text);
                cmd.Parameters.AddWithValue("@Amt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@Unit", txtUnit.Text);
                cmd.Parameters.AddWithValue("@Instructions", txtInstructions.Text);
                cmd.Parameters.AddWithValue("@StartDate", txtStartDate.Text);
                cmd.Parameters.AddWithValue("@EndDate", txtEndDate.Text);
                cmd.Parameters.AddWithValue("@HCP", txtPrescriptionHCP.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving medication: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            LoadMedications();
            SetViewMode();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            lstMedications_SelectedIndexChanged(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentMedicationID == 0) return;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE patientmedications SET deleted=1 WHERE MedicationID=@MedicationID", conn);
                cmd.Parameters.AddWithValue("@MedicationID", currentMedicationID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting medication: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            LoadMedications();
            ClearFields();
        }

        private void ClearFields()
        {
            txtMedication.Clear();
            txtAmount.Clear();
            txtUnit.Clear();
            txtInstructions.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtPrescriptionHCP.Clear();
        }

        private void btnSelectPatient_Click(object sender, EventArgs e)
        {
            //SelectPatientForm selectForm = new SelectPatientForm();
            //if (selectForm.ShowDialog() == DialogResult.OK)
            //{
            //    patientID = selectForm.SelectedPatientID;
            //    LoadMedications();
            //}
        }

        // Helper class for ListBox items
        private class ListItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public ListItem(int id, string name)
            {
                ID = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
