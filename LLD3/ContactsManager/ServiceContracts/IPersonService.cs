using ServiceContracts.DTOs;
using ServiceContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IPersonService
    {
        PersonResponseDTO AddPerson(AddPersonRequestDTO requestDTO);
        List<PersonResponseDTO> GetAllPersons();
        PersonResponseDTO GetPersonByID(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchBy">Search field to search</param>
        /// <param name="searchString">returns all matching persons.</param>
        /// <returns></returns>
        List<PersonResponseDTO> GetFilteredPersons(string searchBy, string searchString);

        /// <summary>
        /// This method is to sort person on demand
        /// </summary>
        /// <param name="sortBy"></param>
        /// <param name="sortOrderOptionType"></param>
        /// <returns>List of all persons in sorted manner</returns>
        List<PersonResponseDTO> GetSortedPersons(string sortBy, SortOrderOptionType sortOrderOptionType);

        public PersonResponseDTO UpdatePerson(UpdatePersonRequestDTO requestDTO);

        public bool DeletePerson(Guid? personID);
    }
}
