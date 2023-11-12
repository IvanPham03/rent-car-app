using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarApp.DAO
{
    public class DataProvider
    {
        public SqlConnection conn = new SqlConnection();

        public DataProvider() 
        {
            string connectionString = @"Data Source=LAPTOP-IRVG80GT\MSSQLSERVER01;Initial Catalog=shop;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        protected void Connect()
        {
            try
            {
                if(conn!= null && conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void DisConnect()
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        protected SqlDataReader ExecuteNonQuery(string sql)
        {
            SqlDataReader dr = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return dr;
        }


    }
}
