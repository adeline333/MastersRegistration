using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastersRegistration
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login one = new login();
            one.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            sign_up signUpForm = new sign_up();
            signUpForm.Show();

        }

        private void schedule_Click(object sender, EventArgs e)
        {

            schedule one = new schedule();
            one.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void course_Click(object sender, EventArgs e)
        {
            course sourse1 = new course();
            sourse1.Show();
           


        }

        private void registration_Click(object sender, EventArgs e)
        {

            sear sourse = new sear();
            sourse.Show();
            

        }

        private void faculty_Click(object sender, EventArgs e)
        {
           faculty teacher1 = new faculty();
            teacher1.Show();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            teacher teacher1 = new teacher();
            teacher1.Show();
        }
    }
}
