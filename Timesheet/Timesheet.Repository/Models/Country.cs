namespace Timesheet.Repository.Models
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }

        public Country() { }

        public Country(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
