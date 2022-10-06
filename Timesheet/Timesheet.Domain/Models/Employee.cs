using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public enum EmployeeRole { Admin, Worker }

    public enum EmployeeStatus { Active, Inactive }

    public class Employee
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

        private Employee() { }

        private Employee(Guid employeeId, string name, string username, string email, string password, double hoursePerWeek, EmployeeRole role, EmployeeStatus status)
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

        public static Result<Employee> Create(Guid employeeId, string name, string username, string email, string password, double hoursPerWeek, EmployeeRole role, EmployeeStatus status)
        {
            Result nameResult = Result.SuccessIf(!string.IsNullOrEmpty(name), "Name can not be empty.");
            Result usernameResult = Result.SuccessIf(!string.IsNullOrEmpty(username), "Username can not be empty.");
            Result emailResult = Result.SuccessIf(!string.IsNullOrEmpty(email), "Email can not be empty");
            Result passwordResult = Result.SuccessIf(!string.IsNullOrEmpty(password), "Password can not be empty.");
            Result hoursPerWeekResult = Result.SuccessIf(hoursPerWeek != 0, "Hours per week can not be empty.");
            Result roleResult = Result.SuccessIf(role == EmployeeRole.Worker || role == EmployeeRole.Admin, "Employee role can not be empty.");
            Result statusResult = Result.SuccessIf(status == EmployeeStatus.Inactive || status == EmployeeStatus.Active, "Employee status can not be empty.");

            Result result = Result.Combine(nameResult, usernameResult, emailResult, passwordResult, hoursPerWeekResult, roleResult, statusResult);

            return result.IsSuccess ? Result.Success<Employee>(new Employee(employeeId, name, username, email, password, hoursPerWeek, role, status)) : Result.Failure<Employee>(result.Error);

        }

    }
}
