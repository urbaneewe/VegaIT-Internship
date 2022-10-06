using Microsoft.AspNetCore.Mvc;
using Timesheet.Api.Dto;
using Timesheet.Domain.Models;
using Timesheet.Domain.Services;

namespace Timesheet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _addressService.GetById(id);

            if (result == null)
            {
                return BadRequest("No address found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _addressService.GetAll();
            if (result == null)
            {
                return BadRequest("No addresses found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(AddressDto address)
        {
            Country domainCountry = Country.Create(address.Country.Id, address.Country.Name).Value;
            Address domainAddress = Address.Create(address.Name, address.City, address.PostalCode, domainCountry, address.Id).Value;
            _addressService.Insert(domainAddress);

            return Ok("Address inserted.");
        }

        [HttpPut]
        public IActionResult Update(AddressDto address)
        {
            Country domainCountry = Country.Create(address.Country.Id, address.Country.Name).Value;
            Address domainAddress = Address.Create(address.Name, address.City, address.PostalCode, domainCountry, address.Id).Value;
            _addressService.Update(domainAddress);

            return Ok("Address updated.");
        }

        [HttpDelete]
        public IActionResult Delete(AddressDto address)
        {
            Country domainCountry = Country.Create(address.Country.Id, address.Country.Name).Value;
            Address domainAddress = Address.Create(address.Name, address.City, address.PostalCode, domainCountry, address.Id).Value;
            var result = _addressService.Delete(domainAddress);

            if (domainAddress == null || result.IsFailure)
            {
                return BadRequest("Address does not exist");
            }

            return Ok("Address deleted.");
        }
    }
}
