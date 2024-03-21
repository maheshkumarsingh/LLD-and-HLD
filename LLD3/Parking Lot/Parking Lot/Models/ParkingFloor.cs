namespace Parking_Lot.Models
{
    public class ParkingFloor : BaseModel
    {
        private readonly int _capacity;
        private FloorStatus _floorStatus;
        private List<ParkingSpot> _parkingSpots;

        public ParkingFloor(int id, int capacity, FloorStatus floorStatus, List<ParkingSpot> parkingSpots) : base(id)
        {
            _capacity = 100;
            _floorStatus = FloorStatus.Open;
            _parkingSpots = parkingSpots;
        }

        public int Capacity { get => _capacity;}
        public FloorStatus FloorStatus { get => _floorStatus; set => _floorStatus = value; }
        public List<ParkingSpot> ParkingSpots { get => _parkingSpots; set => _parkingSpots = value; }
    }
}