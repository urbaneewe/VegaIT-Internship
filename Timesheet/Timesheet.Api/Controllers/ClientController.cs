using Microsoft.AspNetCore.Mvc;
using Timesheet.Api.Dto;
using Timesheet.Domain.Models;
using Timesheet.Domain.Services;

namespace Timesheet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _clientService.GetById(id);

            if (result == null)
            {
                return BadRequest("No client found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _clientService.GetAll();
            if (result == null)
            {
                return BadRequest("No clients found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetByFirstLetterAndSearchText(char letter, string text)
        {
            var result = _clientService.GetByFirstLetterAndSearchText(letter, text);

            if (result == null)
            {
                return BadRequest("No results found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(ClientDto client)
        {
            Country domainCountry = Country.Create(client.Address.Country.Id, client.Address.Country.Name).Value;
            Address domainAddress = Address.Create(client.Address.Name, client.Address.City, client.Address.PostalCode, domainCountry, client.Address.Id).Value;
            Client domainClient = Client.Create(client.Name, client.Id, domainAddress).Value;
            _clientService.Insert(domainClient);

            return Ok("Client inserted.");
        }

        [HttpPut]
        public IActionResult Update(ClientDto client)
        {
            Country domainCountry = Country.Create(client.Address.Country.Id, client.Address.Country.Name).Value;
            Address domainAddress = Address.Create(client.Address.Name, client.Address.City, client.Address.PostalCode, domainCountry, client.Address.Id).Value;
            Client domainClient = Client.Create(client.Name, client.Id, domainAddress).Value;
            _clientService.Update(domainClient);

            return Ok("Client updated.");
        }

        [HttpDelete]
        public IActionResult Delete(ClientDto client)
        {
            Country domainCountry = Country.Create(client.Address.Country.Id, client.Address.Country.Name).Value;
            Address domainAddress = Address.Create(client.Address.Name, client.Address.City, client.Address.PostalCode, domainCountry, client.Address.Id).Value;
            Client domainClient = Client.Create(client.Name, client.Id, domainAddress).Value;
            var result = _clientService.Delete(domainClient);

            if (domainClient == null || result.IsFailure)
            {
                return BadRequest("Category does not exist");
            }

            return Ok("Category deleted.");
        }
    }
}
