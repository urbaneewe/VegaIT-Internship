using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Repository
{
    public interface ICategoryRepository
    {
        Maybe<Category> GetById(Guid id);

        IEnumerable<Category> GetAll();

        Maybe<Category> GetByName(string name);

        void Insert(Category entity);

        void Update(Category entity);

        void Delete(Category entity);

        IEnumerable<Category> GetByFirstLetterAndSearchText(char letter, string text);

    }
}
