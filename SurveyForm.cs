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
    public partial class SurveyForm : Form
    {
        public SurveyForm()
        {
            InitializeComponent();
        }
        public int id, Ansid, ans2nd, ans3rd, ans4th, RAnsid, Rans2nd, Rans3rd, Rans4th;
        public string Q1, Q2, Q3;
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\younu\source\repos\SurvayApp\Database.mdf;Integrated Security=True");

       
        private void SurveyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.SurveyAnswer' table. You can move, or remove it, as needed.
            this.surveyAnswerTableAdapter.Fill(this.databaseDataSet1.SurveyAnswer);

            this.surveyInfoTableAdapter.Fill(this.databaseDataSet.SurveyInfo);
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();

            SqlCommand myCommand = new SqlCommand("select top 1 * from SurveyQuestion where surveyType = 'Combo box' order by Id desc", con1);
            con1.Open();
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                groupBox1.Show();
                label3.Text = (myReader["question"].ToString());
                id = int.Parse(myReader["Id"].ToString());
            }
            con1.Close();
            SqlCommand myCommand1 = new SqlCommand("SELECT answer FROM SurveyAnswer WHERE(questionId = " + id + ")", con1);
            con1.Open();
            SqlDataReader myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {               
                cmbNumber3.Items.Add(myReader1["answer"].ToString());
            }
            con1.Close();



            SqlCommand myCommand2 = new SqlCommand("select top 1 * from SurveyQuestion where surveyType = 'Radio button' order by Id desc", con1);
            con1.Open();
            SqlDataReader myReader3 = myCommand2.ExecuteReader();
            while (myReader3.Read())
            {
                groupBox2.Show();
                label2.Text = (myReader3["question"].ToString());
                id = int.Parse(myReader3["Id"].ToString());
            }
            con1.Close();
            SqlCommand myCommand3 = new SqlCommand("SELECT * FROM SurveyAnswer WHERE(questionId = " + id + ")", con1);
            con1.Open();
            SqlDataReader myReader4 = myCommand3.ExecuteReader();
            //while (myReader4.Read())
            //{
            //    radioButton1.Text = myReader4["answer"].ToString();
            //}
            if (myReader4.Read())
            {
                RAnsid = int.Parse(myReader4["Id"].ToString());
                if (RAnsid != 0)
                {
                    radioButton1.Text = myReader4["answer"].ToString();
                }
                con1.Close();
                Rans2nd = RAnsid + 1;
                SqlCommand myCommand5ans2nd = new SqlCommand("SELECT answer FROM SurveyAnswer WHERE (Id = " + Rans2nd + ")", con1);
                con1.Open();

                SqlDataReader myReaderans2nd = myCommand5ans2nd.ExecuteReader();
                if (myReaderans2nd.Read())
                {
                    radioButton2.Text = myReaderans2nd["answer"].ToString();
                }
                con1.Close();
                Rans3rd = Rans2nd + 1;
                SqlCommand myCommand5ans3rd = new SqlCommand("SELECT answer FROM SurveyAnswer WHERE (Id = " + Rans3rd + ")", con1);
                con1.Open();

                SqlDataReader myReaderans3rd = myCommand5ans3rd.ExecuteReader();
                if (myReaderans3rd.Read())
                {
                    radioButton3.Text = myReaderans3rd["answer"].ToString();
                }

                con1.Close();
                Rans4th = Rans3rd + 1;
                SqlCommand myCommand5ans4th = new SqlCommand("SELECT answer FROM SurveyAnswer WHERE (Id = " + Rans4th + ")", con1);
                con1.Open();
                SqlDataReader myReaderans4th = myCommand5ans4th.ExecuteReader();
                if (myReaderans4th.Read())
                {
                    radioButton4.Text = myReaderans4th["answer"].ToString();
                }
                con1.Close();
            }

            con1.Close();

            SqlCommand myCommand4 = new SqlCommand("select top 1 * from SurveyQuestion where surveyType = 'Check box' order by Id desc", con1);
            con1.Open();
            SqlDataReader myReader5 = myCommand4.ExecuteReader();
            while (myReader5.Read())
            {
                groupBox3.Show();
                label1.Text = myReader5["question"].ToString();
                id = int.Parse(myReader5["Id"].ToString());
            }
            con1.Close();
            SqlCommand myCommand5 = new SqlCommand("SELECT * FROM SurveyAnswer WHERE(questionId = " + id + ")", con1);
            con1.Open();
            SqlDataReader myReader6 = myCommand5.ExecuteReader();

            if (myReader6.Read())
            {
               Ansid = int.Parse(myReader6["Id"].ToString());
                if (Ansid != 0)
                {
                    checkBox1.Text = myReader6["answer"].ToString();
                }
                con1.Close();
                ans2nd = Ansid + 1;
                SqlCommand myCommand5ans2nd = new SqlCommand("SELECT answer FROM SurveyAnswer WHERE (Id = " + ans2nd + ")", con1);
                con1.Open();

                SqlDataReader myReaderans2nd = myCommand5ans2nd.ExecuteReader();
                if (myReaderans2nd.Read())
                {
                    checkBox2.Text = myReaderans2nd["answer"].ToString();
                }
                con1.Close();
                ans3rd = ans2nd + 1;
                SqlCommand myCommand5ans3rd = new SqlCommand("SELECT answer FROM SurveyAnswer WHERE (Id = " + ans3rd + ")", con1);
                con1.Open();

                SqlDataReader myReaderans3rd = myCommand5ans3rd.ExecuteReader();
                if (myReaderans3rd.Read())
                {
                    checkBox3.Text = myReaderans3rd["answer"].ToString();
                }
                 
                con1.Close();
                ans4th = ans3rd + 1;
                SqlCommand myCommand5ans4th = new SqlCommand("SELECT answer FROM SurveyAnswer WHERE (Id = " + ans4th + ")", con1);
                con1.Open();
                SqlDataReader myReaderans4th = myCommand5ans4th.ExecuteReader();
                if (myReaderans4th.Read())
                {
                    checkBox4.Text = myReaderans4th["answer"].ToString();
                }
                con1.Close();
            }


           // con1.Close();
           
        }

  
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\younu\source\repos\SurvayApp\Database.mdf;Integrated Security=True");
                {
                    SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO [dbo].[SurveyInfo]
                                                       ([Survaey_Information])
                                                        VALUES
                                                       ('" + Q3 + "//" + Q2 + "//" + Q1 + "')", con1);
                    con1.Open();
                    cmdInsert.ExecuteNonQuery();
                    con1.Close();

                    MessageBox.Show("Thank You");
                    //this.Hide();
                    Application.Exit();
                    //SurveyForm surveyForm = new SurveyForm();
                    //surveyForm.Show();
                }
            }
        }

        private bool IsValid()
        {
            if (Q3 == null)
            {
                MessageBox.Show("Please select the Combo box value", "Error");
                return false;
            }
            else if (Q2 == null)
            {
                MessageBox.Show("Please select the Radio button value", "Error");
                return false;
            }
            else if (Q1 == null)
            {
                MessageBox.Show("please select the Check box value", "Error");
                return false;
            }
            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox chk = sender as CheckBox;
            
            if (checkBox1.Checked == true)
            {
                Q1 = checkBox1.Text;
                //Q1 = "Strongly disagree";
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                //checkBox5.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                Q1 = checkBox2.Text;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                //checkBox5.Checked = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true)
            {
                Q1 = checkBox3.Text;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                //checkBox5.Checked = false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                Q1 = checkBox4.Text;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                //checkBox5.Checked = false;
                //Q1 = "Agree";
            }

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == false)
            {
                //Q2 = null;
                radioButton1.Text = null;
            }
            else
            {
                Q2 = radioButton1.Text;
            }
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked == false)
            {
                radioButton2.Text = null;
            }
            else
            {
                Q2 = radioButton2.Text;
            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Q2 = "From an advertisement ";
            if (radioButton3.Checked == false)
            {
                radioButton3.Text = null;
            }
            else
            {
                Q2 = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == false)
            {
                radioButton4.Text = null;
            }
            else
            {
                Q2 = radioButton4.Text;
            }
        }

        private void cmbNumber3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Q3 = cmbNumber3.SelectedItem.ToString();
            //Q3 = "SELECT TOP (4) answer FROM SurveyQuestion WHERE(surveyType = 'Combo box') ORDER BY surveyType DESC";

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    

}
