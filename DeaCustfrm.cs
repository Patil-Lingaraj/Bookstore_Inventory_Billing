using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.UI
{
    public partial class DeaCustfrm : Form
    {
        public DeaCustfrm()
        {
            InitializeComponent();
        }

        private void lblTOP_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //To CLose this Form
            this.Hide();
        }
    }
}
