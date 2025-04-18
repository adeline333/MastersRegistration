using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace MastersRegistration
{
    public partial class faculty : Form
    {
        public faculty()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGKPF3E\\SQLEXPRESS;Initial Catalog=REGISTRATION;Integrated Security=True;TrustServerCertificate=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void teacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           teacher teacher1 = new teacher();
            teacher1.Show();
            

        }

        private void faculty_Load(object sender, EventArgs e)
        {

        }
        private void DisplayFacultyDataGridView()
        {
            string query = "SELECT * FROM FACULTY";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "FACULTY");
            facultyDataGridView.DataSource = ds.Tables["FACULTY"];
            conn.Close();
        }
        private void Register_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO FACULTY (facultyId, facultyName, facultyDescription) VALUES (@fId, @fName, @fDescription)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fId", facultyIdTB.Text);
                cmd.Parameters.AddWithValue("@fName", facultyNameTB.Text);
                cmd.Parameters.AddWithValue("@fDescription", facultyDescriptionRTB.Text);


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
                    DisplayFacultyDataGridView();  // Refresh the data grid after the insertion
                }
            }
        }
        private void DisplayDataGridSearch()
        {
            string query = "SELECT * FROM FACULTY WHERE facultyId = @fId";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@fId", searchTB.Text);

            DataSet ds = new DataSet();
            conn.Open();
            sda.Fill(ds, "FACULTY");
            conn.Close();

            FacultySearchGrid.DataSource = ds.Tables["FACULTY"];
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DisplayDataGridSearch();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE FACULTY SET " +
              "facultyName = @fName, facultyDescription = @fDescription WHERE facultyId = @fId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@fName", facultyNameTB.Text.Trim());
            cmd.Parameters.AddWithValue("@fDescription", facultyDescriptionRTB.Text.Trim());
            
            cmd.Parameters.AddWithValue("@fId", facultyIdTB.Text.Trim());


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayFacultyDataGridView();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM FACULTY WHERE facultyId = @fId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@fId", facultyIdTB.Text.Trim());

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("faculty deleted successfully!");
            }
            else
            {
                MessageBox.Show("No FACULTY found with the givenFACULTY ID.");
            }

            DisplayFacultyDataGridView();
        }

        private void view_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO FACULTY (facultyId, facultyName, facultyDescription) VALUES (@fId, @fName, @fDescription)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fId", facultyIdTB.Text);
                cmd.Parameters.AddWithValue("@fName", facultyNameTB.Text);
                cmd.Parameters.AddWithValue("@fDescription", facultyDescriptionRTB.Text);


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
                    DisplayFacultyDataGridView();  // Refresh the data grid after the insertion
                }
            }
        }

        private void GenerateReport()
        {
            
        
                try
                {
                    string query = "SELECT * FROM faculty";
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
                        ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Faculty Report");

                        // Set headers
                        worksheet.Cells[1, 1].Value = "facultyId";
                        worksheet.Cells[1, 2].Value = "facultyName";
                        worksheet.Cells[1, 3].Value = "facultyDescription";


                        // Load data from DataTable to Excel
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            worksheet.Cells[i + 2, 1].Value = dt.Rows[i]["facultyId"];
                            worksheet.Cells[i + 2, 2].Value = dt.Rows[i]["facultyName"];
                            worksheet.Cells[i + 2, 3].Value = dt.Rows[i]["facultyDescription"];

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

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
