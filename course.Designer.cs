namespace MastersRegistration
{
    partial class course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course));
            this.panel1 = new System.Windows.Forms.Panel();
            this.courseIdTB = new System.Windows.Forms.TextBox();
            this.courseNameCMB = new System.Windows.Forms.ComboBox();
            this.courseCreditsCMB = new System.Windows.Forms.ComboBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.courseTeacherCMB = new System.Windows.Forms.ComboBox();
            this.courseTeacher = new System.Windows.Forms.Label();
            this.courseCredits = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.courseName = new System.Windows.Forms.Label();
            this.courseId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.course_details = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.viewSearchedCourse = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSearchedCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.courseIdTB);
            this.panel1.Controls.Add(this.courseNameCMB);
            this.panel1.Controls.Add(this.courseCreditsCMB);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.courseTeacherCMB);
            this.panel1.Controls.Add(this.courseTeacher);
            this.panel1.Controls.Add(this.courseCredits);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.courseName);
            this.panel1.Controls.Add(this.courseId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 229);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // courseIdTB
            // 
            this.courseIdTB.Location = new System.Drawing.Point(108, 40);
            this.courseIdTB.Name = "courseIdTB";
            this.courseIdTB.Size = new System.Drawing.Size(142, 20);
            this.courseIdTB.TabIndex = 34;
            // 
            // courseNameCMB
            // 
            this.courseNameCMB.FormattingEnabled = true;
            this.courseNameCMB.Location = new System.Drawing.Point(108, 82);
            this.courseNameCMB.Name = "courseNameCMB";
            this.courseNameCMB.Size = new System.Drawing.Size(142, 21);
            this.courseNameCMB.TabIndex = 33;
            this.courseNameCMB.SelectedIndexChanged += new System.EventHandler(this.courseNameCMB_SelectedIndexChanged);
            // 
            // courseCreditsCMB
            // 
            this.courseCreditsCMB.FormattingEnabled = true;
            this.courseCreditsCMB.Location = new System.Drawing.Point(508, 41);
            this.courseCreditsCMB.Name = "courseCreditsCMB";
            this.courseCreditsCMB.Size = new System.Drawing.Size(142, 21);
            this.courseCreditsCMB.TabIndex = 32;
            this.courseCreditsCMB.SelectedIndexChanged += new System.EventHandler(this.courseCreditsCMB_SelectedIndexChanged);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(609, 211);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(52, 13);
            this.linkLabel4.TabIndex = 31;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Schedule";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(609, 184);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
            this.linkLabel3.TabIndex = 30;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "registration";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(620, 153);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(41, 13);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Faculty";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(620, 125);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Course";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // courseTeacherCMB
            // 
            this.courseTeacherCMB.FormattingEnabled = true;
            this.courseTeacherCMB.Location = new System.Drawing.Point(508, 86);
            this.courseTeacherCMB.Name = "courseTeacherCMB";
            this.courseTeacherCMB.Size = new System.Drawing.Size(142, 21);
            this.courseTeacherCMB.TabIndex = 27;
            // 
            // courseTeacher
            // 
            this.courseTeacher.AutoSize = true;
            this.courseTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTeacher.Location = new System.Drawing.Point(376, 87);
            this.courseTeacher.Name = "courseTeacher";
            this.courseTeacher.Size = new System.Drawing.Size(118, 16);
            this.courseTeacher.TabIndex = 25;
            this.courseTeacher.Text = "Course Teacher";
            // 
            // courseCredits
            // 
            this.courseCredits.AutoSize = true;
            this.courseCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCredits.Location = new System.Drawing.Point(376, 44);
            this.courseCredits.Name = "courseCredits";
            this.courseCredits.Size = new System.Drawing.Size(107, 16);
            this.courseCredits.TabIndex = 24;
            this.courseCredits.Text = "Course credits";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Info;
            this.delete.Location = new System.Drawing.Point(438, 152);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(135, 38);
            this.delete.TabIndex = 22;
            this.delete.Text = "Delete course";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.ForestGreen;
            this.update.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(282, 152);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(135, 38);
            this.update.TabIndex = 21;
            this.update.Text = "Update \r\n(Update course)";
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
            this.register.Size = new System.Drawing.Size(117, 38);
            this.register.TabIndex = 19;
            this.register.Text = "Register \r\n(Add  course)";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.Location = new System.Drawing.Point(1, 87);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(101, 16);
            this.courseName.TabIndex = 15;
            this.courseName.Text = "Course Name";
            // 
            // courseId
            // 
            this.courseId.AutoSize = true;
            this.courseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseId.Location = new System.Drawing.Point(1, 41);
            this.courseId.Name = "courseId";
            this.courseId.Size = new System.Drawing.Size(83, 16);
            this.courseId.TabIndex = 14;
            this.courseId.Text = "Course ID  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.SeaGreen;
            this.search.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Location = new System.Drawing.Point(31, 247);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(114, 38);
            this.search.TabIndex = 20;
            this.search.Text = "Search\r\n(Find course)";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(315, 292);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(470, 149);
            this.DataGrid.TabIndex = 19;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // course_details
            // 
            this.course_details.AutoSize = true;
            this.course_details.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_details.Location = new System.Drawing.Point(402, 261);
            this.course_details.Name = "course_details";
            this.course_details.Size = new System.Drawing.Size(104, 20);
            this.course_details.TabIndex = 18;
            this.course_details.Text = "Course details";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(151, 257);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(114, 20);
            this.searchTB.TabIndex = 35;
            // 
            // viewSearchedCourse
            // 
            this.viewSearchedCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSearchedCourse.Location = new System.Drawing.Point(12, 292);
            this.viewSearchedCourse.Name = "viewSearchedCourse";
            this.viewSearchedCourse.Size = new System.Drawing.Size(253, 150);
            this.viewSearchedCourse.TabIndex = 36;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.CornflowerBlue;
            this.view.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.view.Location = new System.Drawing.Point(552, 257);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(98, 27);
            this.view.TabIndex = 39;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(298, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 27);
            this.button1.TabIndex = 40;
            this.button1.Text = "REG REPORT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.viewSearchedCourse);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.course_details);
            this.Controls.Add(this.search);
            this.Name = "course";
            this.Text = "course";
            this.Load += new System.EventHandler(this.course_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSearchedCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox courseTeacherCMB;
        private System.Windows.Forms.Label courseTeacher;
        private System.Windows.Forms.Label courseCredits;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label courseId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label course_details;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox courseCreditsCMB;
        private System.Windows.Forms.ComboBox courseNameCMB;
        private System.Windows.Forms.TextBox courseIdTB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DataGridView viewSearchedCourse;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button button1;
    }
}