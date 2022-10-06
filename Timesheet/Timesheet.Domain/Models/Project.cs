using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public enum ProjectStatus { Active, Inactive, Archive }
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Client Client { get; set; }
        public Lead Lead { get; set; }
        public ProjectStatus Status { get; set; }
        public List<Client> Clients { get; set; }
        public List<Employee> Employees { get; set; }

        private Project(Guid projectId, string description, string name, ProjectStatus projectStatus, Client projectClient, Lead lead)
        {
            Id = projectId;
            Description = description;
            Name = name;
            Status = projectStatus;
            Client = projectClient;
            Lead = lead;
            Clients = new List<Client>();
            Employees = new List<Employee>();
        }

        public static Result<Project> Create(Guid projectId, string description, string name, ProjectStatus projectStatus, Client projectClient, Lead lead)
        {
            Result descriptionResult = Result.SuccessIf(!string.IsNullOrEmpty(description), "Description can not be empty.");
            Result nameResult = Result.SuccessIf(!string.IsNullOrEmpty(name), "Name can not be empty.");
            Result projectStatusResult = Result.SuccessIf(projectStatus == ProjectStatus.Inactive || projectStatus == ProjectStatus.Active || projectStatus == ProjectStatus.Archive, "Project status can not be empty");
            Result projectClientResult = Result.SuccessIf(projectClient != null, "Project client can not be empty.");
            Result leadResult = Result.SuccessIf(lead != null, "Lead can not be empty.");

            Result result = Result.Combine(descriptionResult, nameResult, projectStatusResult, projectClientResult, leadResult);

            return result.IsSuccess ? Result.Success<Project>(new Project(projectId, description, name, projectStatus, projectClient, lead)) : Result.Failure<Project>(result.Error);

        }
    }
}
