using Parking_Lot.Models;
using Parking_Lot.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Services
{
    public class ParkingLotService
    {
        private ParkingLotRepository _parkingLotRepo;

        public ParkingLotService(ParkingLotRepository parkingLotRepo)
        {
            _parkingLotRepo = parkingLotRepo;
        }

        public ParkingLot Save(string name, string address, string email)
        {
            ParkingLot savedParkingLot = new ParkingLot();
            if (_parkingLotRepo.GetParkingLotByName(name) == null)
            {
                ParkingLot parkingLot = new ParkingLot();
                parkingLot.Name = name;
                parkingLot.Address = address;
                parkingLot.Email = email;
                savedParkingLot = _parkingLotRepo.Save(parkingLot);
            }
            else
            {
                savedParkingLot = _parkingLotRepo.GetParkingLotByName(name: name);
            }

            return savedParkingLot;
        }

        public ParkingLot GetParkingLotFromGate(Gate gate)
        {
            int id = gate.Id;
            return _parkingLotRepo.GetParkingLotFromGate(gate);
        }

        public List<ParkingSpot> GetParkingSpots(int parkingLotID)
        {
            return _parkingLotRepo.GetParkingSpots(parkingLotID);
        }
    }
}
