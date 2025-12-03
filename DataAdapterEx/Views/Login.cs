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
    public partial class Login : Form
    {
        MySqlConnection conn;
        DataTable dt;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (conn = DBUtilsPatient.MakeConnection())
            {
                try
                {
                    
                    dt = DBUtilsLogin.AuthenticateUser(conn, username, password);

                    if (dt.Rows.Count == 1)
                    {
                        // Store session user
                        GlobalData.LoggedInUserID =
                            Convert.ToInt32(dt.Rows[0]["LoginID"]);

                        GlobalData.LoggedInUserName =
                            dt.Rows[0]["UserName"].ToString();

                        MessageBox.Show("Login successful!");

                        // Open main Select Patient form
                        Form f = new Form1(this);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login. User not found, inactive, or deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_Password.Text = "";
        }
    }
}
