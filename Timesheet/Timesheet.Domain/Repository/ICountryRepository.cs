using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Repository
{
    public interface ICountryRepository
    {
        Maybe<Country> GetById(Guid id);

        IEnumerable<Country> GetAll();

        void Insert(Country entity);

        void Update(Country entity);

        void Delete(Country entity);

    }
}
