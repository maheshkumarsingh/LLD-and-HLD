using Entities;
using ServiceContracts;
using ServiceContracts.DTOs;
using ServiceContracts.Enums;
using Services.Helpers;
using Services.Strategies.PersonSearchStrategy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PersonsService : IPersonService
    {
        private readonly List<Person>? _persons;
        private readonly ICountriesService _countriesService;
        private IPersonSearchStrategy? _personSearchStrategy;

        public PersonsService(bool initialize = true)
        {
            _persons = new List<Person>();
            _countriesService = new CountriesService();
            if(initialize)
            {
                _persons.Add(new Person() { PersonID = Guid.Parse("8082ED0C-396D-4162-AD1D-29A13F929824"), Name = "Aguste", Email = "aleddy0@booking.com", Dob = DateTime.Parse("1993-01-02"), Gender = (Gender)GenderOptions.Male, Address = "0858 Novick Terrace", ReceiveNewsLetter = false, CountryId = Guid.Parse("000C76EB-62E9-4465-96D1-2C41FDB64C3B") });

                _persons.Add(new Person() { PersonID = Guid.Parse("06D15BAD-52F4-498E-B478-ACAD847ABFAA"), Name = "Jasmina", Email = "jsyddie1@miibeian.gov.cn", Dob = DateTime.Parse("1991-06-24"), Gender = (Gender)GenderOptions.Female, Address = "0742 Fieldstone Lane", ReceiveNewsLetter = true, CountryId = Guid.Parse("32DA506B-3EBA-48A4-BD86-5F93A2E19E3F") });

                _persons.Add(new Person() { PersonID = Guid.Parse("D3EA677A-0F5B-41EA-8FEF-EA2FC41900FD"), Name = "Kendall", Email = "khaquard2@arstechnica.com", Dob = DateTime.Parse("1993-08-13"), Gender = (Gender)GenderOptions.Male, Address = "7050 Pawling Alley", ReceiveNewsLetter = false, CountryId = Guid.Parse("32DA506B-3EBA-48A4-BD86-5F93A2E19E3F") });

                _persons.Add(new Person() { PersonID = Guid.Parse("89452EDB-BF8C-4283-9BA4-8259FD4A7A76"), Name = "Kilian", Email = "kaizikowitz3@joomla.org", Dob = DateTime.Parse("1991-06-17"), Gender = (Gender)GenderOptions.Male, Address = "233 Buhler Junction", ReceiveNewsLetter = true, CountryId = Guid.Parse("DF7C89CE-3341-4246-84AE-E01AB7BA476E") });

                _persons.Add(new Person() { PersonID = Guid.Parse("F5BD5979-1DC1-432C-B1F1-DB5BCCB0E56D"), Name = "Dulcinea", Email = "dbus4@pbs.org", Dob = DateTime.Parse("1996-09-02"), Gender = (Gender)GenderOptions.Female, Address = "56 Sundown Point", ReceiveNewsLetter = false, CountryId = Guid.Parse("DF7C89CE-3341-4246-84AE-E01AB7BA476E") });

                _persons.Add(new Person() { PersonID = Guid.Parse("A795E22D-FAED-42F0-B134-F3B89B8683E5"), Name = "Corabelle", Email = "cadams5@t-online.de", Dob = DateTime.Parse("1993-10-23"), Gender = (Gender)GenderOptions.Male, Address = "4489 Hazelcrest Place", ReceiveNewsLetter = false, CountryId = Guid.Parse("15889048-AF93-412C-B8F3-22103E943A6D") });

                _persons.Add(new Person() { PersonID = Guid.Parse("3C12D8E8-3C1C-4F57-B6A4-C8CAAC893D7A"), Name = "Faydra", Email = "fbischof6@boston.com", Dob = DateTime.Parse("1996-02-14"), Gender = (Gender)GenderOptions.Female, Address = "2010 Farragut Pass", ReceiveNewsLetter = true, CountryId = Guid.Parse("80DF255C-EFE7-49E5-A7F9-C35D7C701CAB") });

                _persons.Add(new Person() { PersonID = Guid.Parse("7B75097B-BFF2-459F-8EA8-63742BBD7AFB"), Name = "Oby", Email = "oclutheram7@foxnews.com", Dob = DateTime.Parse("1992-05-31"), Gender = (Gender)GenderOptions.Male, Address = "2 Fallview Plaza", ReceiveNewsLetter = false, CountryId = Guid.Parse("80DF255C-EFE7-49E5-A7F9-C35D7C701CAB") });

                _persons.Add(new Person() { PersonID = Guid.Parse("6717C42D-16EC-4F15-80D8-4C7413E250CB"), Name = "Seumas", Email = "ssimonitto8@biglobe.ne.jp", Dob = DateTime.Parse("1999-02-02"), Gender = (Gender)GenderOptions.Male, Address = "76779 Norway Maple Crossing", ReceiveNewsLetter = false, CountryId = Guid.Parse("80DF255C-EFE7-49E5-A7F9-C35D7C701CAB") });

                _persons.Add(new Person()
                {
                    PersonID = Guid.Parse("6E789C86-C8A6-4F18-821C-2ABDB2E95982"), Name ="Freemon", Email = "faugustin9@vimeo.com",
                    Dob = DateTime.Parse("1996-04-27"),Gender = (Gender)GenderOptions.Male,Address = "8754 Becker Street",ReceiveNewsLetter= false, CountryId = Guid.Parse("80DF255C-EFE7-49E5-A7F9-C35D7C701CAB")
                });
            }
        }

        #region AddPerson
        public PersonResponseDTO AddPerson(AddPersonRequestDTO requestDTO)
        {
            //Model Validations
            ValidationHelper.ModelValidation(requestDTO);

            Person person = requestDTO.ToPerson();
            person.PersonID = Guid.NewGuid();
            _persons.Add(person);

            return ConvertPersonToPersonResponseDTO(person);

        }

        public bool DeletePerson(Guid? personID)
        {
            if(personID == null)
            {
                throw new ArgumentNullException("Null value");
            }
            Person person = _persons.FirstOrDefault(temp => temp.PersonID.Equals(personID));
            if(person != null)
            {
                _persons.RemoveAll(temp => temp.PersonID.Equals(personID));
                return true;
            }
            return false;
        }
        #endregion

        #region GetAllPersons
        public List<PersonResponseDTO> GetAllPersons()
        {
            return _persons.Select(person => person.ToPersonResponseDTO()).ToList();
        }
        #endregion

        #region GetFilteredPersons
        public List<PersonResponseDTO> GetFilteredPersons(string searchBy, string searchString)
        {
            if (searchBy == null)
                return GetAllPersons();
            //throw new NotImplementedException();
            _personSearchStrategy = PersonSearchStrategyFactory.GetSearchPersonStrategy(searchBy);
            return _personSearchStrategy.GetFilteredPersons(searchString);
        }
        #endregion

        #region GetPersonByID
        public PersonResponseDTO GetPersonByID(Guid id)
        {
            return _persons.FirstOrDefault(person => person.PersonID == id).ToPersonResponseDTO();
        }
        #endregion

        #region GetSortedPersons
        public List<PersonResponseDTO> GetSortedPersons(string sortBy, SortOrderOptionType sortOrderOptionType)
        {
            List<PersonResponseDTO> allPersons = GetAllPersons();
            if (string.IsNullOrEmpty(sortBy))
                return allPersons;

            List<PersonResponseDTO> sortedPersons = (sortBy, sortOrderOptionType)
                switch
            {
                (nameof(PersonResponseDTO.PersonName), SortOrderOptionType.Ascending) =>
                    allPersons.OrderBy(person => person.PersonName, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(PersonResponseDTO.PersonName), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.PersonName, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(PersonResponseDTO.Email), SortOrderOptionType.Ascending) =>
                    allPersons.OrderBy(person => person.Email, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(PersonResponseDTO.Email), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.Email, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(PersonResponseDTO.DOB), SortOrderOptionType.Ascending) =>
                allPersons.OrderBy(person => person.DOB).ToList(),
                (nameof(PersonResponseDTO.DOB), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.DOB).ToList(),

                (nameof(PersonResponseDTO.Age), SortOrderOptionType.Ascending) =>
                    allPersons.OrderBy(person => person.DOB).ToList(),
                (nameof(PersonResponseDTO.Age), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.DOB).ToList(),

                (nameof(PersonResponseDTO.Gender), SortOrderOptionType.Ascending) =>
                    allPersons.OrderBy(person => person.Gender.ToString(), StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(PersonResponseDTO.Gender), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.Gender.ToString(), StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(PersonResponseDTO.Address), SortOrderOptionType.Ascending) =>
                    allPersons.OrderBy(person => person.Address, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(PersonResponseDTO.Address), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.Address, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(PersonResponseDTO.CountryName), SortOrderOptionType.Ascending) =>
                    allPersons.OrderBy(person => person.CountryName, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(PersonResponseDTO.CountryName), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.CountryName, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(PersonResponseDTO.ReceiveNewsLetter), SortOrderOptionType.Ascending) =>
                    allPersons.OrderBy(person => person.ReceiveNewsLetter).ToList(),
                (nameof(PersonResponseDTO.ReceiveNewsLetter), SortOrderOptionType.Descending) =>
                    allPersons.OrderBy(person => person.ReceiveNewsLetter).ToList(),
                _ => allPersons
            };
            return sortedPersons;
        }
        #endregion

        #region UpdatePerson
        public PersonResponseDTO UpdatePerson(UpdatePersonRequestDTO requestDTO)
        {
            if(requestDTO == null) 
                throw new ArgumentNullException(nameof(requestDTO));

            ValidationHelper.ModelValidation(requestDTO);

            Person? matchingPeron = _persons.FirstOrDefault(temp => temp.PersonID == requestDTO.PersonID);
            if (matchingPeron == null)
                throw new ArgumentNullException("Given person is not found");
            matchingPeron.Name = requestDTO.PersonName;
            matchingPeron.Email = requestDTO.Email;
            matchingPeron.Dob = requestDTO.DOB;
            matchingPeron.Gender = (Gender)requestDTO.Gender;
            matchingPeron.Address = requestDTO.Address;
            matchingPeron.CountryId = requestDTO.CountryID;
            matchingPeron.ReceiveNewsLetter = requestDTO.RecieveNewsLetter;

            return matchingPeron.ToPersonResponseDTO();
        }
        #endregion

        #region ConvertPersonToPersonResponseDTO
        /// <summary>
        /// This method is to convert person domain model to person respons dto with fetching country name.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        private PersonResponseDTO ConvertPersonToPersonResponseDTO(Person person)
        {
            PersonResponseDTO responseDTO = person.ToPersonResponseDTO();
            responseDTO.CountryName = _countriesService.GetCountryByCountryID(person.CountryId)?.CountryName;
            return responseDTO;
        }
        #endregion

    }
}
