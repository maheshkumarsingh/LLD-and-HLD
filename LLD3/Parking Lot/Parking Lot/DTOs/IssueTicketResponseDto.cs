using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.DTOs
{
    public class IssueTicketResponseDto
    {
        private Ticket? _ticket;
        private ResponseStatus _status;
        private string? _failureMessage;

        public Ticket? Ticket { get => _ticket; set => _ticket = value; }
        public ResponseStatus Status { get => _status; set => _status = value; }
        public string? FailureMessage { get => _failureMessage; set => _failureMessage = value; }
    }
}
