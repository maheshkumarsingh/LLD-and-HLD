namespace Parking_Lot.Models
{
    public class Gate : BaseModel
    {
        private GateType _gateType;
        private int _gateNumber;
        private Operator _operator;
        private GateStatus _gateStatus;

        public Gate(int id, GateType gateType, int gateNumber, Operator @operator, GateStatus gateStatus) : base(id)
        {
            _gateType = gateType;
            _gateNumber = gateNumber;
            _operator = @operator;
            _gateStatus = gateStatus;
        }

        public GateType GateType { get => _gateType; set => _gateType = value; }
        public int GateNumber { get => _gateNumber; set => _gateNumber = value; }
        public Operator Operator { get => _operator; set => _operator = value; }
        public GateStatus GateStatus { get => _gateStatus; set => _gateStatus = value; }
    }
}