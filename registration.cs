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
using System.Configuration;
using System.IO;


namespace MastersRegistration
{
    public partial class sear : Form
    {
        public sear()
        {
            InitializeComponent();
        }
        //string connectionString = ConfigurationManager.connectionString[" "].connectionString;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGKPF3E\\SQLEXPRESS;Initial Catalog=REGISTRATION;Integrated Security=True;TrustServerCertificate=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            course sourse1 = new course();
            sourse1.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sear sourse = new sear();
            sourse.Show();
            this.Hide();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            faculty sourse = new faculty();
            sourse.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            schedule one = new schedule();
            one.Show();
            this.Hide();
        }

        private void courseCode_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sear_Load(object sender, EventArgs e)
        {
            loadCourseData();
            loadStudentData();
            DisplayDataGrid();



        }

        private void loadCourseData()
        {

            string query = "SELECT * From Course";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Course");
            courseCMB.DataSource = ds.Tables["Course"];
            courseCMB.DisplayMember = "courseName";
            courseCMB.ValueMember = "courseId";
            conn.Close();

        }

        private void loadStudentData()
        {
            string query = "SELECT * From STUDENT";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "STUDENT");
            studentCMB.DataSource = ds.Tables["STUDENT"];
            studentCMB.DisplayMember = "studentName";
            studentCMB.ValueMember = "studentId";
            conn.Close();
        }

        private void DisplayDataGrid()
        {
            string query = "SELECT * FROM REGISTRATION";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "REGISTRATION");
            registrationGridView.DataSource = ds.Tables["REGISTRATION"];
            conn.Close();
        }

        private void DisplayDataGridSearch()
        {
            string query = "SELECT * FROM REGISTRATION WHERE registrationNumber=' " + searchTB.Text + "'";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "REGISTRATION");
            dataGridSearch.DataSource = ds.Tables["REGISTRATION"];
            conn.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("INSERT INTO REGISTRATION VALUES(@eric,@crs,@sem,@acadYear,@regNum)", conn);
            cmd.Parameters.AddWithValue("@eric", studentCMB.SelectedValue);
            cmd.Parameters.AddWithValue("@crs", courseCMB.SelectedValue);
            cmd.Parameters.AddWithValue("@sem", semesterTB.Text.Trim());
            cmd.Parameters.AddWithValue("@acadYear", dateTime1.Text);
            cmd.Parameters.AddWithValue("@regNum", regNoTB.Text.Trim());


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayDataGrid();


        }

        private void view_Click(object sender, EventArgs e)
        {

            DisplayDataGrid();


        }

        private void student_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            DisplayDataGridSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {


            string query = "UPDATE REGISTRATION SET " +
                "student = @eric, course = @crs, semester = @sem, academicYear = @acadYear WHERE registrationNumber = @regNum";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@eric", studentCMB.SelectedValue);
            cmd.Parameters.AddWithValue("@crs", courseCMB.SelectedValue);
            cmd.Parameters.AddWithValue("@sem", semesterTB.Text.Trim());
            cmd.Parameters.AddWithValue("@acadYear", dateTime1.Text);
            cmd.Parameters.AddWithValue("@regNum", regNoTB.Text.Trim());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayDataGrid();
        

    }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM REGISTRATION WHERE registrationNumber = @regNum";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@regNum", regNoTB.Text.Trim());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayDataGrid();
        }

        private void registrationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void GenerateReport()
        {
            try
            {
                string query = "SELECT * FROM REGISTRATION";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();

                // Create a string builder for the report
                StringBuilder report = new StringBuilder();
                report.AppendLine("Registration Report");
                report.AppendLine("=======================================");
                report.AppendLine("RegNo\tStudent\tCourse\tSemester\tAcademic Year");

                foreach (DataRow row in dt.Rows)
                {
                    report.AppendLine($"{row["registrationNumber"]}\t{row["student"]}\t{row["course"]}\t{row["semester"]}\t{row["academicYear"]}");
                }

                // Save report as a text file
                string filePath = "C:\\Users\\Public\\RegistrationReport.txt";
                File.WriteAllText(filePath, report.ToString());

                MessageBox.Show("Report generated successfully at " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void geneerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();

        }
    }
}
