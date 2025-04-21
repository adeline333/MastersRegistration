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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MastersRegistration
{
    public partial class schedule : Form
    {
        public schedule()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGKPF3E\\SQLEXPRESS;Initial Catalog=REGISTRATION;Integrated Security=True;TrustServerCertificate=True");
        private void update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE SCHEDULE SET " +
             "lecturer = @lecturer, startDate = @start, endDate = @end WHERE courseId = @cId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@lecturer", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@start", dateTimePicker1.Text.Trim());
            cmd.Parameters.AddWithValue("@end", dateTimePicker2.Text.Trim());
            cmd.Parameters.AddWithValue("@cId", textBox1.Text.Trim());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayScheduleDataGridView();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            course sourse1 = new course();
            sourse1.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            schedule one = new schedule();
            one.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            teacher teacher1 = new teacher();
            teacher1.Show();
            this.Hide();
        }
        private void DisplayScheduleDataGridView()
        {
            string query = "SELECT * FROM SCHEDULE";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, " SCHEDULE");
            dataGridView1.DataSource = ds.Tables[" SCHEDULE"];
            conn.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SCHEDULE (courseId, lecturer, startDate, EndDate) VALUES (@SId, @SName, @SDescription,@SDescription2)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SId", textBox1.Text);
                cmd.Parameters.AddWithValue("@SName", textBox2.Text);
                cmd.Parameters.AddWithValue("@SDescription", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@SDescription2", dateTimePicker2.Text);


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
                    DisplayScheduleDataGridView();  // Refresh the data grid after the insertion
                }
            }
        }

        private void schedule_Load(object sender, EventArgs e)
        {

        }
        private void DisplayScheduleDataGridSearch()
        {

            string query = "SELECT * FROM SCHEDULE WHERE courseId = @cId";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@cId", searchTB.Text);

            DataSet ds = new DataSet();
            conn.Open();
            sda.Fill(ds, "SCHEDULE");
            conn.Close();

            dataGridView2.DataSource = ds.Tables["SCHEDULE"];
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM SCHEDULE WHERE courseId = @cId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cId", textBox1.Text.Trim());

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("schedule deleted successfully!");
            }
            else
            {
                MessageBox.Show("No FACULTY found with the givenFACULTY ID.");
            }

           DisplayScheduleDataGridView();
        }

        private void search_Click(object sender, EventArgs e)
        {
            DisplayScheduleDataGridSearch();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SCHEDULE (courseId, lecturer, startDate, EndDate) VALUES (@SId, @SName, @SDescription,@SDescription2)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SId", textBox1.Text);
                cmd.Parameters.AddWithValue("@SName", textBox2.Text);
                cmd.Parameters.AddWithValue("@SDescription", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@SDescription2", dateTimePicker2.Text);


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
                    DisplayScheduleDataGridView();  // Refresh the data grid after the insertion
                }
            }
        }
    }
    }

