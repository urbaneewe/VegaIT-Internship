using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public class TimesheetByDay
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }
        public double TotalHours { get; set; }
        public List<Timesheet> Timesheets { get; set; }

        private TimesheetByDay(Guid id, DateTime date, Employee employee, double totalHours)
        {
            Id = id;
            Date = date;
            Employee = employee;
            TotalHours = totalHours;
            Timesheets = new List<Timesheet>();
        }

        public static Result<TimesheetByDay> Create(Guid id, DateTime date, Employee employee, double totalHours)
        {

            Result dateResult = Result.SuccessIf(date.GetHashCode() != 0, "Date cannot be empty");
            Result employeeResult = Result.SuccessIf(employee != null, "Employee cannot be empty.");
            Result hoursResult = Result.SuccessIf(totalHours != 0, "Hours cannot be empty.");

            Result result = Result.Combine(dateResult, employeeResult, hoursResult);

            return result.IsSuccess ? Result.Success<TimesheetByDay>(new TimesheetByDay(id, date, employee, totalHours)) : Result.Failure<TimesheetByDay>(result.Error);
        }
    }
}
