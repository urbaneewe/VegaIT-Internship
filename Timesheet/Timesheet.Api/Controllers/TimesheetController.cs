using Microsoft.AspNetCore.Mvc;
using Timesheet.Api.Dto;
using Timesheet.Domain.Models;
using Timesheet.Domain.Services;

namespace Timesheet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TimesheetController : Controller
    {
        private readonly ITimesheetService _timesheetService;

        public TimesheetController(ITimesheetService timesheetService)
        {
            _timesheetService = timesheetService;
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _timesheetService.GetById(id);

            if (result == null)
            {
                return BadRequest("No timesheet found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(TimesheetByDayDto timesheet)
        {
            Enum.TryParse(timesheet.Employee.Status, out EmployeeStatus status);
            Enum.TryParse(timesheet.Employee.Role, out EmployeeRole role);

            Employee domainEmployee = Employee.Create(timesheet.Employee.Id, timesheet.Employee.Name, timesheet.Employee.Username, 
                timesheet.Employee.Email, timesheet.Employee.Password, timesheet.Employee.HoursPerWeek, role, status).Value;
            TimesheetByDay domainTimesheet = TimesheetByDay.Create(timesheet.Id, timesheet.Date, domainEmployee, timesheet.TotalHours).Value;

            _timesheetService.Insert(domainTimesheet);
            return Ok("Timesheet inserted.");
        }
        [HttpPut]
        public IActionResult Update(TimesheetByDayDto timesheet)
        {
            Enum.TryParse(timesheet.Employee.Status, out EmployeeStatus status);
            Enum.TryParse(timesheet.Employee.Role, out EmployeeRole role);

            Employee domainEmployee = Employee.Create(timesheet.Employee.Id, timesheet.Employee.Name, timesheet.Employee.Username,
                timesheet.Employee.Email, timesheet.Employee.Password, timesheet.Employee.HoursPerWeek, role, status).Value;
            TimesheetByDay domainTimesheet = TimesheetByDay.Create(timesheet.Id, timesheet.Date, domainEmployee, timesheet.TotalHours).Value;

            _timesheetService.Update(domainTimesheet);
            return Ok("Timesheet updated.");
        }
        [HttpDelete]
        public IActionResult Delete(TimesheetByDayDto timesheet)
        {
            Enum.TryParse(timesheet.Employee.Status, out EmployeeStatus status);
            Enum.TryParse(timesheet.Employee.Role, out EmployeeRole role);

            Employee domainEmployee = Employee.Create(timesheet.Employee.Id, timesheet.Employee.Name, timesheet.Employee.Username,
                timesheet.Employee.Email, timesheet.Employee.Password, timesheet.Employee.HoursPerWeek, role, status).Value;
            TimesheetByDay domainTimesheet = TimesheetByDay.Create(timesheet.Id, timesheet.Date, domainEmployee, timesheet.TotalHours).Value;
            var result = _timesheetService.Delete(domainTimesheet);

            if (domainTimesheet == null || result.IsFailure)
            {
                return BadRequest("Timesheet does not exist");
            }

            return Ok("Timesheet deleted.");
        }
    }
}
