using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    public class Ticket : BaseModel
    {
        private string _number;
        private VechileType _type;
        private Vechile _vechile;
        private ParkingSpot _spot;
        private Gate _gate;
        private Operator _operator;
        private DateTime _entryTime;

        //public Ticket(int id, VechileType type, Vechile vechile, ParkingSpot spot, Gate gate, Operator @operator) : base(id)
        //{
        //    _type = type;
        //    _vechile = vechile;
        //    _spot = spot;
        //    _gate = gate;
        //    _operator = @operator;
        //}

        public VechileType Type { get => _type; set => _type = value; }
        public Vechile Vechile { get => _vechile; set => _vechile = value; }
        public ParkingSpot Spot { get => _spot; set => _spot = value; }
        public Gate Gate { get => _gate; set => _gate = value; }
        public Operator Operator { get => _operator; set => _operator = value; }
        public DateTime EntryTime { get => _entryTime; set => _entryTime = value; }
        public string Number { get => _number; set => _number = value; }
    }
}
