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
    public partial class Allergies : Form
    {
        DataTable dt;
        int FormMode = 0; // 0 - View, 1 - Add, 2 - Edit    
        public Allergies()
        {
            InitializeComponent();
        }
        public Allergies(Form f)
        {
            f.Close();
            InitializeComponent();
        }

        private void Allergies_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtilsPatient.MakeConnection();
            dt = DBUtilsAllergies.GetAllergiesById(conn, GlobalData.PID);
            PopulateFieldsWithDBInfo();
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
        }
        private void PopulateFieldsWithDBInfo()
        {
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataRow row = dt.Rows[rowIndex];
            lbl_AllergyID.Text = row["AllergyID"].ToString();
            tb_Allergy.Text = row["Allergy"].ToString();
            tb_Symptoms.Text = row["Symptoms"].ToString();

            // Alternately, you can use the DataTable to 
            // extract data columns at row specified by rowIndex
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form1(this);
            f.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //UnLockControls();
            FormMode = 2;  // edit mode
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            FormMode = 1;
            //UnLockControls();
            //ClearData();
        }
    }
}
