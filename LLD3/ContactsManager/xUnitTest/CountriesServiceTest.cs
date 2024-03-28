using ServiceContracts;
using ServiceContracts.DTOs;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _countriesService;
        
        public CountriesServiceTest()
        {
            _countriesService = new CountriesService();
        }
        #region Add countries
        [Fact]
        public void AddCountry_NullCountry()
        {
            AddCountryRequestDTO requestDTO = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                _countriesService.AddCountry(requestDTO);
            });
        }


        [Fact]
        public void AddCountry_CountryNameNull()
        {
            AddCountryRequestDTO requestDTO = new AddCountryRequestDTO() { CountryName = null};

            Assert.Throws<ArgumentException>(() =>
            {
                _countriesService.AddCountry(requestDTO);
            });
        }
        
        [Fact]
        public void AddCountry_DuplicateCountryName()
        {
            AddCountryRequestDTO requestDTO = new AddCountryRequestDTO() { CountryName = "USA"};
            AddCountryRequestDTO requestDTO1 = new AddCountryRequestDTO() { CountryName = "USA"};

            Assert.Throws<ArgumentException>(() =>
            {
                _countriesService.AddCountry(requestDTO);
                _countriesService.AddCountry(requestDTO1);
            });
        }

        [Fact]
        public void AddCountry_ProperCountryName()
        {
            AddCountryRequestDTO requestDTO = new AddCountryRequestDTO() { CountryName = "Japan"};

            CountryResponseDTO addCountryResponseDTO = _countriesService.AddCountry(requestDTO);
            
            Assert.True(addCountryResponseDTO.CountryID != Guid.Empty);
        }
        #endregion

        #region Gell All countries
        [Fact]
        public void GetAllCountries_EmptyList()
        {
            List<CountryResponseDTO> countryResponseDTOs = _countriesService.GetAllCountries();
            Assert.Empty(countryResponseDTOs);
        }

        [Fact]

        public void GetAllCountries_AddFewCountries()
        {
            List<AddCountryRequestDTO> countryRequestDTOs = new List<AddCountryRequestDTO>()
            {
                new AddCountryRequestDTO{CountryName = "USA"},
                new AddCountryRequestDTO{CountryName = "UK"}
            };

        }
        #endregion
    }
}
