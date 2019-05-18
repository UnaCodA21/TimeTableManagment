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
            try
            {
                ctx = new ClassShedulerEntities();

                var gender = ctx.Genders.ToList();
                CbGender.DataSource = gender;
                CbGender.DisplayMember = "Name";
                CbGender.ValueMember = "Gendere_Id";
                

            }catch(Exception ex)
            {
                throw ex;
            }
            ResetForm();
        RefreshGridView();
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
            var mName = TbMiddleName.Text;
            var lName = TbLastName.Text;
            var gender = CbGender.SelectedValue;
            var address = TbAddress.Text;
            var initial = TbInitail.Text;

           Lecturer record = new Lecturer();

           record.First_Name = fName;
           record.Middle_Name = mName;
           record.Last_Name = lName;
           record.gender_id = Convert.ToInt32(gender);
           record.Address = address;
           record.Initial = initial;

            ctx.Lecturers.Add(record);
            ctx.SaveChanges();
            MessageBox.Show("Data Logged");
            RefreshGridView();
        }

        void RefreshGridView()
        {
            var Lecturers = ctx.Lecturers.Select(q => new
            {
                q.Lecturer_Id,
                q.First_Name,
                q.Middle_Name,
                q.Last_Name,
                q.Address,
                q.Gender.Gender1
            }).ToList();
            GvStaff.DataSource = Lecturers;
            GvStaff.Refresh();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRowId = GetSelectedRow();
                var LecturerToUpdate = GetUserByID(selectedRowId);

                if(LecturerToUpdate != null)
                {
                    ctx.Lecturers.Remove(LecturerToUpdate);
                    ctx.SaveChanges();
                    ResetForm();
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
           {

               var selectedRowId = GetSelectedRow();
               var LecturerToUpdate = GetUserByID(selectedRowId);

                if (LecturerToUpdate != null )
                {
                    LecturerToUpdate.First_Name = TbFirstName.Text;
                    LecturerToUpdate.Middle_Name = TbMiddleName.Text;
                    LecturerToUpdate.Last_Name = TbLastName.Text;
                    LecturerToUpdate.Address = TbAddress.Text;
                    LecturerToUpdate.Initial = TbInitail.Text;
                    LecturerToUpdate.gender_id = Convert.ToInt32(CbGender.SelectedValue);
                    ctx.SaveChanges();

                    MessageBox.Show("Data updated");
                    ResetForm();
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("Invalid Data Entered");
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show($"A fatal error occurred. {ex.Message}");
            }

        }

        int GetSelectedRow()
        {
            int row = (int)GvStaff.SelectedRows[0].Cells[0].Value;
            return row;
        }

        Lecturer GetUserByID(int id)
        {
            var Lecturer = ctx.Lecturers.Find(id);
            return Lecturer;
        }

        void ResetForm()
        {
            TbFirstName.Clear();
            TbMiddleName.Clear();
            TbLastName.Clear();
            TbAddress.Clear();
            TbInitail.Clear();
            CbGender.SelectedIndex = 0;
        }

        private void GvStaff_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var row = GvStaff.SelectedRows[0];
                TbFirstName.Text = row.Cells["FirstName"].Value.ToString();
                TbMiddleName.Text = row.Cells["MiddleName"].Value.ToString();
                TbLastName.Text = row.Cells["LastName"].Value.ToString();
                TbAddress.Text = row.Cells["Address"].Value.ToString();
                TbInitail.Text = row.Cells["Initial"].Value.ToString();
                var rowGender = row.Cells["Name"].Value.ToString();
                var gender = ctx.Genders.FirstOrDefault(q => q.Gender1 == rowGender).Gendere_Id;
                CbGender.SelectedValue = gender;

            }
            catch (Exception ex)
            {

            }

            bool isFormInvalid()
            {
                return String.IsNullOrEmpty(TbFirstName.Text) || String.IsNullOrEmpty(TbLastName.Text) || CbGender.SelectedItem == null;
            }
        }
    }
}
