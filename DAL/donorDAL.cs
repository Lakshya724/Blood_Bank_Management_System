using Blood_Donation_System.BLL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Blood_Donation_System.DAL
{
    internal class donorDAL
    {
        //Create a Connection String to Create Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        

        //private bool isSuccess;

        #region SELECT to Display data in DataGridView from database
        public DataTable Select()
        {
            //Create a Database to hold the Data from Database
            DataTable dt = new DataTable();

            //Create an object to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                //Write SQL Query to Get data from Database
                string sql = "SELECT * FROM tbl_donors";

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
        public bool Insert(donorBLL d)
        {
            //create a boolean Varuiable and set its default value to false
            bool isSuccess = false;

            //Create an object of SqlConnection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Create a String variable to store the INSERT Query
                String sql = "INSERT INTO tbl_donors(first_name, last_name, email, contact, gender, address, blood_group, added_date, image_name, added_by) VALUES (@first_name, @last_name, @email, @contact, @gender, @address, @blood_group, @added_date, @image_name, @added_by)";

                //Create a SQL Command to Pass the Value in our Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create the Parameter to pass the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);

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
        public bool Update(donorBLL d)
        {
            //Create a boolean variable and set its Default value to False
            bool isSuccess = false;

            //Create an object for Databse Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a String Variable to hold the SQl Query 
                string sql = "UPDATE tbl_donors  SET first_name = @first_name, last_name=@last_name, email=@email, contact=@contact, gender=@gender, address=@address, Blood_group=@blood_group, added_date=@added_date, image_name=@image_name, added_by=@added_by WHERE donor_id=@donor_id";

                //Create Sql Command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now Pass the values to SQL Query
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

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
        public bool Delete(donorBLL d)
        {
            //Create a boolean Variable and set its default value to false
            bool isSuccess = false;

            //Create an object for SQlConnection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a streing Variable to hold the Sql Query to Delete Data
                String sql = "Delete FROM tbl_donors WHERE donor_id=@donor_id";

                //Create Sql Command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now Pass the values to SQL Query
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

                //Open the Database Connection
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

        #region Count Donors for specific Blood Group
        public string countDonors(string blood_group)
        {
            //Create Sql Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Ccreate a string Variable for donor count and set its default value to 0
            string donors = "0";

            try
            {
                //Sql Query to count doonors for specify Blood Group
                string sql = "SELECT * FROM tbl_donors WHERE blood_group = '" + blood_group + "'";

                //Sql Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Sql Data Adapter to Get the data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Database to Hold Data temporarily
                DataTable dt = new DataTable();

                //Pass the Value from SqlAdapter to DataTable
                adapter.Fill(dt);

                //Get the Total Number of Donors Based on Blood Group
                donors = dt.Rows.Count.ToString();
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

            return donors;
        }
        #endregion
        #region method to Search Donor
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
                String sql = "SELECT * FROM tbl_donors WHERE donor_id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "%' OR last_name LIKE '"+ keywords+"' OR email LIKE '%" +keywords+ "%' OR blood_group LIKE '"+keywords+"'";

                //Create Sql command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SQL Data ADapter to get the Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                //Pass the Data from Adapter  to DataTable
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
