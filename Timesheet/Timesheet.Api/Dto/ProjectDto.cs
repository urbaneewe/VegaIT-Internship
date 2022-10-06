namespace Timesheet.Api.Dto
{
    public class ProjectDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectStatus { get; set; }
        public ClientDto Client { get; set; }
        public LeadDto Lead{ get; set; }
    }
}
