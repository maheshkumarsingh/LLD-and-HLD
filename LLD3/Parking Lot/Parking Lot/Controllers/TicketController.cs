using Parking_Lot.DTOs;
using Parking_Lot.Models;
using Parking_Lot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Controllers
{
    public class TicketController
    {
        private TicketService _ticketService;
        public TicketController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public IssueTicketResponseDto IssueTicket(IssueTicketRequestDto issueTicketRequestDto)
        {
            IssueTicketResponseDto ticketResponseDto = new IssueTicketResponseDto();
            Ticket ticket;
            try
            {
                ticket = _ticketService.IssueTicket(
                            vechileType: issueTicketRequestDto.VechileType,
                            vechileNumber: issueTicketRequestDto.VechileNumber,
                            vechileOwnerName: issueTicketRequestDto.VechileOwnerName,
                            gateID: issueTicketRequestDto.GateID
                          );
            }
            catch (Exception ex)
            {
                ticketResponseDto.Status = ResponseStatus.Failure;
                ticketResponseDto.FailureMessage = ex.Message;
                return ticketResponseDto;
            }

            ticketResponseDto.Ticket = ticket;
            ticketResponseDto.Status = ResponseStatus.Success;
            return ticketResponseDto;
        }
    }
}
