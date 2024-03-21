using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    public class Bill:BaseModel
    {
        private Ticket _ticket;
        private DateTime _exitTime;
        private int _amount;
        private Gate _gate;
        private List<Payment> _payments;
        private BillStatus _billStatus;

        public Bill(int id, Ticket ticket, DateTime exitTime, int amount, Gate gate, List<Payment> payments, BillStatus billStatus):base(id)
        {
            _ticket = ticket;
            _exitTime = exitTime;
            _amount = amount;
            _gate = gate;
            _payments = payments;
            _billStatus = billStatus;
        }

        public Ticket Ticket { get => _ticket; set => _ticket = value; }
        public DateTime ExitTime { get => _exitTime; set => _exitTime = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public Gate Gate { get => _gate; set => _gate = value; }
        public List<Payment> Payments { get => _payments; set => _payments = value; }
        public BillStatus BillStatus { get => _billStatus; set => _billStatus = value; }
    }
}
