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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, EventArgs e)
        {

            var username = TbUserName.Text;
            var password = TbPassword.Text;

            var ctx = new ClassShedulerEntities();

            var user = ctx.Users.Any(q => q.User_Name == username && q.Password == password);

            if(user)
            {
                MessageBox.Show($"Welcom {username}");
                var parent = (MainForm)this.MdiParent;
                parent.isLoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void toolStripBtnHome_Click(object sender, EventArgs e)
        {
            Staff_Data_Entry staff = new Staff_Data_Entry();
            staff.MdiParent = this;
            staff.WindowState = FormWindowState.Maximized;
            staff.Show();
        }

        private void BntReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        void ResetForm()
        {
            TbUserName.Clear();
            TbPassword.Clear();
        }
    }
}
