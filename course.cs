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
using OfficeOpenXml;
using System.IO;


namespace MastersRegistration
{
    public partial class course : Form
    {
        public course()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGKPF3E\\SQLEXPRESS;Initial Catalog=REGISTRATION;Integrated Security=True;TrustServerCertificate=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            schedule one = new schedule();
            one.Show();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            course sourse1 = new course();
            sourse1.Show();
            this.Hide();
        }
        private void DisplayDataGridSearch()
        {
            string query = "SELECT * FROM Course WHERE courseId = @courseId";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@courseId", searchTB.Text);

            DataSet ds = new DataSet();
            conn.Open();
            sda.Fill(ds, "Course");
            conn.Close();

            viewSearchedCourse.DataSource = ds.Tables["Course"];
        }

        private void course_Load(object sender, EventArgs e)
        {
            loadCourseData();
            loadCourseCredits();
           
            loadCourseTeachers();
            DisplayDataGridSearch();
        }

       
        private void loadCourseData()
        {

            string query = "SELECT * From Course";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Course");
            courseNameCMB.DataSource = ds.Tables["Course"];
            courseNameCMB.DisplayMember = "courseName";
           courseNameCMB.ValueMember = "courseId";
            conn.Close();

        }

        private void loadCourseCredits()
        {

            string query = "SELECT * From Course";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Course");
            courseCreditsCMB.DataSource = ds.Tables["Course"];
            courseCreditsCMB.DisplayMember = "courseCredits";
          courseCreditsCMB.ValueMember = "courseId";
            conn.Close();

        }


       

        private void loadCourseTeachers()
        {
            string query = "SELECT * From Course";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Course");
           courseTeacherCMB.DataSource = ds.Tables["Course"];
            courseTeacherCMB.DisplayMember = "courseTeacher";
            courseTeacherCMB.ValueMember = "courseId";
            conn.Close();


        }

        private void register_Click(object sender, EventArgs e)
        {
            
            string query = "INSERT INTO Course (courseId, courseName, courseCredits, courseTeacher) VALUES (@id, @name, @credits, @teacher)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", courseIdTB.Text);
                cmd.Parameters.AddWithValue("@name", courseNameCMB.Text);  
                cmd.Parameters.AddWithValue("@credits", courseCreditsCMB.Text);  
                cmd.Parameters.AddWithValue("@teacher", courseTeacherCMB.Text);  

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    DisplayDataGrid();  // Refresh the data grid after the insertion
                }
            }
        }

        private void DisplayDataGrid()
        {
            string query = "SELECT * FROM Course";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Course");
            DataGrid.DataSource = ds.Tables["Course"];
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            DisplayDataGridSearch();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Course SET " +
               "courseName = @cName, courseCredits = @cCredits, courseTeacher = @cTeacher WHERE courseId = @courseId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cName", courseNameCMB.Text.Trim());
            cmd.Parameters.AddWithValue("@cCredits", courseCreditsCMB.Text.Trim());
            cmd.Parameters.AddWithValue("@cTeacher", courseTeacherCMB.Text.Trim());
            cmd.Parameters.AddWithValue("@courseId", courseIdTB.Text.Trim());


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayDataGrid();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Course WHERE courseId = @courseId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@courseId", courseIdTB.Text.Trim());

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Course deleted successfully!");
            }
            else
            {
                MessageBox.Show("No course found with the given Course ID.");
            }

            DisplayDataGrid();  
        }

        private void view_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Course (courseId, courseName, courseCredits, courseTeacher) VALUES (@id, @name, @credits, @teacher)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", courseIdTB.Text);
                cmd.Parameters.AddWithValue("@name", courseNameCMB.Text);
                cmd.Parameters.AddWithValue("@credits", courseCreditsCMB.Text);
                cmd.Parameters.AddWithValue("@teacher", courseTeacherCMB.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    DisplayDataGrid();  // Refresh the data grid after the insertion
                }
            }
        }

        private void courseNameCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courseCreditsCMB_SelectedIndexChanged(object sender, EventArgs e)
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

                string filePath = "C:\\Users\\Public\\RegistrationReport.xlsx";

                // Enable EPPlus license (required for newer versions)
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            


                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Registration Report");

                    // Set headers
                    worksheet.Cells[1, 1].Value = "Registration Number";
                    worksheet.Cells[1, 2].Value = "Student";
                    worksheet.Cells[1, 3].Value = "Course";
                    worksheet.Cells[1, 4].Value = "Semester";
                    worksheet.Cells[1, 5].Value = "Academic Year";

                    // Load data from DataTable to Excel
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = dt.Rows[i]["registrationNumber"];
                        worksheet.Cells[i + 2, 2].Value = dt.Rows[i]["student"];
                        worksheet.Cells[i + 2, 3].Value = dt.Rows[i]["course"];
                        worksheet.Cells[i + 2, 4].Value = dt.Rows[i]["semester"];
                        worksheet.Cells[i + 2, 5].Value = dt.Rows[i]["academicYear"];
                    }

                    // Auto-fit columns
                    worksheet.Cells.AutoFitColumns();

                    // Save the Excel file
                    File.WriteAllBytes(filePath, excel.GetAsByteArray());
                }

                MessageBox.Show("Report generated successfully at " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
