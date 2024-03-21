using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.DTOs
{
    public class CreateParkingLotRequestDTO
    {
		private string _address;
		private string _name;
		private string _email;
		
        public string Address { get => _address; set => _address = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
