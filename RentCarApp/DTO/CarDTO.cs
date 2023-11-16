using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarApp.DTO
{
    public class CarDTO
    {
        public long CarId { get; set; }
        public string CarName { get; set; }
        public string Decription { get; set; }
        public long Price { get; set; }

        public CarDTO(long id, string name, string des, long price)
        {
            CarId = id;
            CarName = name;
            Decription = des;
            Price = price;
        }

    }
}