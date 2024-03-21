using Parking_Lot.Models;
using Parking_Lot.Strategies.SlotAssignmentStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Strategies.SpotAssignmentStrategies
{
    public class SpotAssignmentStrategyFactory
    {
        public static SpotAssignmentStrategy GetSpotAssignmentStrategy(SpotAllotmentStrategyType spotAllotmentStrategyType)
        {
            if (spotAllotmentStrategyType.Equals(SpotAllotmentStrategyType.Random_Slot))
                return new RandomSpotAssignmentStrategy();
            return new RandomSpotAssignmentStrategy();
        }
    }
}
