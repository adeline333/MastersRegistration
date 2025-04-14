namespace MastersRegistration
{
    partial class sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentIdBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.DOBBox = new System.Windows.Forms.DateTimePicker();
            this.DOB = new System.Windows.Forms.Label();
            this.passwordsBox = new System.Windows.Forms.TextBox();
            this.passwords = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.Label();
            this.studentNameBox = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "SIGN UP\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.studentIdBox);
            this.panel1.Controls.Add(this.confirmPasswordBox);
            this.panel1.Controls.Add(this.confirmPassword);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.linkLabel5);
            this.panel1.Controls.Add(this.DOBBox);
            this.panel1.Controls.Add(this.DOB);
            this.panel1.Controls.Add(this.passwordsBox);
            this.panel1.Controls.Add(this.passwords);
            this.panel1.Controls.Add(this.studentId);
            this.panel1.Controls.Add(this.studentNameBox);
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Location = new System.Drawing.Point(163, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 271);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // studentIdBox
            // 
            this.studentIdBox.Location = new System.Drawing.Point(48, 84);
            this.studentIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentIdBox.Name = "studentIdBox";
            this.studentIdBox.Size = new System.Drawing.Size(262, 20);
            this.studentIdBox.TabIndex = 28;
            this.studentIdBox.TextChanged += new System.EventHandler(this.studentIdCMB_TextChanged);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Location = new System.Drawing.Point(48, 186);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.PasswordChar = '*';
            this.confirmPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordBox.TabIndex = 27;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(45, 170);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(90, 13);
            this.confirmPassword.TabIndex = 26;
            this.confirmPassword.Text = "Confirm password";
            this.confirmPassword.Click += new System.EventHandler(this.label7_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(381, 170);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(52, 13);
            this.linkLabel4.TabIndex = 25;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Schedule";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(381, 143);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(58, 13);
            this.linkLabel3.TabIndex = 24;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "registration";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(392, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Faculty";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(392, 84);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(40, 13);
            this.linkLabel5.TabIndex = 22;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Course";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // DOBBox
            // 
            this.DOBBox.Location = new System.Drawing.Point(48, 233);
            this.DOBBox.Name = "DOBBox";
            this.DOBBox.Size = new System.Drawing.Size(299, 20);
            this.DOBBox.TabIndex = 16;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(46, 217);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(30, 13);
            this.DOB.TabIndex = 13;
            this.DOB.Text = "DOB";
            this.DOB.Click += new System.EventHandler(this.label6_Click);
            // 
            // passwordsBox
            // 
            this.passwordsBox.Location = new System.Drawing.Point(48, 136);
            this.passwordsBox.Name = "passwordsBox";
            this.passwordsBox.Size = new System.Drawing.Size(199, 20);
            this.passwordsBox.TabIndex = 12;
            // 
            // passwords
            // 
            this.passwords.AutoSize = true;
            this.passwords.Location = new System.Drawing.Point(45, 112);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(58, 13);
            this.passwords.TabIndex = 11;
            this.passwords.Text = "Passwords";
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Location = new System.Drawing.Point(46, 68);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(51, 13);
            this.studentId.TabIndex = 9;
            this.studentId.Text = "studentId";
            // 
            // studentNameBox
            // 
            this.studentNameBox.Location = new System.Drawing.Point(48, 28);
            this.studentNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentNameBox.Name = "studentNameBox";
            this.studentNameBox.Size = new System.Drawing.Size(262, 20);
            this.studentNameBox.TabIndex = 6;
            this.studentNameBox.Text = "mu";
            this.studentNameBox.TextChanged += new System.EventHandler(this.studentNameBox_TextChanged);
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(45, 11);
            this.studentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(90, 13);
            this.studentName.TabIndex = 5;
            this.studentName.Text = "STUDENT Name";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(376, 351);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(159, 13);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Already have an  account/ login";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(237, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "SIGN UP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button2);
            this.Name = "sign_up";
            this.Text = "sign_up";
            this.Load += new System.EventHandler(this.sign_up_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox studentNameBox;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.TextBox passwordsBox;
        private System.Windows.Forms.Label passwords;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.DateTimePicker DOBBox;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox studentIdBox;
    }
}