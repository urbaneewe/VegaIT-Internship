namespace Timesheet.Repository.Models
{
    public class TimesheetByDay
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public double TotalHours { get; set; }
        public ICollection<Timesheet> Timesheets { get; set; }
        public byte[] RowVersion { get; set; }

        public TimesheetByDay() { }

        public TimesheetByDay(DateTime date, Guid employeeId, Guid id, double totalHours)
        {
            Date = date;
            EmployeeId = employeeId;
            Id = id;
            TotalHours = totalHours;
            Timesheets = new List<Timesheet>();
        }
    }
}
