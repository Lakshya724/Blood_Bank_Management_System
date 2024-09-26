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
    internal class loginDAL
    {
        //Create a Static String to Create Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool loginCheck(loginBLL l)
        {
            // Create a Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Connecting Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Sql Query to Check login Based on Username and Password
                string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password";

                //Create Sql Command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now Pass the values to SQL Query
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);

                //Create SQL Data ADapter to get the Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Create Data Table to hold the Data from database temporarily
                DataTable dt = new DataTable();

                //Pass the Data from Adapter  to DataTable
                adapter.Fill(dt);

                //Check whether User exists or not
                if (dt.Rows.Count > 0 )
                {
                    //User Exists and Login Successfull
                    isSuccess = true;
                }
                else
                {
                    //Login Failed
                    isSuccess = false;
                }


                //Open the Database Connection
                conn.Open();
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
    }
}
