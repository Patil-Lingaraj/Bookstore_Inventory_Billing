using BookStore.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void pnlfooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories category = new frmCategories();
            category.Show();

        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeaCustfrm DealCust = new DeaCustfrm();
            DealCust.Show();

        }
    }
}
