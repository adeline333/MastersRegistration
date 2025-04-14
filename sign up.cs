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

namespace MastersRegistration
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login one = new login();
            one.Show();


        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            course sourse1 = new course();
            sourse1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //retrieving connection string
        // string connectionString = ConfigurationManager.ConnectionStrings["myConString"].ConnectionString;

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-SGKPF3E\\SQLEXPRESS;Initial Catalog=REGISTRATION;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string querry = "INSERT INTO STUDENT (studentName, studentId,password,confirmPassword,dateOfBirth) " +
                    "VALUES (@studentName, @studentId,HASHBYTES('SHA2_256', @passwords), @confirmPassword, @DOB)";
                SqlCommand command = new SqlCommand(querry, connection);
                command.Parameters.AddWithValue("@studentName", studentNameBox.Text);
                command.Parameters.AddWithValue("@studentId", studentIdBox.Text);
                command.Parameters.AddWithValue("@passwords", passwordsBox.Text);
                command.Parameters.AddWithValue("@confirmPassword", confirmPasswordBox.Text);
                command.Parameters.AddWithValue("@DOB", DOBBox.Value);
               // command.ExecuteNonQuery(); //returns number of affected rows
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {

                    MessageBox.Show("Student registered successfully");
                    //after being registered take us to login
                    login login = new login();
                    login.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Student not registered");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }


    

        private void studentIdCMB_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }
    }
}
