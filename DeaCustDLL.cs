using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.DLL
{
    class DeaCustDLL
    {
        //Static String Method for Database Connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT MEthod for Dealer and Customer
        public DataTable Select()
        {
            //SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DataTble to hold the value from database and return it
            DataTable dt = new DataTable();

            try
            {
                //Write SQL Query t Select all the Data from database
                string sql = "SELECT * FROM Custome/Dealer Details";

                //Creating SQL Command to execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creting SQL Data Adapter to Store Data From Database Temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();
                //Passign the value from SQL Data Adapter to DAta table
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region INSERT Method to Add details fo Dealer or Customer
        public bool Insert(DeaCustBLL dc)
        {
            //Creting SQL Connection First
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create and Boolean value and set its default value to false
            bool isSuccess = false;

            try
            {
                //Write SQL Query to Insert Details of Dealer or Customer
                string sql = "INSERT INTO Customer/Dealer Details (Type, Name, Email, Contact, Address, Date_Added, Added_by_Employee_ID) VALUES (@Type, @Name, @Email, @Contact, @Address, @Date_Added, @Added_by_Employee_ID)";

                //SQl Command to Pass the values to query and execute
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the calues using Parameters
                cmd.Parameters.AddWithValue("@Type", dc.Type);
                cmd.Parameters.AddWithValue("@Name", dc.Name);
                cmd.Parameters.AddWithValue("@Email", dc.Email);
                cmd.Parameters.AddWithValue("@Contact", dc.Contact);
                cmd.Parameters.AddWithValue("@Address", dc.Address);
                cmd.Parameters.AddWithValue("@Date_Added", dc.Date_Added);
                cmd.Parameters.AddWithValue("@Added_by_Employee_ID", dc.Added_by_Employee_ID);

                //Open DAtabaseConnection
                conn.Open();

                //Int variable to check whether the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region UPDATE method for Dealer and Customer Module
        public bool Update(DeaCustBLL dc)
        {
            //SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Create Boolean variable and set its default value to false
            bool isSuccess = false;

            try
            {
                //SQL Query to update data in database
                string sql = "UPDATE Customer/Dealer Details SET Type=@Type, Name=@Name, Email=@Email, Contact=@Contact, Address=@Address, Date_Added=@Date_Added, Added_by_Employee_ID=@Added_by_Employee_ID WHERE Customer_ID=@Customer_ID";
                //Create SQL Command to pass the value in sql
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values through parameters
                cmd.Parameters.AddWithValue("@Type", dc.Type);
                cmd.Parameters.AddWithValue("@Name", dc.Name);
                cmd.Parameters.AddWithValue("@Email", dc.Email);
                cmd.Parameters.AddWithValue("@Contact", dc.Contact);
                cmd.Parameters.AddWithValue("@Address", dc.Address);
                cmd.Parameters.AddWithValue("@Date_Added", dc.Date_Added);
                cmd.Parameters.AddWithValue("@Added_by_Emploee_ID", dc.Added_by_Employee_ID);
                cmd.Parameters.AddWithValue("@Customer_ID", dc.Customer_ID);

                //open the Database Connection
                conn.Open();

                //Int varialbe to check if the query executed successfully or not
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Executed Successfully 
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region DELETE Method for Dealer and Customer Module
        public bool Delete(DeaCustBLL dc)
        {
            //SQlConnection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a Boolean Variable and set its default value to false
            bool isSuccess = false;

            try
            {
                //SQL Query to Delete Data from dAtabase
                string sql = "DELETE FROM Customer/Dealer Details WHERE Customer_ID=@Customer_ID";

                //SQL command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the value
                cmd.Parameters.AddWithValue("@Customer_ID", dc.Customer_ID);

                //Open DB Connection
                conn.Open();
                //integer variable
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Executed Successfully 
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
    }
}
