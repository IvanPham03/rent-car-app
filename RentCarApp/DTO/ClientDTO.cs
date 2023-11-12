using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarApp.DTO
{
    internal class ClientDTO
    {
        public long ClientId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }   
        public string Phone {  get; set; }
        public string Address { get; set; }

    }
}
