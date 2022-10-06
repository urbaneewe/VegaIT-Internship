using Microsoft.AspNetCore.Mvc;
using Timesheet.Api.Dto;
using Timesheet.Domain.Models;
using Timesheet.Domain.Services;

namespace Timesheet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _employeeService.GetById(id);

            if (result == null)
            {
                return BadRequest("No employee found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetAll();
            if (result == null)
            {
                return BadRequest("No employees found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(EmployeeDto employee)
        {
            Enum.TryParse(employee.Status, out EmployeeStatus status);
            Enum.TryParse(employee.Role, out EmployeeRole role);

            Employee domainEmployee = Employee.Create(employee.Id, employee.Name, employee.Username, employee.Email, employee.Password, employee.HoursPerWeek, role, status).Value;
            _employeeService.Insert(domainEmployee);

            return Ok("Employee inserted.");
        }

        [HttpPut]
        public IActionResult Update(EmployeeDto employee)
        {
            Enum.TryParse(employee.Status, out EmployeeStatus status);
            Enum.TryParse(employee.Role, out EmployeeRole role);

            Employee domainEmployee = Employee.Create(employee.Id, employee.Name, employee.Username, employee.Email, employee.Password, employee.HoursPerWeek, role, status).Value;
            _employeeService.Update(domainEmployee);

            return Ok("Employee updated.");
        }

        [HttpPut]
        public IActionResult ChangePassword(EmployeeDto employee)
        {
            Enum.TryParse(employee.Status, out EmployeeStatus status);
            Enum.TryParse(employee.Role, out EmployeeRole role);

            Employee domainEmployee = Employee.Create(employee.Id, employee.Name, employee.Username, employee.Email, employee.Password, employee.HoursPerWeek, role, status).Value;
            _employeeService.ChangePassword(domainEmployee);

            return Ok("Password changed.");
        }

        [HttpDelete]
        public IActionResult Delete(EmployeeDto employee)
        {
            Enum.TryParse(employee.Status, out EmployeeStatus status);
            Enum.TryParse(employee.Role, out EmployeeRole role);

            Employee domainEmployee = Employee.Create(employee.Id, employee.Name, employee.Username, employee.Email, employee.Password, employee.HoursPerWeek, role, status).Value;
            var result = _employeeService.Delete(domainEmployee);

            if (domainEmployee == null || result.IsFailure)
            {
                return BadRequest("Employee does not exist.");
            }

            return Ok("Employee deleted.");
        }
    }
}
