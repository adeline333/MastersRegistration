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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SGKPF3E\\SQLEXPRESS;Initial Catalog=REGISTRATION;Integrated Security=True;TrustServerCertificate=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           

                try
                {
                    conn.Open();


                    string query = "SELECT studentName, password FROM STUDENT WHERE studentName = @StudentName AND password =HASHBYTES('SHA2_256', @passwords)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@StudentName", usernameLogin.Text.Trim());
                    command.Parameters.AddWithValue("@Passwords", passwordLogin.Text.Trim());

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login successful!");
                            Home home1 = new Home();
                            home1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            finally // ✅ Ensure connection is always closed
            {
                if (conn.State == ConnectionState.Open) // ✅ Check if still open
                {
                    conn.Close(); // ✅ Close the connection
                }
            }

        }

        private void helpLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up signUpForm= new sign_up();
            signUpForm.Show();

            //this.Hide();

            //login loginForm=new login();
            //loginForm.Hide();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
