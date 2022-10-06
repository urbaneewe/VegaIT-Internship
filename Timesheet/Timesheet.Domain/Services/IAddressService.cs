using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Services
{
    public interface IAddressService
    {
        Maybe<Address> GetById(Guid id);

        IEnumerable<Address> GetAll();

        Result Insert(Address address);

        Result Update(Address address);

        Result Delete(Address address);
    }
}
