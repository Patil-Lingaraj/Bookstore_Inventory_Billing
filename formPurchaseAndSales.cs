using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore___Invoice_System.User_Interface
{
    public partial class formPurchaseAndSales : Form
    {
        public formPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

    DeaCustDAL dcDAL = new DeaCustDAL();
    productsDAL pDAL = new productsDAL();
    userDAL uDAL = new userDAL();
    transactionDAL tDAL = new transactionDAL();
    transactionDetailDAL tdDAL = new transactionDetailDAL();

    DataTable transactionDT = new DataTable();
    private void frmPurchaseAndSales_Load(object sender, EventArgs e)
    {
        
        string type = frmUserDashboard.transactionType;
       
        lblTop.Text = type;

        
        transactionDT.Columns.Add("Product Name");
        transactionDT.Columns.Add("Rate");
        transactionDT.Columns.Add("Quantity");
        transactionDT.Columns.Add("Total");
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
       
        string keyword = txtSearch.Text;

        if (keyword == "")
        {
            
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            return;
        }

       
        DeaCustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

       
        txtName.Text = dc.name;
        txtEmail.Text = dc.email;
        txtContact.Text = dc.contact;
        txtAddress.Text = dc.address;
    }

    private void txtSearchProduct_TextChanged(object sender, EventArgs e)
    {
        
        string keyword = txtSearchProduct.Text;

        
        if (keyword == "")
        {
            txtProductName.Text = "";
            txtInventory.Text = "";
            txtRate.Text = "";
            TxtQty.Text = "";
            return;
        }

       
        productsBLL p = pDAL.GetProductsForTransaction(keyword);

       
        txtProductName.Text = p.name;
        txtInventory.Text = p.qty.ToString();
        txtRate.Text = p.rate.ToString();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        
        string productName = txtProductName.Text;
        decimal Rate = decimal.Parse(txtRate.Text);
        decimal Qty = decimal.Parse(TxtQty.Text);

        decimal Total = Rate * Qty; 

        
        decimal subTotal = decimal.Parse(txtSubTotal.Text);
        subTotal = subTotal + Total;

        
        if (productName == "")
        {
            
            MessageBox.Show("Select the product first. Try Again.");
        }
        else
        {
            
            transactionDT.Rows.Add(productName, Rate, Qty, Total);

            
            dgvAddedProducts.DataSource = transactionDT;
           
            txtSubTotal.Text = subTotal.ToString();

           
            txtSearchProduct.Text = "";
            txtProductName.Text = "";
            txtInventory.Text = "0.00";
            txtRate.Text = "0.00";
            TxtQty.Text = "0.00";
        }
    }
}
