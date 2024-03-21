using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.DTOs
{
    public class CreateParkingLotResponseDTO
    {
        private ParkingLot _parkinglot;

        private ResponseStatus _status;
        private string _failureMessage;
        public ParkingLot Parkinglot { get => _parkinglot; set => _parkinglot = value; }
        public ResponseStatus Status { get => _status; set => _status = value; }
        public string FailureMessage { get => _failureMessage; set => _failureMessage = value; }
    }
}
