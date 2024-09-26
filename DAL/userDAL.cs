using Blood_Donation_System.BLL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Donation_System.DAL
{
    internal class userDAL
    {
        //Create a Static String to Create Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private bool isSuccess;

        #region SELECT data from database
        public DataTable Select() 
        { 
            //Create an object to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Create a Database to hold the Data from Database
            DataTable dt = new DataTable();

            try
            {
                //Write SQL Query to Get data from Database
                string sql = "SELECT * FROM Tbl_users";

                // Create SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Sql data Adapter to hold the Data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                // Open Database Connection
                conn.Open();

                //Transfer data from SqlData Adapter to Database
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                //Display  error message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data into Database for User Module
        public bool Insert(userBLL u)
        {
            //create a boolean Varuiable and set its default value to false
            bool isSuccess = false;

            //Create an object of SqlConnection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Create a String variable to store the INSERT Query
                String sql = "INSERT INTO Tbl_users(username, email, password, full_name, contact, address, added_date, image_name) VALUES (@username, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";

                //Create a SQL Command to Pass the Value in our Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create the Parameter to pass the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email",u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                //Open Database connection
                conn.Open();
                
                //Create an integer Variable to hold the value after the Query is executed
                int rows = cmd.ExecuteNonQuery();

                //The Value of rows will be greater than 0 if the query is executed successfully
                //else it'll be 0

                if (rows > 0)
                {
                    //Query executed Successfully
                    isSuccess = true;
                }
                else
                {
                    // Failed to execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display  error message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion  
        #region UPDATE data in database (User Module)
        public bool Update(userBLL u)
        {
            //Create a boolean variable and set its Default value to False
            bool isSuccess = false;

            //Create an object for Databse Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a String Variable to hold the SQl Query 
                string sql = "Update tbl_users SET username=@username, email= @email, password=@password, full_name=@full_name, contact=@contact, address=@address, added_date=@added_date, image_name=@image_name WHERE user_id=@user_id";
                
                //Create Sql Command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now Pass the values to SQL Query
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id" , u.user_id);

                //Open database Connection
                conn.Open();


                //Create an integer Variable to hold the value after the Query is executed
                int rows = cmd.ExecuteNonQuery();

                //The Value of rows will be greater than 0 if the query is executed successfully
                //else it'll be 0

                if (rows > 0)
                {
                    //Query executed Successfully
                    isSuccess = true;
                }
                else
                {
                    // Failed to execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display  error message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region DELETE Data from Database (User Module)
        public bool Delete(userBLL u)
        {
            //Create a boolean Variable and set its default value to false
            bool isSuccess = false;

            //Create an object for SQlConnection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a string Variable to hold the Sql Query to Delete Data
                String sql = "Delete from Tbl_users WHERE user_id=@user_id";

                //Create Sql Command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now Pass the values to SQL Query
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //Open the Database Connection
                conn.Open ();

                //Create an integer Variable to hold the value after the Query is executed
                int rows = cmd.ExecuteNonQuery();

                //The Value of rows will be greater than 0 if the query is executed successfully
                //else it'll be 0

                if (rows > 0)
                {
                    //Query executed Successfully
                    isSuccess = true;
                }
                else
                {
                    // Failed to execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display  error message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }


            return isSuccess;
        }
        #endregion

        #region Search
        public DataTable Search(string keywords)
        {
            //1. Create a Sql Connection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //2. Create Data Table to hold the Data from database temporarily
            DataTable dt = new DataTable();
            

            //Write the Code to Search the Users

            try
            {
                // Write the Sql Query to Search the User from Database
                String sql = "SELECT * FROM Tbl_users WHERE user_id LIKE '%" + keywords + "%' OR full_name LIKE '%" + keywords + "%' OR address LIKE '%" + keywords + "%'";

                //Create Sql command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SQL Data ADapter to get the Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open ();

                //Pass the Data from Adapter  to DataTable
                adapter.Fill (dt);


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

        #region
        public userBLL GetIDFromUsername(string username)
        {
            userBLL u = new userBLL();

            //Create Sql Connection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create Data Table to hold the Data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to get the Id from USERNAME
                string sql = "SELECT user_id FROM Tbl_users WHERE username ='"+ username +"'";

                //Create SQL Data Adapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                
                //Open Database Connection
                conn.Open ();

                //Fill the Data in DataTable from Adapter
                adapter.Fill (dt);

                //if there's user based on the username then get the user_id
                if (dt.Rows.Count > 0)
                {
                    u.user_id = int.Parse(dt.Rows[0]["user_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                //Display  error message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }

            return u;
        }
        #endregion
    }
}
