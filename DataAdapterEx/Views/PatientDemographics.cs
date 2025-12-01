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

namespace DataAdapterEx.Views
{
    public partial class PatientDemographics : Form
    {
        DataTable dt;
        int FormMode = 0; // 0 - View, 1 - Add, 2 - Edit
        public PatientDemographics(Form f)
        {
            f.Close();
            InitializeComponent();

            MySqlConnection conn = DBUtilsPatient.MakeConnection();
            dt = DBUtilsPatient.GetPatientById(conn, GlobalData.PID);
            PopulateFieldsWithDBInfo();
            LockControls();
        }

        public void PopulateFieldsWithDBInfo()
        {
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lbl_PID.Text = row["PID"].ToString();
                tb_LastName.Text = row["LastName"].ToString();
                tb_FirstName.Text = row["FirstName"].ToString();
                tb_Age.Text = row["Age"].ToString();
            }
            else
            {
                MessageBox.Show("No patient data found for the given PID.");
            }
        }

        private void btn_SelectPatient_Click(object sender, EventArgs e)
        {
            Form form = new Form1(this);
            form.Show();
        }

        public void LockControls()
        {
            tb_LastName.ReadOnly = true;
            tb_FirstName.ReadOnly = true;
            tb_Age.ReadOnly = true;

            tb_Age.BackColor = Color.LightGray;
            tb_FirstName.BackColor = Color.LightGray;
            tb_LastName.BackColor = Color.LightGray;

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UnLockControls();
            FormMode = 2;  // edit mode
        }

        public void UnLockControls()
        {
            tb_LastName.ReadOnly = false;
            tb_FirstName.ReadOnly = false;
            tb_Age.ReadOnly = false;
            tb_Age.BackColor = Color.White;
            tb_FirstName.BackColor = Color.White;
            tb_LastName.BackColor = Color.White;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Do DB Operation
            if (FormMode == 1) // add mode
            {
                // New (Insert) Record DB Operation
                using (MySqlConnection conn = DBUtilsPatient.MakeConnection())
                {
                    Patient newPatient = new Patient();
                    newPatient.LastName = tb_LastName.Text;
                    newPatient.FirstName = tb_FirstName.Text;
                    newPatient.Age = int.Parse(tb_Age.Text);
                    
                    try
                    {
                        DBUtilsPatient.InsertPatientSP(
                            conn, newPatient);
                        // call SELECT Last_Insert_ID to get the new PID
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting new patient: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                LockControls();
                FormMode = 0;

            }
            else if (FormMode == 2) // edit mode
            {
                // Edit Record
                MySqlConnection conn = DBUtilsPatient.MakeConnection();
                //DBUtilsPatient.UpdatePatientInfo(conn, int.Parse(lbl_PID.Text), tb_LastName.Text, tb_FirstName.Text, int.Parse(tb_Age.Text));
                conn.Close();
                MessageBox.Show("Patient information updated successfully.");
            }
            LockControls();
            FormMode = 0;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            FormMode = 1;
            UnLockControls();
            ClearData();
 
        }
        private void ClearData()
        {
            lbl_PID.Text = "Auto Generated";
            tb_LastName.Text = "";
            tb_FirstName.Text = "";
            tb_Age.Text = "";
        }

    }
}
