namespace MastersRegistration
{
    partial class teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.delete = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.assignedFacultyCMB = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.assignedFaculty = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contactInfo = new System.Windows.Forms.Label();
            this.contactInfoTB = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.teacherNameTB = new System.Windows.Forms.TextBox();
            this.teacherName = new System.Windows.Forms.Label();
            this.teacherId = new System.Windows.Forms.Label();
            this.teacherIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.TeacherDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherView = new System.Windows.Forms.DataGridView();
            this.searchTeacherTB = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.assignedFacultyCMB);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.assignedFaculty);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.contactInfo);
            this.panel1.Controls.Add(this.contactInfoTB);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.teacherNameTB);
            this.panel1.Controls.Add(this.teacherName);
            this.panel1.Controls.Add(this.teacherId);
            this.panel1.Controls.Add(this.teacherIdTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 229);
            this.panel1.TabIndex = 17;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(586, 210);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(52, 13);
            this.linkLabel4.TabIndex = 21;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Schedule";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Info;
            this.delete.Location = new System.Drawing.Point(449, 152);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(135, 38);
            this.delete.TabIndex = 28;
            this.delete.Text = "Delete Teacher";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(586, 183);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
            this.linkLabel3.TabIndex = 20;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "registration";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // assignedFacultyCMB
            // 
            this.assignedFacultyCMB.FormattingEnabled = true;
            this.assignedFacultyCMB.Location = new System.Drawing.Point(508, 86);
            this.assignedFacultyCMB.Name = "assignedFacultyCMB";
            this.assignedFacultyCMB.Size = new System.Drawing.Size(142, 21);
            this.assignedFacultyCMB.TabIndex = 27;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(597, 152);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(41, 13);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Faculty";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // assignedFaculty
            // 
            this.assignedFaculty.AutoSize = true;
            this.assignedFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedFaculty.Location = new System.Drawing.Point(376, 87);
            this.assignedFaculty.Name = "assignedFaculty";
            this.assignedFaculty.Size = new System.Drawing.Size(126, 16);
            this.assignedFaculty.TabIndex = 25;
            this.assignedFaculty.Text = "Assigned Faculty";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(597, 124);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Course";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // contactInfo
            // 
            this.contactInfo.AutoSize = true;
            this.contactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo.Location = new System.Drawing.Point(376, 44);
            this.contactInfo.Name = "contactInfo";
            this.contactInfo.Size = new System.Drawing.Size(88, 16);
            this.contactInfo.TabIndex = 24;
            this.contactInfo.Text = "Contact Info";
            // 
            // contactInfoTB
            // 
            this.contactInfoTB.Location = new System.Drawing.Point(508, 44);
            this.contactInfoTB.Name = "contactInfoTB";
            this.contactInfoTB.Size = new System.Drawing.Size(142, 20);
            this.contactInfoTB.TabIndex = 23;
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
            this.update.Text = "Update \r\n(Edit Teacher Info)";
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
            this.register.Text = "Register \r\n(Add teacher)";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // teacherNameTB
            // 
            this.teacherNameTB.Location = new System.Drawing.Point(127, 87);
            this.teacherNameTB.Name = "teacherNameTB";
            this.teacherNameTB.Size = new System.Drawing.Size(136, 20);
            this.teacherNameTB.TabIndex = 16;
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherName.Location = new System.Drawing.Point(1, 87);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(110, 16);
            this.teacherName.TabIndex = 15;
            this.teacherName.Text = "Teacher Name";
            // 
            // teacherId
            // 
            this.teacherId.AutoSize = true;
            this.teacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherId.Location = new System.Drawing.Point(1, 41);
            this.teacherId.Name = "teacherId";
            this.teacherId.Size = new System.Drawing.Size(84, 16);
            this.teacherId.TabIndex = 14;
            this.teacherId.Text = "Teacher ID";
            // 
            // teacherIdTB
            // 
            this.teacherIdTB.Location = new System.Drawing.Point(127, 41);
            this.teacherIdTB.Name = "teacherIdTB";
            this.teacherIdTB.Size = new System.Drawing.Size(136, 20);
            this.teacherIdTB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEACHER";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.SeaGreen;
            this.search.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Location = new System.Drawing.Point(23, 269);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(114, 38);
            this.search.TabIndex = 20;
            this.search.Text = "Search\r\n(Find Teacher)";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // TeacherDataGridView
            // 
            this.TeacherDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDataGridView.Location = new System.Drawing.Point(347, 283);
            this.TeacherDataGridView.Name = "TeacherDataGridView";
            this.TeacherDataGridView.Size = new System.Drawing.Size(441, 167);
            this.TeacherDataGridView.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Teacher details";
            // 
            // teacherView
            // 
            this.teacherView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherView.Location = new System.Drawing.Point(12, 313);
            this.teacherView.Name = "teacherView";
            this.teacherView.Size = new System.Drawing.Size(242, 137);
            this.teacherView.TabIndex = 18;
            // 
            // searchTeacherTB
            // 
            this.searchTeacherTB.Location = new System.Drawing.Point(143, 279);
            this.searchTeacherTB.Name = "searchTeacherTB";
            this.searchTeacherTB.Size = new System.Drawing.Size(136, 20);
            this.searchTeacherTB.TabIndex = 21;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(536, 247);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 22;
            this.View.Text = "view";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.View);
            this.Controls.Add(this.searchTeacherTB);
            this.Controls.Add(this.teacherView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TeacherDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Name = "teacher";
            this.Load += new System.EventHandler(this.teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox teacherNameTB;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Label teacherId;
        private System.Windows.Forms.TextBox teacherIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TeacherDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label assignedFaculty;
        private System.Windows.Forms.Label contactInfo;
        private System.Windows.Forms.TextBox contactInfoTB;
        private System.Windows.Forms.ComboBox assignedFacultyCMB;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.DataGridView teacherView;
        private System.Windows.Forms.TextBox searchTeacherTB;
        private System.Windows.Forms.Button View;
    }
}