using BookStore.BLL;
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
    class CategoriesDLL
    {
        //
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method
        public DataTable Select()
        {
            //Creating Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try 
            {
                //Writing SQL Query to get all the data from Database
                string sql = "SELECT * FROM tbl_categories";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //open Database Connection
                conn.Open();

                //Adding the value from adapter to DAta Table dt
                adapter.Fill(dt);
            }

            catch(Exception ex)
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
        #region Inert New Category
        public bool Insert (categoriesBLL c)
        {
            //Creating A Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Connecting to Database 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Writing Query to Add New Catergory
                string sql = "INSERT INTO tbl_categories (Book Genre ID, Book Genre Description, Added_Date, Added by Employee_ID) VALUES (@Book Genre ID, @Book Genre Description, @Added_Date, @Added by Employee_ID)";

                // Creating SQL Command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //passing values through parameter
                cmd.Parameters.AddWithValue("@Book Genre ID", c.Book Genre ID);
                cmd.Parameters.AddWithValue("@Book Genre Description", c.Book Genre Description);
                cmd.Parameters.AddWithValue("@Added_Date", c.Added_Date);
                cmd.Parameters.AddWithValue("@Added by Employee_ID", c.Added by Employee_ID);

                //Open Database Connection
                conn.Open();

                //Creating the int variable to executte query
                int rowns = cmd.ExecuteNonQuery();

                //If the query is executed successfully then its value will be greater than 0 else it will less than 0
                if(rows>0)
                {
                    //Query Executed uccesfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Executed Connection
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //Closing Database Connection
                conn.Close();
            }

            return isSuccess;

        }

        #endregion
        #region Update Method
        public bool Update(categoriesBLL c)
        {
            //Creating Boolean variable and set its default value to false
            bool isSuccess = false;

            //Creating SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Query to Update Category
                string sql = "UPDATE tbl_categories SET Book Genre ID=@Book Genre ID, Book Genre Description=@Book Genre Description, Added_Date=@Added_Date, Added by Employee_ID=@Added by Employee_ID WHERE id=@id";

                //SQl Command to Pass the Value on Sql Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing Value using cmd
                cmd.Parameters.AddWithValue("@Book Genre ID", c.Book Genre ID);
                cmd.Parameters.AddWithValue("@Book Genre Description", c.Book Genre Description);
                cmd.Parameters.AddWithValue("@Added_Date", c.Added_Date);
                cmd.Parameters.AddWithValue("@Added by Employee_ID", c.Added by Employee_ID);
                cmd.Parameters.AddWithValue("@id", c.id);

                //Open DAtabase Connection
                conn.Open();

                //Create Int Variable to execute query
                int rows = cmd.ExecuteNonQuery();

                //if the query is successfully executed then the value will be grater than zero 
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
        #region Delete Category Method
        public bool Delete(categoriesBLL c)
        {
            //Create a Boolean variable and set its value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Delete from Database
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@id", c.id);

                //Open SqlConnection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executd successfully then the value of rows will be greater than zero else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Faied to Execute Query
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
        #region Method for Searh Funtionality
        public DataTable Search(string keywords)
        {
            //SQL Connection For Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Creating Data TAble to hold the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query To Search Categories from DAtabase
                String sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR Book Genre ID LIKE '%" + keywords + "%' OR Book Genre Description LIKE '%" + keywords + "%'";
                //Creating SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Getting DAta From DAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DatabaseConnection
                conn.Open();
                //Passing values from adapter to Data Table dt
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
        #region Method for Searh Funtionality
        public DataTable Search(string keywords)
        {
            //SQL Connection For Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Creating Data TAble to hold the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query To Search Categories from DAtabase
                String sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR Book Genre ID LIKE '%" + keywords + "%' OR Book Genre Description LIKE '%" + keywords + "%'";
                //Creating SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Getting DAta From DAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DatabaseConnection
                conn.Open();
                //Passing values from adapter to Data Table dt
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
    }
}
