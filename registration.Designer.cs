namespace MastersRegistration
{
    partial class sear
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.regNoTB = new System.Windows.Forms.TextBox();
            this.regNo = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.courseCMB = new System.Windows.Forms.ComboBox();
            this.studentCMB = new System.Windows.Forms.ComboBox();
            this.academicYear = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.semesterTB = new System.Windows.Forms.TextBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.registrationGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.dataGridSearch = new System.Windows.Forms.DataGridView();
            this.geneerateReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.regNoTB);
            this.panel1.Controls.Add(this.regNo);
            this.panel1.Controls.Add(this.dateTime1);
            this.panel1.Controls.Add(this.courseCMB);
            this.panel1.Controls.Add(this.studentCMB);
            this.panel1.Controls.Add(this.academicYear);
            this.panel1.Controls.Add(this.semester);
            this.panel1.Controls.Add(this.semesterTB);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.course);
            this.panel1.Controls.Add(this.student);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 229);
            this.panel1.TabIndex = 23;
            // 
            // regNoTB
            // 
            this.regNoTB.Location = new System.Drawing.Point(90, 40);
            this.regNoTB.Name = "regNoTB";
            this.regNoTB.Size = new System.Drawing.Size(136, 20);
            this.regNoTB.TabIndex = 43;
            // 
            // regNo
            // 
            this.regNo.AutoSize = true;
            this.regNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNo.Location = new System.Drawing.Point(3, 46);
            this.regNo.Name = "regNo";
            this.regNo.Size = new System.Drawing.Size(50, 16);
            this.regNo.TabIndex = 42;
            this.regNo.Text = "regNo";
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(146, 116);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(200, 20);
            this.dateTime1.TabIndex = 41;
            // 
            // courseCMB
            // 
            this.courseCMB.FormattingEnabled = true;
            this.courseCMB.Location = new System.Drawing.Point(100, 63);
            this.courseCMB.Name = "courseCMB";
            this.courseCMB.Size = new System.Drawing.Size(121, 21);
            this.courseCMB.TabIndex = 40;
            this.courseCMB.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // studentCMB
            // 
            this.studentCMB.FormattingEnabled = true;
            this.studentCMB.Location = new System.Drawing.Point(90, 13);
            this.studentCMB.Name = "studentCMB";
            this.studentCMB.Size = new System.Drawing.Size(121, 21);
            this.studentCMB.TabIndex = 39;
            // 
            // academicYear
            // 
            this.academicYear.AutoSize = true;
            this.academicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicYear.Location = new System.Drawing.Point(1, 116);
            this.academicYear.Name = "academicYear";
            this.academicYear.Size = new System.Drawing.Size(108, 16);
            this.academicYear.TabIndex = 35;
            this.academicYear.Text = "academicYear";
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.Location = new System.Drawing.Point(-3, 89);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(73, 16);
            this.semester.TabIndex = 34;
            this.semester.Text = "Semester";
            this.semester.Click += new System.EventHandler(this.label2_Click);
            // 
            // semesterTB
            // 
            this.semesterTB.Location = new System.Drawing.Point(100, 88);
            this.semesterTB.Name = "semesterTB";
            this.semesterTB.Size = new System.Drawing.Size(136, 20);
            this.semesterTB.TabIndex = 33;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(647, 116);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(52, 13);
            this.linkLabel4.TabIndex = 32;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Schedule";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(647, 89);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
            this.linkLabel3.TabIndex = 31;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "registration";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(658, 58);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(41, 13);
            this.linkLabel2.TabIndex = 30;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Faculty";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(658, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Course";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Completed",
            "In Progress",
            "Upcoming"});
            this.comboBox1.Location = new System.Drawing.Point(482, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(362, 63);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(50, 16);
            this.status.TabIndex = 25;
            this.status.Text = "Status";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Info;
            this.delete.Location = new System.Drawing.Point(537, 152);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(135, 38);
            this.delete.TabIndex = 22;
            this.delete.Text = "Delete registration";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.ForestGreen;
            this.update.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(271, 152);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(232, 38);
            this.update.TabIndex = 21;
            this.update.Text = "Update \r\n(Modify registration)";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.CornflowerBlue;
            this.register.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register.Location = new System.Drawing.Point(4, 152);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(239, 38);
            this.register.TabIndex = 19;
            this.register.Text = "Register \r\n(Register student for the  course)";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.Location = new System.Drawing.Point(1, 68);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(56, 16);
            this.course.TabIndex = 15;
            this.course.Text = "Course";
            this.course.Click += new System.EventHandler(this.courseCode_Click);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(3, 15);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(59, 16);
            this.student.TabIndex = 14;
            this.student.Text = "Student";
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.CornflowerBlue;
            this.view.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.view.Location = new System.Drawing.Point(612, 247);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(98, 27);
            this.view.TabIndex = 38;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // registrationGridView
            // 
            this.registrationGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationGridView.Location = new System.Drawing.Point(360, 282);
            this.registrationGridView.Name = "registrationGridView";
            this.registrationGridView.Size = new System.Drawing.Size(443, 167);
            this.registrationGridView.TabIndex = 22;
            this.registrationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registrationGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Course details";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.search.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Location = new System.Drawing.Point(2, 260);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(98, 27);
            this.search.TabIndex = 24;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(106, 264);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(95, 20);
            this.searchTB.TabIndex = 44;
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Location = new System.Drawing.Point(2, 293);
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.Size = new System.Drawing.Size(199, 150);
            this.dataGridSearch.TabIndex = 25;
            this.dataGridSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // geneerateReport
            // 
            this.geneerateReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.geneerateReport.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geneerateReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.geneerateReport.Location = new System.Drawing.Point(221, 252);
            this.geneerateReport.Name = "geneerateReport";
            this.geneerateReport.Size = new System.Drawing.Size(153, 27);
            this.geneerateReport.TabIndex = 45;
            this.geneerateReport.Text = "GenerateReport";
            this.geneerateReport.UseVisualStyleBackColor = false;
            this.geneerateReport.Click += new System.EventHandler(this.geneerateReport_Click);
            // 
            // sear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geneerateReport);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.dataGridSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.registrationGridView);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label5);
            this.Name = "sear";
            this.Text = "registration";
            this.Load += new System.EventHandler(this.sear_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView registrationGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label academicYear;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.TextBox semesterTB;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox studentCMB;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.ComboBox courseCMB;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.Label regNo;
        private System.Windows.Forms.TextBox regNoTB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DataGridView dataGridSearch;
        private System.Windows.Forms.Button geneerateReport;
    }
}