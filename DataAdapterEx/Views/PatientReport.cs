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
    public partial class PatientReport : Form
    {
        MySqlConnection conn;
        DataTable dt;

        public PatientReport()
        {
            InitializeComponent();
        }

        public PatientReport(Form f)
        {
            f.Hide();
            InitializeComponent();
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            int pid = GlobalData.CurrentPatientID;
            string username = GlobalData.LoggedInUserName;

            if (pid <= 0)
            {
                MessageBox.Show("No patient selected.");
                return;
            }

            using (conn = DBUtilsPatient.MakeConnection())
            {
                try
                {
                    conn.Open();

                    DataTable demo = DBUtilsPatientReport.GetPatientDemographics(pid, conn);
                    DataTable medhx = DBUtilsPatientReport.GetGeneralMedicalHistory(pid, conn);
                    DataTable immun = DBUtilsPatientReport.GetImmunizations(pid, conn);
                    DataTable meds = DBUtilsPatientReport.GetMedications(pid, conn);

                    string reportText = ReportGenerator.GeneratePatientReport(
                        demo, medhx, immun, meds, username);

                    string filePath = $"PatientReport_{pid}_{DateTime.Now.Ticks}.txt";

                    System.IO.File.WriteAllText(filePath, reportText);

                    MessageBox.Show($"Report created:\n{filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating report: " + ex.Message);
                }
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void btn_Report_Click(object sender, EventArgs e)
        //{
        //    Form f = new DataAdapterEx.Views.PatientReport(this);
        //    f.Show();
        //}

        private void PatientReport_Load(object sender, EventArgs e)
        {
            lbl_PatientID.Text = GlobalData.CurrentPatientID.ToString();
        }
    }
}
