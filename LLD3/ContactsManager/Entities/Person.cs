using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        private Guid _personID;
        private string? _name;
        private string? _email;
        private DateTime? _dob;
        private Gender _gender;
        private Guid? _countryId;
        private string? _address;
        private bool? _receiveNewsLetter;

        public Guid PersonID { get => _personID; set => _personID = value; }
        public string? Name { get => _name; set => _name = value; }
        public string? Email { get => _email; set => _email = value; }
        public DateTime? Dob { get => _dob; set => _dob = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public Guid? CountryId { get => _countryId; set => _countryId = value; }
        public string? Address { get => _address; set => _address = value; }
        public bool? ReceiveNewsLetter { get => _receiveNewsLetter; set => _receiveNewsLetter = value; }
    }
}
