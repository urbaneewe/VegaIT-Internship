namespace Timesheet.Api.Dto
{
    public class LeadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Usernmae { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double HoursPerWeek { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
    }
}
