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
//Added DataAdapterEx.Views by JN
//AddedDataAdaperEx.Models by JN

namespace DataAdapterEx.Views
{
    public partial class ImmunizationHistoryForm : Form
    {
        private int patientID;
        private bool isNew = false;
        private int currentImmID = -1;

        //opens immunization form for a specific patient
        public ImmunizationHistoryForm(int selectedPatientID)
        {
            InitializeComponent();
            patientID = selectedPatientID;

            FileLog.Write("Opened Immunization History Form for Patient ID " + patientID);

            LoadImmunizations();   // loads list into listbox
            SetMode("VIEW");       // sets view mode
            LoadPatientHeader();   // loads header with name & age
        }


        private void ImmunizationHistoryForm_Load(object sender, EventArgs e)
        {
        }

        // Loads immunizations for patient into the listbox
        private void LoadImmunizations()
        {
            lb_ImmunizationRecords.Items.Clear();

            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT ImmunizationsID, Vaccine
                               FROM immunizationshistorytable
                               WHERE PatientID=@pid AND deleted = 0";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", patientID);

                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    lb_ImmunizationRecords.Items.Add(
                        new ListItem(
                            r["Vaccine"].ToString(),
                            Convert.ToInt32(r["ImmunizationsID"])
                        )
                    );
                }
            }

            FileLog.Write("Loaded immunization list for Patient ID " + patientID);
        }

        //store listbox text & ID 
        public class ListItem
        {
            public string Text;
            public int Value;

            public ListItem(string t, int v)
            {
                Text = t;
                Value = v;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        // Loads info when user selects an item in the listbox
        private void lb_ImmunizationRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_ImmunizationRecords.SelectedItem == null)
                return;

            int immID = ((ListItem)lb_ImmunizationRecords.SelectedItem).Value;

            FileLog.Write("Selected immunization record ID " + immID);

            LoadImmunizationDetails(immID);
        }

        // Loads selected immunization record into the textboxes
        private void LoadImmunizationDetails(int immID)
        {
            currentImmID = immID;

            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT * FROM immunizationshistorytable WHERE ImmunizationsID=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", immID);

                MySqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    txt_Vaccine.Text = r["Vaccine"].ToString();
                    txt_Date.Text = r["ImmunizationDate"].ToString();
                    txt_Expiration.Text = r["ExpirationDate"].ToString();
                    txt_Delivery.Text = r["Delivery"].ToString();
                    txt_Comments.Text = r["Comments"].ToString();
                    txt_HcpID.Text = r["HCPId"].ToString();
                }
            }

            FileLog.Write("Loaded immunization details for Immunization ID " + immID);

            SetMode("VIEW");
        }

        // Clears fields and enables ADD mode
        private void btn_Add_Click(object sender, EventArgs e)
        {
            isNew = true;
            currentImmID = -1;

            txt_Vaccine.Text = "";
            txt_Date.Text = "";
            txt_Expiration.Text = "";
            txt_Delivery.Text = "";
            txt_Comments.Text = "";
            txt_HcpID.Text = "";

            FileLog.Write("Adding new immunization for Patient ID " + patientID);

            SetMode("ADD");
        }

        // Enables EDIT mode
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (lb_ImmunizationRecords.SelectedItem == null)
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            isNew = false;
            currentImmID = ((ListItem)lb_ImmunizationRecords.SelectedItem).Value;

            FileLog.Write("Modifying immunization ID " + currentImmID);

            SetMode("EDIT");
        }

        // Saves a new or updated immunization record to the database
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql;

                if (isNew)
                {
                    sql = @"INSERT INTO immunizationshistorytable
                            (PatientID, Vaccine, ImmunizationDate, ExpirationDate, Delivery, Comments, HCPId)
                            VALUES
                            (@pid, @vac, @imm, @exp, @del, @com, @hcp)";

                    FileLog.Write("Saving new immunization for PatientID " + patientID);
                }
                else
                {
                    sql = @"UPDATE immunizationshistorytable SET
                            Vaccine=@vac,
                            ImmunizationDate=@imm,
                            ExperationDate=@exp,
                            Delivery=@del,
                            Comments=@com,
                            HCPId=@hcp
                            WHERE ImmunizationsID=@id";

                    FileLog.Write("Updating immunization ID " + currentImmID);
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (!isNew)
                    cmd.Parameters.AddWithValue("@id", currentImmID);

                cmd.Parameters.AddWithValue("@pid", patientID);
                cmd.Parameters.AddWithValue("@vac", txt_Vaccine.Text);
                cmd.Parameters.AddWithValue("@imm", txt_Date.Text);
                cmd.Parameters.AddWithValue("@exp", txt_Expiration.Text);
                cmd.Parameters.AddWithValue("@del", txt_Delivery.Text);
                cmd.Parameters.AddWithValue("@com", txt_Comments.Text);
                cmd.Parameters.AddWithValue("@hcp", txt_HcpID.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Saved.");

            FileLog.Write("Saved immunization record");

            LoadImmunizations();
            SetMode("VIEW");
        }

        // Marks selected record as deleted
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lb_ImmunizationRecords.SelectedItem == null)
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            int id = ((ListItem)lb_ImmunizationRecords.SelectedItem).Value;

            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "UPDATE immunizationshistorytable SET deleted = 1 WHERE ImmunizationsID=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Deleted.");

            FileLog.Write("Deleted immunization ID " + id);

            LoadImmunizations();
        }

        // goes back to previous values and returns to VIEW mode
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            FileLog.Write("Undo immunization edit");

            if (currentImmID > 0)
                LoadImmunizationDetails(currentImmID);

            SetMode("VIEW");
        }

        //switch between VIEW, ADD, and EDIT mode
        private void SetMode(string mode)
        {
            bool editing = (mode == "ADD" || mode == "EDIT");

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Enabled = editing;
            }

            btn_Save.Enabled = editing;
            btn_Undo.Enabled = editing;

            btn_Add.Enabled = !editing;
            btn_Modify.Enabled = !editing;
            btn_Delete.Enabled = !editing;

            this.BackColor = editing ? Color.White : Color.LightGray;
        }

        // Closes form
        private void btn_Close_Click(object sender, EventArgs e)
        {
            FileLog.Write("Closed Immunization History Form for Patient ID " + patientID);
            this.Close();
        }

        private void lbl_Comments_Click(object sender, EventArgs e)
        {
        }

        // goes to select patient form
        private void btn_OpenSelectPatient_Click(object sender, EventArgs e)
        {
            FileLog.Write("Opened Select Patient Form from Immunizations.");

            SelectPatientForm f = new SelectPatientForm();
            f.Show();
            this.Close();
        }

        // Opens demographics form for this patient
        private void btn_OpenPatientDemogrpahics_Click(object sender, EventArgs e)
        {
            if (patientID <= 0)
            {
                MessageBox.Show("No patient selected.");
                return;
            }

            FileLog.Write("Opened Patient Demographics Form from Immunizations.");

            PatientDemographicsForm f = new PatientDemographicsForm(patientID);
            f.ShowDialog();
        }

        // Calculates age based on DOB
        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now < dob.AddYears(age)) age--;
            return age;
        }

        // Loads patient name and age into the header
        private void LoadPatientHeader()
        {
            string connStr = "server=localhost;user id=root;password=toor;database=patientdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT PtFirstName, PtLastName, DOB FROM patientdemographics WHERE PatientID=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", patientID);

                MySqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    string first = r["PtFirstName"].ToString();
                    string last = r["PtLastName"].ToString();

                    DateTime dob = DateTime.MinValue;

                    if (r["DOB"] != DBNull.Value)
                        dob = Convert.ToDateTime(r["DOB"]);

                    int age = dob != DateTime.MinValue ? CalculateAge(dob) : 0;

                    lbl_Header.Text = $"{first} {last}, Age {age}";
                }
            }
        }

        //Nav buttons added by JN
        private void btn_btnGenMedHistory_Click(object sender, EventArgs e)
        {
            FileLog.Write("Opened General Medical History Form from Immunizations.");

            Form form = new GeneralMedicalHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
            form.Show();
            this.Hide();
        }

        private void btn_Medications_Click(object sender, EventArgs e)
        {
            FileLog.Write("Opened Medications Form from Immunizations.");

            Form form = new MedicationHistory(GlobalData.CurrentPatientID, GlobalData.CurrentPatientFullName, GlobalData.CurrentPatientAge);
            form.Show();
            this.Hide();
        }
    }
}
