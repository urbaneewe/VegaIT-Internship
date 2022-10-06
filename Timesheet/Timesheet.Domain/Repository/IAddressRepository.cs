using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Repository
{
    public interface IAddressRepository
    {
        Maybe<Address> GetById(Guid id);

        IEnumerable<Address> GetAll();

        void Insert(Address entity);

        void Update(Address entity);

        void Delete(Address entity);
    }
}
