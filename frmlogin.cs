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
    public partial class frmusers : Form
    {
        public frmusers()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDALL dall = new loginDALL();

        private void pboxClose_Click(object sender, EventArgs e)
        {
            //Code to close this form
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //Checking the login credentials
            bool sucess = dall.loginCheck(l);
            if (sucess == true)
            {
                //Login Successfull
                MessageBox.Show("Login Successful");
                //Need to open Respective Forms based on User Type
                switch(l.user_type)
                {
                    case "Admin":
                        {
                            //Display Admin  Dashboard
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //Display User Dashboard
                            FrmUserDashboard user = new FrmUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //Dispaly an erroe message
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;


                }
            }
            else
            {
                //login Failed
                MessageBox.Show("Login Failed. Try Again");
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbUserType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}