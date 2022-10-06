using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheet.Repository.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ProjectStatus { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Timesheet> Timesheets { get; set; }
        public byte[] RowVersion { get; set; }

        [ForeignKey("Client")]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Lead")]
        public Guid LeadId { get; set; }
        public Lead Lead { get; set; }

        public Project() { }


        public Project(Guid id, string description, string name, string projectStatus, Guid clientId, Guid employeeId)
        {
            Id = id;
            Description = description;
            Name = name;
            ProjectStatus = projectStatus;
            ClientId = clientId;
            LeadId = employeeId;
        }
    }
}
