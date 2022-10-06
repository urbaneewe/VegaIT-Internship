using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Services
{
    public interface ICategoryService
    {
        Maybe<Category> GetById(Guid id);

        IEnumerable<Category> GetAll();

        IEnumerable<Category> GetByFirstLetterAndSearchText(char letter, string text);

        Result Insert(Category category);

        Result Update(Category category);

        Result Delete(Category category);
    }
}
