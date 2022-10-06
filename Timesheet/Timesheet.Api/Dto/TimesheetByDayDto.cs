namespace Timesheet.Api.Dto
{
    public class TimesheetByDayDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ProjectStatus { get; set; }
        public Guid ClientId { get; set; }
        public DateTime Date { get; set; }
        public double TotalHours { get; set; }
        public EmployeeDto Employee { get; set; }
    }
}
