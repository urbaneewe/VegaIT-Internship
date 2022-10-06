using Microsoft.AspNetCore.Mvc;
using Timesheet.Api.Dto;
using Timesheet.Domain.Models;
using Timesheet.Domain.Services;

namespace Timesheet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _projectService.GetById(id);

            if (result == null)
            {
                return BadRequest("No project found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _projectService.GetAll();
            if (result == null)
            {
                return BadRequest("No projects found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetByFirstLetterAndSearchText(char letter, string text)
        {
            var result = _projectService.GetByFirstLetterAndSearchText(letter, text);

            if (result == null)
            {
                return BadRequest("No results found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(ProjectDto project)
        {
            Enum.TryParse(project.ProjectStatus, out ProjectStatus projectStatus);
            Enum.TryParse(project.Lead.Status, out EmployeeStatus leadStatus);
            Enum.TryParse(project.Lead.Role, out EmployeeRole role);

            Country domainCountry = Country.Create(project.Client.Address.Country.Id, project.Client.Address.Country.Name).Value;
            Address domainAddress = Address.Create(project.Client.Address.Name, project.Client.Address.City, project.Client.Address.PostalCode,
                domainCountry, project.Client.Address.Id).Value;
            Client projectClient = Client.Create(project.Client.Name, project.Client.Id, domainAddress).Value;
            Lead projectLead = Lead.Create(project.Lead.Id, project.Lead.Name, project.Lead.Usernmae, project.Lead.Email, project.Lead.Password,
                project.Lead.HoursPerWeek, role, leadStatus).Value;

            Project domainProject = Project.Create(project.Id, project.Description, project.Name, projectStatus, projectClient, projectLead).Value;

            _projectService.Insert(domainProject);
            return Ok("Project inserted");
        }

        [HttpPut]
        public IActionResult Update(ProjectDto project)
        {
            Enum.TryParse(project.ProjectStatus, out ProjectStatus projectStatus);
            Enum.TryParse(project.Lead.Status, out EmployeeStatus leadStatus);
            Enum.TryParse(project.Lead.Role, out EmployeeRole role);

            Country domainCountry = Country.Create(project.Client.Address.Country.Id, project.Client.Address.Country.Name).Value;
            Address domainAddress = Address.Create(project.Client.Address.Name, project.Client.Address.City, project.Client.Address.PostalCode,
                domainCountry, project.Client.Address.Id).Value;
            Client projectClient = Client.Create(project.Client.Name, project.Client.Id, domainAddress).Value;
            Lead projectLead = Lead.Create(project.Lead.Id, project.Lead.Name, project.Lead.Usernmae, project.Lead.Email, project.Lead.Password,
                project.Lead.HoursPerWeek, role, leadStatus).Value;

            Project domainProject = Project.Create(project.Id, project.Description, project.Name, projectStatus, projectClient, projectLead).Value;

            _projectService.Update(domainProject);
            return Ok("Project updated");
        }

        [HttpDelete]
        public IActionResult Delete(ProjectDto project)
        {
            Enum.TryParse(project.ProjectStatus, out ProjectStatus projectStatus);
            Enum.TryParse(project.Lead.Status, out EmployeeStatus leadStatus);
            Enum.TryParse(project.Lead.Role, out EmployeeRole role);

            Country domainCountry = Country.Create(project.Client.Address.Country.Id, project.Client.Address.Country.Name).Value;
            Address domainAddress = Address.Create(project.Client.Address.Name, project.Client.Address.City, project.Client.Address.PostalCode,
                domainCountry, project.Client.Address.Id).Value;
            Client projectClient = Client.Create(project.Client.Name, project.Client.Id, domainAddress).Value;
            Lead projectLead = Lead.Create(project.Lead.Id, project.Lead.Name, project.Lead.Usernmae, project.Lead.Email, project.Lead.Password,
                project.Lead.HoursPerWeek, role, leadStatus).Value;

            Project domainProject = Project.Create(project.Id, project.Description, project.Name, projectStatus, projectClient, projectLead).Value;
            var result = _projectService.Delete(domainProject);

            if (domainProject == null || result.IsFailure)
            {
                return BadRequest("Project does not exist");
            }

            return Ok("Project deleted.");
        }
    }
}
