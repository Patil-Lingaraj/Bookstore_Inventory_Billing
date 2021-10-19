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
    public partial class FrmUserDashboard : Form
    {
        public FrmUserDashboard()
        {
            InitializeComponent();
        }

        private void salesFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblSubhead_Click(object sender, EventArgs e)
        {

        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeaCustfrm DealCust = new DeaCustfrm();
            DealCust.Show();
        }
    }
}
