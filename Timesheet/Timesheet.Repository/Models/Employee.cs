namespace Timesheet.Repository.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double HoursPerWeek { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Timesheet> Timesheets { get; set; }
        public byte[] RowVersion { get; set; }

        public Employee() { }

        public Employee(Guid id, string name, string username, string email, string password, double hoursPerWeek, string role, string status)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Password = password;
            HoursPerWeek = hoursPerWeek;
            Role = role;
            Status = status;
            Projects = new List<Project>();
            Timesheets = new List<Timesheet>();
        }
    }
}
