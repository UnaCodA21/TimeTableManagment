namespace Class_Sheduling_System
{
    partial class CourseAssinment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAssinment));
            this.label1 = new System.Windows.Forms.Label();
            this.CbFaculty = new System.Windows.Forms.ComboBox();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbCourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbSubject = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbLecturer = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbRoom = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CBSemester = new System.Windows.Forms.ComboBox();
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.CbModeOfStudy = new System.Windows.Forms.ComboBox();
            this.modeOfStudyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GvClassAssingment = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CbTime = new System.Windows.Forms.ComboBox();
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtpClassAssingment = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeOfStudyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClassAssingment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(479, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Assingment ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CbFaculty
            // 
            this.CbFaculty.DataSource = this.facultyBindingSource;
            this.CbFaculty.DisplayMember = "Faculty1";
            this.CbFaculty.FormattingEnabled = true;
            this.CbFaculty.Location = new System.Drawing.Point(39, 166);
            this.CbFaculty.Name = "CbFaculty";
            this.CbFaculty.Size = new System.Drawing.Size(121, 21);
            this.CbFaculty.TabIndex = 1;
            this.CbFaculty.ValueMember = "Faculty_Id";
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(Class_Sheduling_System.Faculty);
            // 
            // CbCourse
            // 
            this.CbCourse.DataSource = this.courseBindingSource;
            this.CbCourse.DisplayMember = "Course_Name";
            this.CbCourse.FormattingEnabled = true;
            this.CbCourse.Location = new System.Drawing.Point(39, 220);
            this.CbCourse.Name = "CbCourse";
            this.CbCourse.Size = new System.Drawing.Size(121, 21);
            this.CbCourse.TabIndex = 1;
            this.CbCourse.ValueMember = "Course_Id";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Class_Sheduling_System.Course);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(71, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(69, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(67, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lecturer";
            // 
            // CbSubject
            // 
            this.CbSubject.DataSource = this.subjectBindingSource;
            this.CbSubject.DisplayMember = "Subject_Name";
            this.CbSubject.FormattingEnabled = true;
            this.CbSubject.Location = new System.Drawing.Point(39, 272);
            this.CbSubject.Name = "CbSubject";
            this.CbSubject.Size = new System.Drawing.Size(121, 21);
            this.CbSubject.TabIndex = 1;
            this.CbSubject.ValueMember = "Subject_Id";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Class_Sheduling_System.Subject);
            // 
            // CbLecturer
            // 
            this.CbLecturer.DataSource = this.lecturerBindingSource1;
            this.CbLecturer.DisplayMember = "Initial";
            this.CbLecturer.FormattingEnabled = true;
            this.CbLecturer.Location = new System.Drawing.Point(39, 328);
            this.CbLecturer.Name = "CbLecturer";
            this.CbLecturer.Size = new System.Drawing.Size(121, 21);
            this.CbLecturer.TabIndex = 1;
            this.CbLecturer.ValueMember = "Lecturer_Id";
            // 
            // lecturerBindingSource1
            // 
            this.lecturerBindingSource1.DataSource = typeof(Class_Sheduling_System.Lecturer);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(72, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(243, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Semester";
            // 
            // CbRoom
            // 
            this.CbRoom.DataSource = this.roomBindingSource;
            this.CbRoom.DisplayMember = "Room1";
            this.CbRoom.FormattingEnabled = true;
            this.CbRoom.Location = new System.Drawing.Point(39, 387);
            this.CbRoom.Name = "CbRoom";
            this.CbRoom.Size = new System.Drawing.Size(121, 21);
            this.CbRoom.TabIndex = 1;
            this.CbRoom.ValueMember = "Room_ID";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(Class_Sheduling_System.Room);
            // 
            // CBSemester
            // 
            this.CBSemester.DataSource = this.semesterBindingSource;
            this.CBSemester.DisplayMember = "Semester1";
            this.CBSemester.FormattingEnabled = true;
            this.CBSemester.Location = new System.Drawing.Point(221, 225);
            this.CBSemester.Name = "CBSemester";
            this.CBSemester.Size = new System.Drawing.Size(121, 21);
            this.CBSemester.TabIndex = 1;
            this.CBSemester.ValueMember = "Semester_Id";
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataSource = typeof(Class_Sheduling_System.Semester);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(221, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mode Of Study";
            // 
            // CbModeOfStudy
            // 
            this.CbModeOfStudy.DataSource = this.modeOfStudyBindingSource;
            this.CbModeOfStudy.DisplayMember = "ModeOfStudy1";
            this.CbModeOfStudy.FormattingEnabled = true;
            this.CbModeOfStudy.Location = new System.Drawing.Point(221, 166);
            this.CbModeOfStudy.Name = "CbModeOfStudy";
            this.CbModeOfStudy.Size = new System.Drawing.Size(121, 21);
            this.CbModeOfStudy.TabIndex = 1;
            this.CbModeOfStudy.ValueMember = "ModeOfStudy_Id";
            // 
            // modeOfStudyBindingSource
            // 
            this.modeOfStudyBindingSource.DataSource = typeof(Class_Sheduling_System.ModeOfStudy);
            // 
            // GvClassAssingment
            // 
            this.GvClassAssingment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvClassAssingment.Location = new System.Drawing.Point(364, 143);
            this.GvClassAssingment.Name = "GvClassAssingment";
            this.GvClassAssingment.Size = new System.Drawing.Size(479, 325);
            this.GvClassAssingment.TabIndex = 2;
            this.GvClassAssingment.SelectionChanged += new System.EventHandler(this.GvClassAssingment_selectionChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnSave.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnSave.Location = new System.Drawing.Point(39, 434);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 34);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnUpdate.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnUpdate.Location = new System.Drawing.Point(115, 434);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(70, 34);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnDelete.Location = new System.Drawing.Point(191, 434);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 34);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Yellow;
            this.BtnClear.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnClear.Location = new System.Drawing.Point(268, 434);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(71, 34);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(253, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Time";
            // 
            // CbTime
            // 
            this.CbTime.DataSource = this.timeBindingSource;
            this.CbTime.DisplayMember = "Time1";
            this.CbTime.FormattingEnabled = true;
            this.CbTime.Location = new System.Drawing.Point(217, 344);
            this.CbTime.Name = "CbTime";
            this.CbTime.Size = new System.Drawing.Size(121, 21);
            this.CbTime.TabIndex = 1;
            this.CbTime.ValueMember = "Time_Id";
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataSource = typeof(Class_Sheduling_System.Time);
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(Class_Sheduling_System.Login);
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataSource = typeof(Class_Sheduling_System.Lecturer);
            // 
            // DtpClassAssingment
            // 
            this.DtpClassAssingment.Location = new System.Drawing.Point(217, 283);
            this.DtpClassAssingment.Name = "DtpClassAssingment";
            this.DtpClassAssingment.Size = new System.Drawing.Size(122, 20);
            this.DtpClassAssingment.TabIndex = 4;
            this.DtpClassAssingment.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(257, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CourseAssinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(882, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtpClassAssingment);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GvClassAssingment);
            this.Controls.Add(this.CbTime);
            this.Controls.Add(this.CBSemester);
            this.Controls.Add(this.CbRoom);
            this.Controls.Add(this.CbLecturer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbModeOfStudy);
            this.Controls.Add(this.CbFaculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseAssinment";
            this.Text = "CourseAssinment";
            this.Load += new System.EventHandler(this.CourseAssinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeOfStudyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvClassAssingment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFaculty;
        private System.Windows.Forms.ComboBox CbCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbSubject;
        private System.Windows.Forms.ComboBox CbLecturer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbRoom;
        private System.Windows.Forms.ComboBox CBSemester;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbModeOfStudy;
        private System.Windows.Forms.DataGridView GvClassAssingment;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbTime;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.BindingSource modeOfStudyBindingSource;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private System.Windows.Forms.BindingSource timeBindingSource;
        private System.Windows.Forms.BindingSource lecturerBindingSource1;
        private System.Windows.Forms.DateTimePicker DtpClassAssingment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}