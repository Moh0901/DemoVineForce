using DemoVineForce.Countries;
using DemoVineForce.Countries.Dto;
using DemoVineForce.States;
using DemoVineForce.States.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoVineForce.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryServive)
        {
            _countryService = countryServive;
        }

        [HttpGet]

        public IActionResult GetCountry()
        {
            var countryList = _countryService.GetAllCountries();

            if (countryList == null || countryList.Count == 0)
            {
                return NotFound("No Country Exists");
            }

            return Ok(countryList);
        }

        [HttpGet("{id}")]
        public IActionResult GetCountryById(int id)
        {
            var country = _countryService.GetCountryById(id);

            if (country == null)
            {
                return NotFound("Country Not Found");
            }

            return Ok(country);
        }

        [HttpPost]
        public IActionResult AddCountry(CountryDTo countryDto)
        {
            if (countryDto == null)
            {
                return NotFound("Country is Empty");
            }
            var newCountry = _countryService.AddCountry(countryDto);

            return Ok(newCountry);
        }

        [HttpPut]

        public IActionResult UpdateCountry(CountryDTo countryDto, int id)
        {
            if (countryDto == null)
            {
                return NotFound();
            }
            var updatedCountry = _countryService.UpdateCountry(countryDto, id);

            if (updatedCountry != null)
            {
                var updateCountryDto = new CountryDTo()
                {
                    CountryName = updatedCountry.CountryName
                };
                return Ok(updateCountryDto);
            }
            return NotFound("Country Not Found");
        }

        [HttpDelete]

        public IActionResult DeleteCountry(int id)
        {
            var country = _countryService.DeleteCountry(id);
            if (country == null)
            {
                return NotFound("Country Not Found");
            }

            return Ok(country);
        }
    }
}
