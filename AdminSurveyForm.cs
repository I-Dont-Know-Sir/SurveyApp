using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvayApp
{
    public partial class AdminSurveyForm : Form
    {
        PrintPreviewDialog prntprvdialog = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();

        public AdminSurveyForm()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\younu\source\repos\SurvayApp\Database.mdf;Integrated Security=True");
        public int Id;
        private void AdminSurveyForm_Load(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\younu\source\repos\SurvayApp\Database.mdf;Integrated Security=True");            
                string query = "select * from SurveyInfo ";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, con);
                DataSet dataSet = new DataSet();
                sqlData.Fill(dataSet, "SurveyInfo");
                dataGridView1.DataSource = dataSet.Tables["SurveyInfo"].DefaultView;            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Focus();
            Application.Exit();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //
                SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO [dbo].[SurveyQuestion]
                                                       ([question],[surveyType])
                                                        VALUES
                                                       ('" + txtQuestion.Text + "','" + cmbSurveyType.SelectedItem + "')", con);
                con.Open();
                cmdInsert.ExecuteNonQuery();
                SqlCommand myCommand = new SqlCommand("select * from SurveyQuestion where question = '" + txtQuestion.Text.Trim() + "'", con);
                
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Id = int.Parse(myReader["Id"].ToString());
                }
                con.Close();
                //
                SqlCommand cmdInsert11 = new SqlCommand(@"INSERT INTO [dbo].[SurveyAnswer]
                                                       ([questionId],[answer])
                                                        VALUES
                                                       ('" + Id + "','" + txtAnswer1.Text + "')", con);
                con.Open();
                cmdInsert11.ExecuteNonQuery();
                con.Close();
                // MessageBox.Show("Thank You");
                SqlCommand cmdInsert2 = new SqlCommand(@"INSERT INTO [dbo].[SurveyAnswer]
                                                       ([questionId],[answer])
                                                        VALUES
                                                       ('" + Id + "','" + txtAnswer2.Text + "')", con);
                con.Open();
                cmdInsert2.ExecuteNonQuery();
                con.Close();
                SqlCommand cmdInsert3 = new SqlCommand(@"INSERT INTO [dbo].[SurveyAnswer]
                                                       ([questionId],[answer])
                                                        VALUES
                                                       ('" + Id + "','" + txtAnswer3.Text + "')", con);
                con.Open();
                cmdInsert3.ExecuteNonQuery();
                con.Close();
                SqlCommand cmdInsert55 = new SqlCommand(@"INSERT INTO [dbo].[SurveyAnswer]
                                                       ([questionId],[answer])
                                                        VALUES
                                                       ('" + Id + "','" + txtAnswer4.Text + "')", con);
                con.Open();
                cmdInsert55.ExecuteNonQuery();
                MessageBox.Show("Survey Create successfully");
                //con.Close();
                // SqlCommand cmdInsert6 = new SqlCommand(@"update SurveyQuestion set surveyType='" + cmbSurveyType.SelectedItem + "' where Id ='" + Id + "'", con);
                //cmdInsert6.ExecuteNonQuery();
                con.Close();
            }            
        }

        private void txtQuestion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text))
            {
                e.Cancel = true;
                txtQuestion.Focus();
                errorProviderforQuestion.SetError(txtQuestion, "Question should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderforQuestion.SetError(txtQuestion, "");
                
            }
        }

        private void txtAnswer1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer1.Text))
            {
                e.Cancel = true;
                txtAnswer1.Focus();
                errorProviderforAns1.SetError(txtAnswer1, "should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderforAns1.SetError(txtAnswer1, "");
            }
        }

        private void txtAnswer2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer2.Text))
            {
                e.Cancel = true;
                txtAnswer2.Focus();
                errorProviderforAns2.SetError(txtAnswer2, "should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderforAns2.SetError(txtAnswer2, "");
                
            }
        }

        private void txtAnswer3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer3.Text))
            {
                e.Cancel = true;
                txtAnswer3.Focus();
                errorProviderforAns3.SetError(txtAnswer3, "should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderforAns3.SetError(txtAnswer3, "");
               
            }
        }

        private void txtAnswer4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer4.Text))
            {
                e.Cancel = true;
                txtAnswer4.Focus();
                errorProviderforAns4.SetError(txtAnswer4, "should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderforAns4.SetError(txtAnswer4, "");
                SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO [dbo].[SurveyAnswer]
                                                       ([questionId],[answer])
                                                        VALUES
                                                       ('" + Id + "','" + txtAnswer4.Text + "')", con);
                con.Open();
                cmdInsert.ExecuteNonQuery();
                con.Close();
            }
        }

        private void cmbSurveyType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSurveyType.Text))
            {
                e.Cancel = true;
                cmbSurveyType.Focus();
                errorProviderforCombobox.SetError(cmbSurveyType, "should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderforCombobox.SetError(cmbSurveyType, "");
            }
        }




        public void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = panel;
            getPrintArea(panel);
            prntprvdialog.Document = pntdoc;
            //PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler();
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_PrintPage);
            prntprvdialog.ShowDialog();
        }
        public void pntdoc_PrintPage(object sender, PrintPageEventArgs e) 
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bitmap, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        Bitmap bitmap;

        public void getPrintArea(Panel panel)
        {
            bitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

    }
}
