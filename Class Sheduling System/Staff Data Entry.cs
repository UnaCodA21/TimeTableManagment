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
    public partial class Staff_Data_Entry : Form
    {

        private ClassShedulerEntities ctx;


        public Staff_Data_Entry()
        {
            InitializeComponent();
        }

        private void Staff_Data_Entry_Load(object sender, EventArgs e)
        {
           

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var fName = TbFirstName.Text;
            var lName = TbLastName.Text;
            var gender = CbGender.SelectedValue;
            var address = TbAddress.Text;
           // var faculty = CbFaculty.SelectedValue;
            var course = CbCourse.SelectedValue;
            var attendance = CbAttedance.SelectedValue;
            var department = CbDepartment.SelectedValue;
            var year = TbYear.Text;
            var semester = CbSemester.SelectedValue;
            var subject = CbSubject.SelectedValue;
            var room = CbRoom;

            Lecture record = new Lecture();

           record.First_Name = fName;
           record.Last_Name = lName;
           record.gender_id = Convert.ToInt32(gender);
           record.Address = address;
           record.Course_Id = Convert.ToInt32(course);
           record.attendance_id = Convert.ToInt32(attendance);
           record.Subject_Id = Convert.ToInt32(subject);

            ctx.Lectures.Add(record);
            ctx.SaveChanges();
            MessageBox.Show("Data Logged");

        }
    }
}
