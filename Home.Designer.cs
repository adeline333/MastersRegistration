namespace MastersRegistration
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.logIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.teacher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "MASTER\'S REGISTRATION ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.course.Location = new System.Drawing.Point(225, 95);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(87, 23);
            this.course.TabIndex = 1;
            this.course.Text = "COURSE";
            this.course.UseVisualStyleBackColor = false;
            this.course.Click += new System.EventHandler(this.course_Click);
            // 
            // faculty
            // 
            this.faculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.faculty.Location = new System.Drawing.Point(408, 95);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(87, 23);
            this.faculty.TabIndex = 2;
            this.faculty.Text = "FACULTY";
            this.faculty.UseVisualStyleBackColor = false;
            this.faculty.Click += new System.EventHandler(this.faculty_Click);
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logIn.Location = new System.Drawing.Point(267, 329);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(87, 23);
            this.logIn.TabIndex = 3;
            this.logIn.Text = "LOG IN";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.button3_Click);
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signUp.Location = new System.Drawing.Point(439, 329);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 23);
            this.signUp.TabIndex = 4;
            this.signUp.Text = "SIGN UP";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.button4_Click);
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registration.Location = new System.Drawing.Point(30, 95);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(109, 23);
            this.registration.TabIndex = 5;
            this.registration.Text = "REGISTRATION";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // schedule
            // 
            this.schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.schedule.Location = new System.Drawing.Point(757, 95);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(97, 23);
            this.schedule.TabIndex = 6;
            this.schedule.Text = "SCHEDULE";
            this.schedule.UseVisualStyleBackColor = false;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // teacher
            // 
            this.teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.teacher.Location = new System.Drawing.Point(598, 95);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(75, 23);
            this.teacher.TabIndex = 7;
            this.teacher.Text = "TEACHER";
            this.teacher.UseVisualStyleBackColor = false;
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(144, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "\"© 2025 My Master\'s registration | Contact: myregistrationl@gmail.com\"\n\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(240, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "WELCOME!!!!!!!";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.course);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button course;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button teacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}