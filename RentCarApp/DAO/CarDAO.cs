using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RentCarApp.DTO;
using System.Data.SqlClient;
using RentCarApp.DAO;
using System.Data;

namespace DAO
{
    public class CarDAO : DataProvider
    {
        // get all car in database
        public List<CarDTO> GetData()
        {
            Connect();
            List<CarDTO> list = new List<CarDTO>();
            string sql = "SELECT * FROM Car";
            try
            {
                SqlDataReader dr = ExecuteNonQuery(sql);
                long CarId = 0;
                string CarName = string.Empty;
                string Decription = string.Empty;
                long Price = 0;

                while (dr.Read())
                {
                    CarId = dr.GetInt32(0);
                    CarName = dr.GetString(1);
                    Decription = dr.GetString(2);
                    Price = dr.GetInt32(3);

                    list.Add(new CarDTO(CarId, CarName, Decription, Price));
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
            return list;
        }

        // add one car in database
        public void AddCar(string name, string des, long price)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "insertCar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = des;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        // delete one car in database
        public void DeleteCar(long id)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "deleteCar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}