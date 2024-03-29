using ServiceContracts.DTOs;

namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for country add
    /// </summary>
    public interface ICountriesService
    {
        public CountryResponseDTO AddCountry(AddCountryRequestDTO? addCountryRequestDTO);

        /// <summary>
        /// Return all countries
        /// </summary>
        /// <returns></returns>
        public List<CountryResponseDTO> GetAllCountries();

        public CountryResponseDTO GetCountryByCountryID(Guid? id);
    }
}
