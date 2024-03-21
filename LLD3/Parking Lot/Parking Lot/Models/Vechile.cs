using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    public class Vechile : BaseModel
    {
        private VechileType _vechileType;
        private string _vechileNumber;
        private string _vechileOwnerName;
        //public Vechile(int id, VechileType type, string vechileNumber):base(id)
        //{
        //    _type = type;
        //    _vechileNumber = vechileNumber;
        //}

        public VechileType VechileType { get => _vechileType; set => _vechileType = value; }
        public string VechileNumber { get => _vechileNumber; set => _vechileNumber = value; }
        public string VechileOwnerName { get => _vechileOwnerName; set => _vechileOwnerName = value; }
    }
}
