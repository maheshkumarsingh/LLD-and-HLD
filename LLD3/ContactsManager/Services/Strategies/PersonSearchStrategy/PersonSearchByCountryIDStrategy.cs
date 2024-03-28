using ServiceContracts.DTOs;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Strategies.PersonSearchStrategy
{
    public class PersonSearchByCountryIDStrategy : IPersonSearchStrategy
    {
        private readonly IPersonService _personService;

        public PersonSearchByCountryIDStrategy()
        {
            _personService = new PersonsService();
        }
        public List<PersonResponseDTO> GetFilteredPersons(string searchString)
        {
            List<PersonResponseDTO> allPersons = _personService.GetAllPersons();
            if (string.IsNullOrEmpty(searchString))
                return allPersons;

            List<PersonResponseDTO> matchingPerson = null;

            matchingPerson = allPersons.Where(
                                                temp => ((temp.CountryID != null) ?
                                                temp.CountryID.ToString() == searchString :
                                                true))
                                                .ToList();
            return matchingPerson;
        }
    }
}
