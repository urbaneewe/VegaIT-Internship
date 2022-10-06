using Timesheet.Domain.Models;

namespace Timesheet.Repository.Models
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

        public Lead() { }

        public Lead(Guid employeeId, string name, string username, string email, string password, double hoursePerWeek, EmployeeRole role, EmployeeStatus status)
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
    }
}
