using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public class Lead
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double HoursPerWeek { get; set; }
        public EmployeeRole Role { get; set; }
        public EmployeeStatus Status { get; set; }
        public List<Project> Projects { get; set; }
        public List<Timesheet> Timesheets { get; set; }

        private Lead(Guid employeeId, string name, string username, string email, string password, double hoursePerWeek, EmployeeRole role, EmployeeStatus status)
        {
            Id = employeeId;
            Name = name;
            Username = username;
            Email = email;
            Password = password;
            HoursPerWeek = hoursePerWeek;
            Role = role;
            Status = status;
            Projects = new List<Project>();
            Timesheets = new List<Timesheet>();
        }

        public static Result<Lead> Create(Guid employeeId, string name, string username, string email, string password, double hoursPerWeek, EmployeeRole role, EmployeeStatus status)
        {

            Result nameResult = Result.SuccessIf(!string.IsNullOrEmpty(name), "Employee name can not be empty.");
            Result usernameResult = Result.SuccessIf(!string.IsNullOrEmpty(username), "Employee username can not be empty");
            Result emailResult = Result.SuccessIf(!string.IsNullOrEmpty(email), "Employee email can not be empty");
            Result passwordResult = Result.SuccessIf(!string.IsNullOrEmpty(password), "Employee password can not be empty");
            Result hoursResult = Result.SuccessIf(hoursPerWeek != 0, "Employeers hours can not be empty");
            Result roleResult = Result.SuccessIf(role == EmployeeRole.Worker || role == EmployeeRole.Admin, "Employees role can not be empty");
            Result statusResult = Result.SuccessIf(status == EmployeeStatus.Inactive || status == EmployeeStatus.Active, "Employees status can not be empty");

            Result result = Result.Combine(nameResult, usernameResult, emailResult, passwordResult, hoursResult, roleResult, statusResult);

            return result.IsSuccess ? Result.Success<Lead>(new Lead(employeeId, name, username, email, password, hoursPerWeek, role, status)) : Result.Failure<Lead>(result.Error);
        }
    }
}
