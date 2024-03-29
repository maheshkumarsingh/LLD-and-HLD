using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTOs;

namespace ContactsManager.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonService _personService;
        private readonly ICountriesService _countriesService;
        public PersonsController(IPersonService personService, ICountriesService countriesService)
        {
            _personService = personService;
            _countriesService = countriesService;
        }

        [Route("persons/index")]
        [Route("/")]
        public IActionResult Index(string searchBy, string searchString)
        {
            ViewBag.SearchFields = new Dictionary<string, string>()
            {
                {nameof(PersonResponseDTO.PersonName), "Person Name"},
                {nameof(PersonResponseDTO.Email), "Email"},
                {nameof(PersonResponseDTO.Gender), "Gender"},
                {nameof(PersonResponseDTO.Age), "Age"},
                {nameof(PersonResponseDTO.Address), "Address"},
                {nameof(PersonResponseDTO.CountryName), "Country"},
            };
            ViewBag.CurrentSearchBy = searchBy;
            ViewBag.SeachString = searchString;
            List<PersonResponseDTO> personResponseDTO = _personService.GetFilteredPersons(searchBy,searchString);
            foreach (var item in personResponseDTO)
            {
                CountryResponseDTO countryResponseDTO = _countriesService.GetCountryByCountryID(item.CountryID);
                item.CountryName = countryResponseDTO.CountryName;
            }

            return View(personResponseDTO);
        }
    }
}
