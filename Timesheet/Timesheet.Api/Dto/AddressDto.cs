namespace Timesheet.Api.Dto
{
    public class AddressDto
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public Guid Id { get; set; }
        public CountryDto Country { get; set; }
        
    }
}
