using Parking_Lot.DTOs;
using Parking_Lot.Exceptions;
using Parking_Lot.Models;
using Parking_Lot.Repositories;
using Parking_Lot.Strategies;
using Parking_Lot.Strategies.SlotAssignmentStrategies;
using Parking_Lot.Strategies.SpotAssignmentStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Services
{
    public class TicketService
    {
        //services are generics
        //controller are specific
        private readonly GateRepository? _gateRepository;
        private readonly VechileRepository? _vechileRepository;
        private readonly ParkingLotRepository? _parkingLotRepository;
        private readonly TicketRepository? _ticketRepository;

        public TicketService(GateRepository? gateRepository, VechileRepository? vechileRepository, ParkingLotRepository? parkingLotRepository, TicketRepository? ticketRepository)
        {
            _gateRepository         = gateRepository;
            _vechileRepository      = vechileRepository;
            _parkingLotRepository   = parkingLotRepository;
            _ticketRepository       = ticketRepository;
        }

        public Ticket IssueTicket(VechileType vechileType, string vechileNumber, string vechileOwnerName, int gateID)
        {
            /*
             * 1. Create Ticket.
             * 2. Assign Spot.
             * 3. return Ticket.
             */

            Ticket ticket = new Ticket();
            ticket.EntryTime = DateTime.Now;
            Gate gate = _gateRepository.FindByGateId(gateID) ?? throw new GateNotFoundException();

            ticket.Gate = gate;
            ticket.Operator = gate.Operator;
            /*
             * 1) A vechile comes and If it is present 
             *  a. get the vechile from DB by number.
             *  b. put vechile object in ticket.
             * 2) A new vechile comes.
             *  a. save it to Db.
             *  b. put it in Ticket object.
             */

            Vechile savedVechile = new Vechile(); 
            if(_vechileRepository.GetVechileByNumber(vechileNumber) == null)
            {
                Vechile vechile = new Vechile();
                vechile.VechileNumber = vechileNumber;
                vechile.VechileType = vechileType;
                vechile.VechileOwnerName = vechileOwnerName;  
                savedVechile = _vechileRepository.SaveVechile(vechile);
            }
            else
            {
                savedVechile = _vechileRepository.GetVechileByNumber(vechileNumber);
            }
            ticket.Vechile = savedVechile;
            SpotAllotmentStrategyType slotAllotmentStrategyType = _parkingLotRepository.GetParkingLotFromGate(gate).SlotAllotmentStrategyType;


            //how to get strategy using type :- use factory DP
            SpotAssignmentStrategy spotAssignmentStrategy = SpotAssignmentStrategyFactory.GetSpotAssignmentStrategy(slotAllotmentStrategyType); 
            ticket.Spot = spotAssignmentStrategy.GetSpot(gate, vechileType);

            _ticketRepository.Save(ticket);
            ticket.Number = $"Ticket : {ticket.Id}";

            return ticket;
        }

    }
}
