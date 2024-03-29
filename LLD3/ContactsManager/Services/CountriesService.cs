using Entities;
using ServiceContracts;
using ServiceContracts.DTOs;
using System.Runtime.CompilerServices;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        private readonly List<Country> _countries = null;
        public CountriesService(bool initialiaze = true)
        {
            _countries = new List<Country>();
            if (initialiaze)
            {
                _countries.AddRange(new List<Country>() 
                {
                    new Country() { CountryID = Guid.Parse("15889048-AF93-412C-B8F3-22103E943A6D"), CountryName = "India" },
                    new Country() { CountryID = Guid.Parse("000C76EB-62E9-4465-96D1-2C41FDB64C3B"), CountryName = "USA" },
                    new Country() { CountryID = Guid.Parse("32DA506B-3EBA-48A4-BD86-5F93A2E19E3F"), CountryName = "Canada" },
                    new Country() { CountryID = Guid.Parse("DF7C89CE-3341-4246-84AE-E01AB7BA476E"), CountryName = "UK" },
                    new Country() { CountryID = Guid.Parse("80DF255C-EFE7-49E5-A7F9-C35D7C701CAB"), CountryName = "Australia" }
                });
            }//{3BA967EC-DD57-4ABD-9B05-21E8DABA8B84}
        }
        public CountryResponseDTO AddCountry(AddCountryRequestDTO? CountryRequestDTO)
        {
            //throw new NotImplementedException();
            Country country = CountryRequestDTO.ToCountry();
            _countries.Add(country);

            return country.ToCountryResponseDTO();
        }

        public List<CountryResponseDTO> GetAllCountries() => _countries.Select(country => country.ToCountryResponseDTO()).ToList();

        /// <summary>
        /// Return CountryResponse by country ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public CountryResponseDTO GetCountryByCountryID(Guid? id)
        {
            if (id == null) throw new ArgumentNullException("id");

            return (_countries.FirstOrDefault(country => country.CountryID == id)).ToCountryResponseDTO();
        }
    }
}
