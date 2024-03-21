using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Repositories
{
    public class GateRepository
    {

        private Dictionary<int, Gate> _gates = new Dictionary<int, Gate>();
        /// <summary>
        /// CRUD from and to database.
        /// </summary>
        /// <param name="gateId"></param>
        /// <returns>A gate or null</returns>
        public Gate? FindByGateId(int gateId)
        {
            if(_gates.ContainsKey(gateId))
                return _gates[gateId];
            else return null;
        }
    }
}
