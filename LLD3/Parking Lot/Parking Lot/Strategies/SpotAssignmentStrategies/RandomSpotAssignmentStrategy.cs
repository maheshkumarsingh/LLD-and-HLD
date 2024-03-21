using Parking_Lot.Models;
using Parking_Lot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Strategies.SlotAssignmentStrategies
{
    public class RandomSpotAssignmentStrategy : SpotAssignmentStrategy
    {
        private ParkingLotService _parkingLotService;

        public RandomSpotAssignmentStrategy(ParkingLotService parkingLotService)
        {
            this._parkingLotService = parkingLotService;
        }

        public ParkingSpot GetSpot(Gate gate, VechileType vechileType)
        {
            ParkingLot parkingLot = _parkingLotService.GetParkingLotFromGate(gate);

            List <ParkingSpot > parkingSpots = _parkingLotService.GetParkingSpots(parkingLot.Id);

            foreach(ParkingSpot parkingSpot in parkingSpots)
            {
                if(parkingSpot.ParkingSpotStatus.Equals(ParkingSpotStatus.Available) && parkingSpot.Vechiles.Contains(vechileType))
                {
                    return parkingSpot;
                }
            }
            return null;
        }
    }
}
