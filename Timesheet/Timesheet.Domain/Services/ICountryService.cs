using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Services
{
    public interface ICountryService
    {
        Maybe<Country> GetById(Guid id);

        IEnumerable<Country> GetAll();

        Result Insert(Country country);

        Result Update(Country country);

        Result Delete(Country country);
    }
}
