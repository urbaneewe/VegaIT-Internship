using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheet.Repository.Models
{
    public class Address
    {
        public Guid Id  { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public byte[] RowVersion { get; set; }

        [ForeignKey("Country")]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        
        public Address() { }

        public Address(string name, string city, int postalCode, Guid countryId, Guid id)
        {
            Name = name;
            City = city;
            PostalCode = postalCode;
            CountryId = countryId;
            Id = id;
        }


    }
}
