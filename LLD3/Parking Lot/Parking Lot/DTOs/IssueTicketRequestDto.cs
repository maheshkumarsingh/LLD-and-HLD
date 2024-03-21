using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.DTOs
{
    public class IssueTicketRequestDto
    {
        private VechileType _vechileType;
        private string? _vechileNumber;
        private string? vechileOwnerName;
        private int _gateID;

        public VechileType VechileType { get => _vechileType; set => _vechileType = value; }
        public string? VechileNumber { get => _vechileNumber; set => _vechileNumber = value; }
        public string? VechileOwnerName { get => vechileOwnerName; set => vechileOwnerName = value; }
        public int GateID { get => _gateID; set => _gateID = value; }
    }
}
