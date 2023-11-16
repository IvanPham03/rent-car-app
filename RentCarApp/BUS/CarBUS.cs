using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace RentCarApp.BUS
{
    public class CarBUS
    {
        CarDAO car = new CarDAO();

        public List<CarDTO> GetData()
        {
            return car.GetData();
        }

        public void AddCar(string name, string des, long price)
        {
            car.AddCar(name, des, price);
        }

        public void DeleteCar(long id)
        {
            car.DeleteCar(id);
        }
    }
}