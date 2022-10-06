namespace Timesheet.Repository.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Timesheet> Timesheets { get; set; }
        public byte[] RowVersion { get; set; }
        public Category() { }

        public Category(Guid id, string name)
        {
            Id = id;
            Name = name;
            Timesheets = new List<Timesheet>();
        }
    }
}
