using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Strategies.SlotAssignmentStrategies
{
    public interface SpotAssignmentStrategy
    {
        public ParkingSpot GetSpot(Gate gate, VechileType vechileType);
    }
}
