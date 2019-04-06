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
    public partial class MainForm : Form
    {
        public bool isLoggedIn = true;
        public String userLoggedIn = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowLoginForm()
        {
            Login logIn = new Login();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facutyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isLoggedIn)
            {
                var staffMan = new Staff_Data_Entry();
                staffMan.MdiParent = this;
                staffMan.Show();
            }
            else
            {
                ShowLoginForm();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        //ask sir about this
        private string btn_clicked(object sender)
        {
            var ctrl = (ToolStripMenuItem)sender;
            return ctrl.Text;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logIn = new Login();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void studentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isLoggedIn)
            {
                var classView = new Class_View_TimeTable_View();
                classView.MdiParent = this;
                classView.Show();
            }
            else
            {
                ShowLoginForm();
            }
           
        }

    }
}
