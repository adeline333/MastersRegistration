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

namespace MastersRegistration
{
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGKPF3E\\SQLEXPRESS;Initial Catalog=REGISTRATION;Integrated Security=True;TrustServerCertificate=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            course sourse1 = new course();
            sourse1.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            faculty sourse = new faculty();
            sourse.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sear sourse = new sear();
            sourse.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            schedule one = new schedule();
            one.Show();
            this.Hide();
        }
        private void loadFaculties()
        {

            string query = "SELECT * From FACULTY";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "FACULTY");
            assignedFacultyCMB.DataSource = ds.Tables["FACULTY"];
            assignedFacultyCMB.DisplayMember = "facultyName";
            assignedFacultyCMB.ValueMember = "facultyId";
            conn.Close();

        }
        private void teacher_Load(object sender, EventArgs e)
        {
            loadFaculties();
            DisplayTeacherDataGridView();

        }

        private void DisplayTeacherDataGridView()
        {
            string query = "SELECT * FROM TEACHER";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Course");
           TeacherDataGridView.DataSource = ds.Tables["Course"];
            conn.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TEACHER (teacherId, teacherName, teacherFaculty, teacherInfo) VALUES " +
                "(@tId, @tName, @tFaculty, @tInfo)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tId", teacherIdTB.Text);
                cmd.Parameters.AddWithValue("@tName", teacherNameTB.Text);
                cmd.Parameters.AddWithValue("@tFaculty", assignedFacultyCMB.Text);
                cmd.Parameters.AddWithValue("@tInfo", contactInfoTB.Text);


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
                    DisplayTeacherDataGridView();  // Refresh the data grid after the insertion
                }
            }
        }
        private void DisplayDataGridSearch()
        {
            string query = "SELECT * FROM TEACHER WHERE teacherId = @tId";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@tId", searchTeacherTB.Text);

            DataSet ds = new DataSet();
            conn.Open();
            sda.Fill(ds, "TEACHER");
            conn.Close();

            teacherView.DataSource = ds.Tables["TEACHER"];
        }
        private void search_Click(object sender, EventArgs e)
        {
            DisplayDataGridSearch();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TEACHER SET " +
              "teacherName = @tName, teacherInfo = @tInfo, teacherFaculty=@tFaculty WHERE teacherId = @tId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tName", teacherNameTB.Text.Trim());
            cmd.Parameters.AddWithValue("@tinfo", contactInfoTB.Text.Trim());
            cmd.Parameters.AddWithValue("@tFaculty", assignedFacultyCMB.Text.Trim());
            cmd.Parameters.AddWithValue("@tId", teacherIdTB.Text.Trim());


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayTeacherDataGridView();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TEACHER WHERE teacherId = @tId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tId", teacherIdTB.Text.Trim());

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("teacher deleted successfully!");
            }
            else
            {
                MessageBox.Show("No teacher found with the given teacher ID.");
            }

            DisplayTeacherDataGridView();
        }

        private void View_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TEACHER (teacherId, teacherName, teacherFaculty, teacherInfo) VALUES " +
               "(@tId, @tName, @tFaculty, @tInfo)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tId", teacherIdTB.Text);
                cmd.Parameters.AddWithValue("@tName", teacherNameTB.Text);
                cmd.Parameters.AddWithValue("@tFaculty", assignedFacultyCMB.Text);
                cmd.Parameters.AddWithValue("@tInfo", contactInfoTB.Text);


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
                    DisplayTeacherDataGridView();  // Refresh the data grid after the insertion
                }
            }
        }
    }
    }

