using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Repository
{
    public interface IProjectRepository
    {
        Maybe<Project> GetById(Guid id);

        Maybe<Project> GetByName(string name);

        IEnumerable<Project> GetAll();

        void Insert(Project entity);

        void Update(Project entity);

        void Delete(Project entity);

        IEnumerable<Project> GetByFirstLetterAndSearchText(char letter, string text);

    }
}
