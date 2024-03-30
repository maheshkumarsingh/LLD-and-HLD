using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTOs;
using ServiceContracts.Enums;

namespace ContactsManager.Controllers
{
    //[Route("persons")]
    [Route("[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersonService _personService;
        private readonly ICountriesService _countriesService;
        public PersonsController(IPersonService personService, ICountriesService countriesService)
        {
            _personService = personService;
            _countriesService = countriesService;
        }

        //[Route("persons/index")]
        //[Route("/")]
        //[Route("index")]
        [Route("[action]")]
        public IActionResult Index(string searchBy, string searchString, string sortBy = nameof(PersonResponseDTO.PersonName), 
            SortOrderOptionType sortOrderOptionType = SortOrderOptionType.Ascending)
        {
            ViewBag.SearchFields = new Dictionary<string, string>()
            {
                {nameof(PersonResponseDTO.PersonName), "Person Name"},
                {nameof(PersonResponseDTO.Email), "Email"},
                {nameof(PersonResponseDTO.Gender), "Gender"},
                //{nameof(PersonResponseDTO.Age), "Age"},
                {nameof(PersonResponseDTO.Address), "Address"},
                {nameof(PersonResponseDTO.CountryName), "Country"},
            };
            ViewBag.CurrentSearchBy = searchBy;
            ViewBag.SeachString = searchString;
            List<PersonResponseDTO> filteredPersonResponseDTO = _personService.GetFilteredPersons(searchBy,searchString);

            ViewBag.CurrentSortBy = sortBy;
            ViewBag.CurrentSortOrderOptionType = sortOrderOptionType;
            List<PersonResponseDTO> sortedPersons = _personService.GetSortedPersons(filteredPersonResponseDTO, sortBy, sortOrderOptionType);
            return View(sortedPersons);
        }

        //[Route("persons/create")]
        //[Route("create")]
        [Route("[action]")]
        [HttpGet]
        public IActionResult Create()
        {
            List<CountryResponseDTO> countries = _countriesService.GetAllCountries();
            ViewBag.Countries = countries;
            return View();
        }

        //[Route("persons/create")]
        //[Route("create")]
        [Route("[action]")]
        [HttpPost]
        public IActionResult Create(AddPersonRequestDTO addPersonRequestDTO)
        {
            if (!ModelState.IsValid)
            {
                List<CountryResponseDTO> countries = _countriesService.GetAllCountries();
                ViewBag.Countries = countries;

                ViewBag.Errors = ModelState.Values.SelectMany(value => value.Errors).Select(e => e.ErrorMessage).ToList();
                return View();
            }
            else
            {
                PersonResponseDTO personResponseDTO =  _personService.AddPerson(addPersonRequestDTO);

            }
            return RedirectToAction("Index", "Persons");
        }
    }
}
