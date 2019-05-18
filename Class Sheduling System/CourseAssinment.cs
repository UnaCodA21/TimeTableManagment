using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Sheduling_System
{
    public partial class CourseAssinment : Form
    {
        private ClassShedulerEntities ctx;

        public CourseAssinment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CourseAssinment_Load(object sender, EventArgs e)
        {

            try
            {
                ctx = new ClassShedulerEntities();

                var Faculty = ctx.Faculties.ToList();
                CbFaculty.DataSource = Faculty;
                CbFaculty.DisplayMember = "Faculty";
                CbFaculty.ValueMember = "Faculty_Id";

                var Course = ctx.Courses.ToList();
                CbCourse.DataSource = Course;
                CbCourse.DisplayMember = "Course_Name";
                CbCourse.ValueMember = "Course_Id";

                var Subject = ctx.Subjects.ToList();
                CbSubject.DataSource = Subject;
                CbSubject.DisplayMember = "Subject_Name";
                CbSubject.ValueMember = "Subject_Id";

                var Room = ctx.Rooms.ToList();
                CbRoom.DataSource = Room;
                CbRoom.DisplayMember = "Room";
                CbRoom.ValueMember = "Room_ID";

                var modeOfStudy = ctx.ModeOfStudies.ToList();
                CbModeOfStudy.DataSource = modeOfStudy;
                CbModeOfStudy.DisplayMember = "ModeOfStudy";
                CbModeOfStudy.ValueMember = "ModeOfStudy_Id";

                var Semester = ctx.Semesters.ToList();
                CBSemester.DataSource = Semester;
                CBSemester.DisplayMember = "Semester";
                CBSemester.ValueMember = "Semester_Id";

                var Time = ctx.Times.ToList();
                CbTime.DataSource = Time;
                CbTime.DisplayMember = "Time";
                CbTime.ValueMember = "Time_Id";

                var Lecturer = ctx.Lecturers.ToList();
                CbLecturer.DataSource = Lecturer;
                CbLecturer.DisplayMember = "Initial";
                CbLecturer.ValueMember = "Lecturer_Id";


            }
            catch (Exception ex)
            {
                throw ex;
            }
            RefreshGridView();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var faculty = CbFaculty.SelectedValue;
            var course = CbCourse.SelectedValue;
            var subject = CbSubject.SelectedValue;
            var lecturer = CbLecturer.SelectedValue;
            var room = CbRoom.SelectedValue;
            var modeOfStudy = CbModeOfStudy.SelectedValue;
            var semester = CBSemester.SelectedValue;
            var time = CbTime.SelectedValue;

            CouresAssingment Rec = new CouresAssingment();

            Rec.Faculty_id = Convert.ToInt32(faculty);
            Rec.Course_id = Convert.ToInt32(course);
            Rec.Subject_id = Convert.ToInt32(subject);
            Rec.Lecturer_id = Convert.ToInt32(lecturer);
            Rec.Room_id = Convert.ToInt32(room);
            Rec.Mode_Of_Study_id = Convert.ToInt32(modeOfStudy);
            Rec.Semester_id = Convert.ToInt32(semester);
            Rec.Time_id = Convert.ToInt32(time);

            ctx.CouresAssingments.Add(Rec);
            ctx.SaveChanges();

            RefreshGridView();
            ResetForm();
        }

        private void DgvClassAssingment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GvClassAssingment_selectionChanged(object sender, EventArgs e)
        {
            try
            {
                var row = GvClassAssingment.SelectedRows[0];

                var rowFaculty = row.Cells["Faculty"].Value.ToString();
                var faculty = ctx.Faculties.FirstOrDefault(q => q.Faculty1 == rowFaculty).Faculty_Id;
                CbFaculty.SelectedValue = faculty;

                var rowCourse = row.Cells["Course"].Value.ToString();
                var course = ctx.Courses.FirstOrDefault(q => q.Course_Name == rowCourse).Course_Id;
                CbCourse.SelectedValue = course;

                var rowSubject = row.Cells["Subject_Name"].Value.ToString();
                var subject = ctx.Subjects.FirstOrDefault(q => q.Subject_Name == rowSubject).Subject_Id;
                CbSubject.SelectedValue = subject;

                var rowLecturer = row.Cells["Initial"].Value.ToString();
                var lecturer = ctx.Lecturers.FirstOrDefault(q => q.Initial == rowLecturer).Lecturer_Id;
                CbLecturer.SelectedValue = lecturer;

                var rowRoom = row.Cells["Room"].Value.ToString();
                var room = ctx.Rooms.FirstOrDefault(q => q.Room1 == rowRoom).Room_ID;
                CbRoom.SelectedValue = room;

                var rowModeOfStudy = row.Cells["ModeOfStudy"].Value.ToString();
                var modeOfStudy = ctx.ModeOfStudies.FirstOrDefault(q => q.ModeOfStudy1 == rowModeOfStudy).ModeOfStudy_Id;
                CbModeOfStudy.SelectedValue = modeOfStudy;

                var rowSemester = row.Cells["Semester"].Value.ToString();
                var semester = ctx.Semesters.FirstOrDefault(q => q.Semester1 == rowSemester).Semester1;
                CBSemester.SelectedValue = semester;

                var rowTime = row.Cells["Time"].Value.ToString();
                var time = ctx.Times.FirstOrDefault(q => q.Time1 == rowTime).Time1;
                CbTime.SelectedValue = time;


            }
            catch (Exception)
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        void ResetForm()
        {
            CbFaculty.SelectedIndex = 0;
            CbCourse.SelectedIndex = 0;
            CbSubject.SelectedIndex = 0;
            CbLecturer.SelectedIndex = 0;
            CbRoom.SelectedIndex = 0;
            CbModeOfStudy.SelectedIndex = 0;
            CBSemester.SelectedIndex = 0;
            CbTime.SelectedIndex = 0;
        }

        void RefreshGridView()
        {

            var CourseAssinment = ctx.CouresAssingments.Select(q => new
            {
                q.CouresAssingment_Id,
                q.Faculty.Faculty1,
                q.Course.Course_Name,
                q.Subject.Subject_Name,
                q.Lecturer.Initial,
                q.Room.Room1,
                q.ModeOfStudy.ModeOfStudy1,
                q.Semester.Semester1,
                q.DateOfSub.CouresAssingments,
                q.Time.Time1
            }).ToList();
            GvClassAssingment.DataSource = CourseAssinment;
            GvClassAssingment.Refresh();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRowId = GetSelectedRow();

                var ClassAssinmentToUpdate = GetUserByID(selectedRowId);

                if(ClassAssinmentToUpdate != null)
                {
                    ClassAssinmentToUpdate.Faculty_id = Convert.ToInt32(CbFaculty.SelectedValue);
                    ClassAssinmentToUpdate.Course_id = Convert.ToInt32(CbCourse.SelectedValue);
                    ClassAssinmentToUpdate.Subject_id = Convert.ToInt32(CbSubject.SelectedValue);
                    ClassAssinmentToUpdate.Lecturer_id = Convert.ToInt32(CbLecturer.SelectedValue);
                    ClassAssinmentToUpdate.Room_id = Convert.ToInt32(CbRoom.SelectedValue);
                    ClassAssinmentToUpdate.Mode_Of_Study_id = Convert.ToInt32(CbModeOfStudy.SelectedValue);
                    ClassAssinmentToUpdate.Semester_id = Convert.ToInt32(CBSemester.SelectedValue);
                    ClassAssinmentToUpdate.Time_id = Convert.ToInt32(CbTime.SelectedValue);

                    ctx.SaveChanges();
                    ResetForm();
                    RefreshGridView();

                }
                else
                {
                    MessageBox.Show("Invalid Data Entered");
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"A fatal error occurred. {ex.Message}");
            }


        }

        int GetSelectedRow()
        {
            int row = (int)GvClassAssingment.SelectedRows[0].Cells[0].Value;
            return row;
        }

        CouresAssingment GetUserByID(int id)
        {
            var couresAssingment = ctx.CouresAssingments.Find(id);
            return couresAssingment;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRowId = GetSelectedRow();
                var ClassAssinmentToDelete = GetUserByID(selectedRowId);

                if (ClassAssinmentToDelete != null)
                {
                    ctx.CouresAssingments.Remove(ClassAssinmentToDelete);
                    ctx.SaveChanges();

                    ResetForm();
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("No User was found with this ID");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
