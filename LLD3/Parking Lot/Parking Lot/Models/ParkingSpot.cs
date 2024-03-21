namespace Parking_Lot.Models
{
    public class ParkingSpot : BaseModel
    {
        private ParkingFloor _parkingFloor;
        private ParkingSpotStatus _parkingSpotStatus;
        private int _number;
        private List<VechileType> _vechiles;
        public ParkingSpot(int id, ParkingFloor parkingFloor, ParkingSpotStatus parkingSpotStatus, int number, List<VechileType> vechiles) : base(id)
        {
            _parkingFloor = parkingFloor;
            _parkingSpotStatus = parkingSpotStatus;
            _number = number;
            _vechiles = vechiles;
        }

        public ParkingFloor ParkingFloor { get => _parkingFloor; set => _parkingFloor = value; }
        public ParkingSpotStatus ParkingSpotStatus { get => _parkingSpotStatus; set => _parkingSpotStatus = value; }
        public int Number { get => _number; set => _number = value; }
        public List<VechileType> Vechiles { get => _vechiles; set => _vechiles = value; }
    }
}