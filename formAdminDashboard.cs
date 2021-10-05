using Bookstore___Invoice_System.User_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore___Invoice_System
{
    public partial class formAdminDashboard : Form
    {
        public formAdminDashboard()
        {
            InitializeComponent();
        }

        private void formAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void labelSubHead_Click(object sender, EventArgs e)
        {

        }

        private void labelLoggedInEmployee_Click(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEmployees employee = new formEmployees();
            employee.Show();
        }
    }
}
