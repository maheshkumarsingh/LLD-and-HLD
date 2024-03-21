using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    public class ParkingLot : BaseModel
    {
        private string _name;
        private string _address;
        private string _email;
        private List<ParkingFloor> _parkingFloors;
        private List<Operator> _operator;
        private List<Gate> _gates;
        private ParkingLotStatus _parkingLotStatus;
        private SpotAllotmentStrategyType _slotAllotmentStrategyType;
        private FeeCalculationStrategyType _feeCalculationStrategyType;
        //public ParkingLot(int id, string name, string address, string email, List<ParkingFloor> floors, List<Operator> @operator, List<Gate> gates, ParkingLotStatus parkingLotStatus) :base(id)
        //{
        //    _name = name;
        //    _address = address;
        //    _email = email;
        //    _floors = floors;
        //    _operator = @operator;
        //    _gates = gates;
        //    _parkingLotStatus = parkingLotStatus;
        //}

        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
        public List<Operator> Operator { get => _operator; set => _operator = value; }
        public List<Gate> Gates { get => _gates; set => _gates = value; }
        public ParkingLotStatus ParkingLotStatus { get => _parkingLotStatus; set => _parkingLotStatus = value; }
        public SpotAllotmentStrategyType SlotAllotmentStrategyType { get => _slotAllotmentStrategyType; set => _slotAllotmentStrategyType = value; }
        public FeeCalculationStrategyType FeeCalculationStrategyType { get => _feeCalculationStrategyType; set => _feeCalculationStrategyType = value; }
        public List<ParkingFloor> ParkingFloors { get => _parkingFloors; set => _parkingFloors = value; }
    }
}
