using Entities;
using ServiceContracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTOs
{
    /// <summary>
    /// Acts as DTO for adding a person
    /// </summary>
    public class AddPersonRequestDTO
    {
        [Required(ErrorMessage ="Person name cant be blank")]
        [StringLength(50),RegularExpression("^[a-zA-Z0-9\\s]*$")]
        public string? PersonName { get; set; }

        [Required(ErrorMessage ="Email cant be blank")]
        [EmailAddress(ErrorMessage ="Email address should be valid")]
        public string? Email { get; set; }
        public DateTime? DOB { get; set; }

        public GenderOptions Gender { get; set; }
        public Guid? CountryID { get; set; }
        public string? Address { get; set; }
        public bool? RecieveNewsLetter { get; set; }


        public Person ToPerson()
        {
            return new Person()
            {
                Name = PersonName,
                Email = Email,
                Dob = DOB,
                Gender = (Gender)Gender,
                CountryId = CountryID,
                Address = Address,
                ReceiveNewsLetter = RecieveNewsLetter
            };
        }

    }
}
