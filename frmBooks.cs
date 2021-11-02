using BookStore.BILL;
using BookStore.DALL;
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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Add code to hide this form
            this.Hide();
        }
        categoriesDALL cdall = new categoriesDALL();
        booksBLL p = new booksBLL();
        booksDALL pdall = new booksDALL();
        userDALL udall = new userDALL();
        private object pdal;
        private object keywods;
        private object dgvbooks;

        private void btnAdd_Click(object sender, EventArgs e)

        {
            //Creating Data Table to hold the categories from Database
            DataTable categoriesDT = cdall.Select();
            //Specify DataSource for Category Combobox
            cmbCategory.DataSource = categoriesDT;
            //Specify Display Member and Value Member for Combobox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //Load all the Books in Data Grid View
            DataTable dt = pdall.Select();
            dgvBooks.DataSource = dt;
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            //Get All the Values from Books Form
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            //Getting  username of logged in user
            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udall.GetIDFromusername(loggedUsr);

            p.added_by = usr.id;

            //Create Boolean variable to check if the books is added successfully or not
            bool success = pdall.Insert(p);
            //if the books is added  successfully then the value of success willbe true else it will be false
            if(success==true)
            {
                //Books Inserted Successfully
                MessageBox.Show("Books Added Successfully");
            }
            else
            {
                //Failed to add new books
                MessageBox.Show("Failed to Add New Books");
                //Calling the Clear Method
                Clear();
                //Refreshing Data Grid View
                DataTable dt = pdall.Select();
                dgvBooks.DataSource = dt;
            }
        }
        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
        }

        private void dgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create integer variable to know which books was clicked
            int rowIndex = e.RowIndex;
            //Dispaly the value on Respective TextBoxes
            txtID.Text = dgvBooks.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvBooks.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvBooks.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvBooks.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvBooks.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the values from UI or Books Form
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;
            //Getting Username of logged in user for added by
            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udall.GetIDFromusername(loggedUsr);

            p.added_by = usr.id;

            //Create a boolean variable to check if the books is updated or not
            bool success = pdall.Update(p);
            //If the books is updated successfully then the value of success will be true else it will be false
            if (success==true)
            {
                //Products updated Successfully
                MessageBox.Show("Books Successfully Upadted");
                Clear();
                //Refresh the Data Grid  View
                DataTable dt = pdall.Select();
            }
            else
            {
                //Failed to update Books
                MessageBox.Show("Failed to update Books");
            }
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the Id of the book to be deleted
            p.id = int.Parse(txtID.Text);

            //Create Bool Variable to Check if the book is deleted or not
            bool success = pdall.Delete(p);

            //If the product  is deleted successfully the the value pf success will true else it will be false
            if(success==true)
            {
                //Books Successfully Deleted
                MessageBox.Show("Book Successfully deleted");
                Clear();
                //Refresh Data Grid View
                DataTable dt = pdall.Select();
                dgvBooks.DataSource = dt;
            }
            else
            {
                //Failed to Delete Book
                MessageBox.Show("Failed to Delete Book");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keywords from From
            string keywords=txtSearch.Text
                if(keywods != null)
            {
                //Search the books
                DataTable dt = pdal.Search(keywords);
                dgvBooks.DataSource = dt;
            }
                else
            {
                //Display All the books
                DataTable dt = pdal.Select();
                dgvBooks.DataSource = dt;
        
            }
        }
    }
}
