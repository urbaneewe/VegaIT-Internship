using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Services
{
    public interface IProjectService
    {
        Maybe<Project> GetById(Guid id);

        IEnumerable<Project> GetAll();

        IEnumerable<Project> GetByFirstLetterAndSearchText(char letter, string text);

        Result Insert(Project project);

        Result Update(Project project);

        Result Delete(Project project);
    }
}
