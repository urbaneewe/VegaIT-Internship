using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheet.Repository.Models
{
    public class Timesheet
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Hours { get; set; }
        public double Overtime { get; set; }
        public byte[] RowVersion { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Project")]
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Timesheet() { }

        public Timesheet(Guid categoryId, Guid clientId, string description, DateTime hours, double overtime, Guid projectId, Guid id, Guid Employee)
        {
            CategoryId = categoryId;
            Description = description;
            Hours = hours;
            Overtime = overtime;
            ProjectId = projectId;
            Id = id;
            EmployeeId = Employee;
        }
    }
}
