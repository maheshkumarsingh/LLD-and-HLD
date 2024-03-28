using Entities;
using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Strategies.PersonSearchStrategy
{
    public class PersonSearchStrategyFactory
    {
        public static IPersonSearchStrategy GetSearchPersonStrategy(string searchBy)
        {
            switch(searchBy)
            {
                case nameof(Person.Name):
                    return new PersonSearchByNameStrategy();
                case nameof(Person.Email):
                    return new PersonSearchByEmailStrategy();
                case nameof(Person.Dob) :
                    return new PersonSearchByDOBStrategy();
                case nameof(Person.Gender):
                    return new PersonSearchByGenderStrategy();
                case nameof(Person.Address):
                    return new PersonSearchByAddressStrategy();
                case nameof(Person.CountryId):
                    return new PersonSearchByCountryIDStrategy();
            }
            return null;
        }
    }
}
