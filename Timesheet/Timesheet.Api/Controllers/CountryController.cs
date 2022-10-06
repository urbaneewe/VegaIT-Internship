using Microsoft.AspNetCore.Mvc;
using Timesheet.Api.Dto;
using Timesheet.Domain.Models;
using Timesheet.Domain.Services;

namespace Timesheet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _countryService.GetById(id);

            if (result == null)
            {
                return BadRequest("No country found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _countryService.GetAll();
            if (result == null)
            {
                return BadRequest("No countries found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(CountryDto country)
        {
            Country domainCountry = Country.Create(country.Id, country.Name).Value;
            _countryService.Insert(domainCountry);

            return Ok("Country inserted.");
        }

        [HttpPut]
        public IActionResult Update(CountryDto country)
        {
            Country domainCountry = Country.Create(country.Id, country.Name).Value;
            _countryService.Update(domainCountry);

            return Ok("Category updated.");
        }

        [HttpDelete]
        public IActionResult Delete(CountryDto country)
        {
            Country domainCountry = Country.Create(country.Id, country.Name).Value;
            var result = _countryService.Delete(domainCountry);

            if (domainCountry == null || result.IsFailure)
            {
                return BadRequest("Country does not exist");
            }

            return Ok("Country deleted.");
        }
    }
}
