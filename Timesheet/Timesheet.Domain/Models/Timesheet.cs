using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public class Timesheet
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public Category Category { get; set; }
        public Project Project { get; set; }
        public Maybe<string> Description { get; set; }
        public DateTime Hours { get; set; }
        public Maybe<double> Overtime { get; set; }

        private Timesheet(Guid id, Client client, Category category, Project project, Maybe<string> description, DateTime hours, Maybe<double> overtime)
        {
            Id = id;
            Client = client;
            Category = category;
            Project = project;
            Description = description;
            Hours = hours;
            Overtime = overtime;
        }

        public static Result<Timesheet> Create(Guid id, Client client, Category category, Project project, Maybe<string> description, DateTime hours, Maybe<double> overtime)
        {
            Result clientResult = Result.SuccessIf(client != null, "Client can not be empty.");
            Result categoryResult = Result.SuccessIf(category != null, "Category can not be empty");
            Result projectResult = Result.SuccessIf(project != null, "Project can not be empty");
            Result hoursResult = Result.SuccessIf(!string.IsNullOrEmpty(hours.ToString()), "Hours can not be empty.");

            Result result = Result.Combine(clientResult, categoryResult,projectResult, hoursResult);

            return result.IsSuccess ? Result.Success<Timesheet>(new Timesheet(id, client, category, project, description, hours, overtime)) : Result.Failure<Timesheet>(result.Error);
        }


    }
}
