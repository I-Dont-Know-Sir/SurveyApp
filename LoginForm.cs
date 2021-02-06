using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvayApp
{
    public partial class LoginForm : Form
    {
        //public static int UserID;

        public LoginForm()
        {

            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\younu\source\repos\SurvayApp\Database.mdf;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                {
                    string query = "select * from Users where User_Name = '" + txtUserName.Text.Trim() + "' and Password ='" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sqlData = new SqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    sqlData.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        string query1 = txtUserName.Text;
                        if (query1 == "admin")
                        {
                            AdminSurveyForm adminsurveyForm = new AdminSurveyForm();
                            this.Hide();
                            adminsurveyForm.Show();
                        }
                        else
                        {
                            SurveyForm surveyForm = new SurveyForm();
                            this.Hide();
                            surveyForm.Show();
                        }
                    }
                }
            }
        }
        private bool IsValid()
        {
            if (txtUserName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter the Username", "Error");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter the Password", "Error");
                return false;
            }
            return true;
        }
        private void lblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
