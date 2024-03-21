using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Repositories
{
    public class ParkingLotRepository
    {
        private Dictionary<int, ParkingLot> _parkingLots = new Dictionary<int, ParkingLot>();
        private int previousId = 0;

        public ParkingLot GetParkingLotFromGate(Gate gate)
        {
            foreach (ParkingLot parkingLot in _parkingLots.Values)
            {
                if (parkingLot.Gates.Contains(gate))
                {
                    return parkingLot;
                }
            }
            return null;
        }

        public ParkingLot? GetParkingLotByName(string name)
        {
            foreach (var item in _parkingLots.Values)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }

        public ParkingLot Save(ParkingLot parkingLot)
        {
            previousId += 1;
            _parkingLots.Add(previousId, parkingLot);
            return _parkingLots[previousId];
        }

        public List<ParkingSpot> GetParkingSpots(int parkingLotID)
        {
            //Get parking floor by parkinglot id
            //Get all parking spots using parking floor id.

            return null;
        }
    }
}
