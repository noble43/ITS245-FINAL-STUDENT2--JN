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

namespace DataAdapterEx
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form f)
        {
            f.Hide();
            InitializeComponent();
        }

        private void btn_RetrievePatients_Click(object sender, EventArgs e)
        {
            using(conn = DBUtilsPatient.MakeConnection())
            {
                try
                {
                    //dt = DBUtilsPatient.GetAllPatients(conn);
                    dt = DBUtilsPatient.GetAllPatientsSP(conn);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (conn = DBUtilsPatient.MakeConnection())
            {
                try
                {
                    dt = DBUtilsPatient.GetAllPatientsSP(conn);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                // Get PtHomePhone from the clicked row
                string homePhone = dataGridView1.Rows[rowIndex].Cells["PtHomePhone"].Value?.ToString();
                string lastNameFromGrid = dataGridView1.Rows[rowIndex].Cells["PtLastName"].Value?.ToString();

                if (!string.IsNullOrEmpty(homePhone))
                {
                    try
                    {
                        string connStr = "server=localhost;user id=root;password=toor;database=patientdb";
                        using (MySqlConnection conn = new MySqlConnection(connStr))
                        {
                            conn.Open();
                            string query = "SELECT PatientID, PtLastName FROM patientdemographics WHERE `PtHomePhone` = @Phone LIMIT 1";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Phone", homePhone);

                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int patientID = reader.GetInt32("PatientID");
                                        string lastName = reader.GetString("PtLastName");

                                        // Update global variable and labels
                                        GlobalData.CurrentPatientID = patientID;
                                        lbl_PID.Text = patientID.ToString();
                                        lbl_lastName.Text = lastName;
                                    }
                                    else
                                    {
                                        GlobalData.CurrentPatientID = 0;
                                        lbl_PID.Text = string.Empty;
                                        lbl_lastName.Text = lastNameFromGrid ?? string.Empty;
                                        MessageBox.Show("Patient not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain a valid Home Phone.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_ShowGlobalPID_Click(object sender, EventArgs e)
        {
            lbl_GlobalPID.Text = GlobalData.CurrentPatientID.ToString();
        }

        private void btn_PtDemog_Click(object sender, EventArgs e)
        {
            Form form = new Views.PatientDemographics(this);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalData.CurrentPatientID > 0)
            {
                string username = GlobalData.LoggedInUserName; // Grab the logged-in username
                PatientReport report = new PatientReport();
                report.GenerateReport(GlobalData.CurrentPatientID, username);
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form form = new Views.Allergies(this);
        //    form.Show();
        //}

    }
}
