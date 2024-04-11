using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Rotativa.AspNetCore;
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
        private readonly ILogger<PersonsController> _logger;
        public PersonsController(IPersonService personService, ICountriesService countriesService, ILogger<PersonsController> logger)
        {
            _personService = personService;
            _countriesService = countriesService;
            _logger = logger;
        }

        //[Route("persons/index")]
        [Route("/")]
        //[Route("index")]
        [Route("[action]")]
        public async Task<IActionResult> Index(string searchBy, string searchString, string sortBy = nameof(PersonResponseDTO.PersonName),
            SortOrderOptionType sortOrderOptionType = SortOrderOptionType.Ascending)
        {
            _logger.LogInformation("Index action method reached.");
            _logger.LogDebug($"search by : {searchBy},searchString:{searchString},SortBy : {sortBy},Sort option :{sortOrderOptionType} ");

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
            List<PersonResponseDTO> filteredPersonResponseDTO = await _personService.GetFilteredPersons(searchBy, searchString);

            ViewBag.CurrentSortBy = sortBy;
            ViewBag.CurrentSortOrderOptionType = sortOrderOptionType;
            List<PersonResponseDTO> sortedPersons = await _personService.GetSortedPersons(filteredPersonResponseDTO, sortBy, sortOrderOptionType);
            return View(sortedPersons);
        }

        //[Route("persons/create")]
        //[Route("create")]
        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> CreateAsync()
        {
            List<CountryResponseDTO> countries = await _countriesService.GetAllCountries();
            ViewBag.Countries = countries.Select(temp =>
                   new SelectListItem() { Text = temp.CountryName, Value = temp.CountryID.ToString() }
            );
            return View();
        }

        //[Route("persons/create")]
        //[Route("create")]
        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> CreateAsync(AddPersonRequestDTO addPersonRequestDTO)
        {
            if (!ModelState.IsValid)
            {
                List<CountryResponseDTO> countries = await _countriesService.GetAllCountries();
                ViewBag.Countries = countries.Select(temp =>
                       new SelectListItem() { Text = temp.CountryName, Value = temp.CountryID.ToString() }
                );

                ViewBag.Errors = ModelState.Values.SelectMany(value => value.Errors).Select(e => e.ErrorMessage).ToList();
                return View();
            }
            else
            {
                PersonResponseDTO personResponseDTO = await _personService.AddPerson(addPersonRequestDTO);

            }
            return RedirectToAction("Index", "Persons");
        }

        [Route("[action]/{personID}")] // /persons/edit/1
        [HttpGet]
        public async Task<IActionResult> EditAsync(Guid? personID)
        {
            PersonResponseDTO personResponseDTO = await _personService.GetPersonByID(personID);
            if (personResponseDTO == null)
                return RedirectToAction("Index");

            UpdatePersonRequestDTO updatePersonRequestDTO = personResponseDTO.ToPersonUpdateRequestDTO();

            List<CountryResponseDTO> countries = await _countriesService.GetAllCountries();
            ViewBag.Countries = countries.Select(temp =>
                   new SelectListItem() { Text = temp.CountryName, Value = temp.CountryID.ToString() }
            );
            return View(updatePersonRequestDTO);
        }

        [HttpPost]
        [Route("[action]/{personID}")]
        public async Task<IActionResult> EditAsync(UpdatePersonRequestDTO updatePersonRequestDTO)
        {
            PersonResponseDTO personResponseDTO = await _personService.GetPersonByID(updatePersonRequestDTO.PersonID);
            if (personResponseDTO == null)
                return RedirectToAction("Index");
            if(ModelState.IsValid)
            {
                PersonResponseDTO updatedResponse = await _personService.UpdatePerson(updatePersonRequestDTO);
                return RedirectToAction("Index");
            }
            else
            {
                List<CountryResponseDTO> countries = await _countriesService.GetAllCountries();
                ViewBag.Countries = countries.Select(temp =>
                       new SelectListItem() { Text = temp.CountryName, Value = temp.CountryID.ToString() }
                );

                ViewBag.Errors = ModelState.Values.SelectMany(value => value.Errors).Select(e => e.ErrorMessage).ToList();
            }
            return View(updatePersonRequestDTO);
        }

        [HttpGet]
        [Route("[action]/{personID}")]
        public async Task<IActionResult> DeleteAsync(Guid? personID)
        {
            PersonResponseDTO personResponseDTO = await _personService.GetPersonByID(personID);
            if(personResponseDTO == null)
                return RedirectToAction("Index");
            return View(personResponseDTO);
        }
        
        [HttpPost]
        [Route("[action]/{personID}")]
        public async Task<IActionResult> DeleteAsync(UpdatePersonRequestDTO updatePersonRequestDTO)
        {
            PersonResponseDTO personResponseDTO =  await _personService.GetPersonByID(updatePersonRequestDTO.PersonID);
            if(personResponseDTO == null)
                return RedirectToAction("Index");
            bool flag = await _personService.DeletePerson(updatePersonRequestDTO.PersonID);
            return RedirectToAction("Index");
        }

        [Route("[action]")]
        public async Task<IActionResult> PersonsPDF()
        {
            List<PersonResponseDTO> persons = await _personService.GetAllPersons();
            return new ViewAsPdf("PersonsPDF", persons, ViewData)
            {
                PageMargins = new Rotativa.AspNetCore.Options.Margins() { Top = 20, Bottom = 20, Left = 20, Right = 20 },
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
            };
        }
        [Route("[action]")]
        public async Task<IActionResult> PersonsCSV()
        {
            MemoryStream memoryStream =  await _personService.GetPersonsCSV();
            return File(memoryStream, "application/octet-stream","persons.csv");
        }

        [Route("[action]")]
        public async Task<IActionResult> PersonsExcel()
        {
            MemoryStream memoryStream = await _personService.GetPersonsExcel();
            return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "persons.xlsx");
        }
    }
}
