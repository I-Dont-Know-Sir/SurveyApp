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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\younu\source\repos\SurvayApp\Database.mdf;Integrated Security=True");

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string password, confirm_Pass;
                //User_Name = txtName.Text;
                password = txtPass.Text;
                confirm_Pass = txtConfirmPass.Text;
                if (password == confirm_Pass)
                {
                    string queryDataCheck = "select * from Users where User_Name ='" + txtName.Text.Trim() + "'";
                    SqlDataAdapter sqlData = new SqlDataAdapter(queryDataCheck, con);
                    DataTable dataTable = new DataTable();
                    sqlData.Fill(dataTable);
                    if (dataTable.Rows.Count == 0)
                    {
                        SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO [dbo].[Users]
                                                       ([User_Name],[Password])
                                                        VALUES
                                                       ('" + txtName.Text + "','" + txtPass.Text + "')", con);
                        con.Open();
                        cmdInsert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("registration successfull");
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User name is already Exist");
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't Match");
                }
            }
            
            

        }

        private bool IsValid()
        {
            if (txtName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter the Username", "Error");
                return false;
            }
            else if (txtPass.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter the Password", "Error");
                return false;
            }
            else if (txtConfirmPass.Text.TrimStart()== string.Empty)
            {
                MessageBox.Show("Enter the Confirm Password", "Error");
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
