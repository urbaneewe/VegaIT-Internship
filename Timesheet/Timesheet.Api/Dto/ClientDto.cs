namespace Timesheet.Api.Dto
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProjectDto> Projects { get; set; }
        public AddressDto Address { get; set; }

    }
}
