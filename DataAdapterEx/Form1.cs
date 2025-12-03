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
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            lbl_PID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            lbl_lastName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            GlobalData.CurrentPatientID = Convert.ToInt32(lbl_PID.Text);
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
            Form form = new Views.Allergies(this);
            form.Show();
        }
    }
}
