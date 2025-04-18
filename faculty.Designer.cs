namespace MastersRegistration
{
    partial class faculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faculty));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.facultyDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.facultyDescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.facultyDescription = new System.Windows.Forms.Label();
            this.facultyNameTB = new System.Windows.Forms.TextBox();
            this.facultyName = new System.Windows.Forms.Label();
            this.facultyId = new System.Windows.Forms.Label();
            this.facultyIdTB = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.teacher = new System.Windows.Forms.LinkLabel();
            this.FacultySearchGrid = new System.Windows.Forms.DataGridView();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacultySearchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACULTY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Faculty details";
            // 
            // facultyDataGridView
            // 
            this.facultyDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.facultyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyDataGridView.Location = new System.Drawing.Point(344, 279);
            this.facultyDataGridView.Name = "facultyDataGridView";
            this.facultyDataGridView.Size = new System.Drawing.Size(444, 167);
            this.facultyDataGridView.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.facultyDescriptionRTB);
            this.panel1.Controls.Add(this.facultyDescription);
            this.panel1.Controls.Add(this.facultyNameTB);
            this.panel1.Controls.Add(this.facultyName);
            this.panel1.Controls.Add(this.facultyId);
            this.panel1.Controls.Add(this.facultyIdTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(75, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 241);
            this.panel1.TabIndex = 14;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(560, 228);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(52, 13);
            this.linkLabel4.TabIndex = 28;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Schedule";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(560, 201);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
            this.linkLabel3.TabIndex = 27;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "registration";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(571, 170);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(41, 13);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Faculty";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(571, 142);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Course";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Info;
            this.delete.Location = new System.Drawing.Point(414, 152);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(135, 38);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete Faculty";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.ForestGreen;
            this.Update.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update.Location = new System.Drawing.Point(275, 152);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(107, 38);
            this.Update.TabIndex = 21;
            this.Update.Text = "Update \r\n(Edit Faculty Info)";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Register.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Register.Location = new System.Drawing.Point(4, 152);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(117, 38);
            this.Register.TabIndex = 19;
            this.Register.Text = "Register \r\n(Add faculty)";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // facultyDescriptionRTB
            // 
            this.facultyDescriptionRTB.Location = new System.Drawing.Point(312, 57);
            this.facultyDescriptionRTB.Name = "facultyDescriptionRTB";
            this.facultyDescriptionRTB.Size = new System.Drawing.Size(322, 73);
            this.facultyDescriptionRTB.TabIndex = 18;
            this.facultyDescriptionRTB.Text = "";
            // 
            // facultyDescription
            // 
            this.facultyDescription.AutoSize = true;
            this.facultyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyDescription.Location = new System.Drawing.Point(309, 38);
            this.facultyDescription.Name = "facultyDescription";
            this.facultyDescription.Size = new System.Drawing.Size(140, 16);
            this.facultyDescription.TabIndex = 17;
            this.facultyDescription.Text = "Faculty Description";
            // 
            // facultyNameTB
            // 
            this.facultyNameTB.Location = new System.Drawing.Point(107, 87);
            this.facultyNameTB.Name = "facultyNameTB";
            this.facultyNameTB.Size = new System.Drawing.Size(121, 20);
            this.facultyNameTB.TabIndex = 16;
            // 
            // facultyName
            // 
            this.facultyName.AutoSize = true;
            this.facultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyName.Location = new System.Drawing.Point(1, 87);
            this.facultyName.Name = "facultyName";
            this.facultyName.Size = new System.Drawing.Size(102, 16);
            this.facultyName.TabIndex = 15;
            this.facultyName.Text = "Faculty Name";
            // 
            // facultyId
            // 
            this.facultyId.AutoSize = true;
            this.facultyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyId.Location = new System.Drawing.Point(1, 41);
            this.facultyId.Name = "facultyId";
            this.facultyId.Size = new System.Drawing.Size(76, 16);
            this.facultyId.TabIndex = 14;
            this.facultyId.Text = "Faculty ID";
            // 
            // facultyIdTB
            // 
            this.facultyIdTB.Location = new System.Drawing.Point(103, 40);
            this.facultyIdTB.Name = "facultyIdTB";
            this.facultyIdTB.Size = new System.Drawing.Size(125, 20);
            this.facultyIdTB.TabIndex = 13;
            this.facultyIdTB.Text = "56";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.SeaGreen;
            this.Search.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Search.Location = new System.Drawing.Point(12, 260);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(101, 38);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search\r\n(Find Faculty)";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(649, 260);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(47, 13);
            this.teacher.TabIndex = 15;
            this.teacher.TabStop = true;
            this.teacher.Text = "Teacher";
            this.teacher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teacher_LinkClicked);
            // 
            // FacultySearchGrid
            // 
            this.FacultySearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacultySearchGrid.Location = new System.Drawing.Point(-1, 304);
            this.FacultySearchGrid.Name = "FacultySearchGrid";
            this.FacultySearchGrid.Size = new System.Drawing.Size(317, 134);
            this.FacultySearchGrid.TabIndex = 21;
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(119, 270);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(156, 20);
            this.searchTB.TabIndex = 22;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.CornflowerBlue;
            this.view.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.view.Location = new System.Drawing.Point(702, 253);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(98, 27);
            this.view.TabIndex = 40;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(216, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 41;
            this.button2.Text = "REPORT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.FacultySearchGrid);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.facultyDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Search);
            this.Name = "faculty";
            this.Text = "faculty";
            this.Load += new System.EventHandler(this.faculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacultySearchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView facultyDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.RichTextBox facultyDescriptionRTB;
        private System.Windows.Forms.Label facultyDescription;
        private System.Windows.Forms.TextBox facultyNameTB;
        private System.Windows.Forms.Label facultyName;
        private System.Windows.Forms.Label facultyId;
        private System.Windows.Forms.TextBox facultyIdTB;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel teacher;
        private System.Windows.Forms.DataGridView FacultySearchGrid;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button button2;
    }
}