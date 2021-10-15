using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineshopingCart
{
    public class DBConnection
    {
        public static void OpenConnection(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=True";
                con.Open();
            }
            catch (Exception e)
            {
                
            }
        }
        public static void CloseConnection(SqlConnection con)
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}