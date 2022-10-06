using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheet.Repository.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Project> Projects { get; set; }
        public byte[] RowVersion { get; set; }

        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public Client() { }

        public Client(Guid id, string name, Guid addressId)
        {
            Id = id;
            Name = name;
            AddressId = addressId;
            Projects = new List<Project>();
        }
    }
}
