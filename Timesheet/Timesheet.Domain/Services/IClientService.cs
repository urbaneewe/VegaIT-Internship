using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Services
{
    public interface IClientService
    {
        Maybe<Client> GetById(Guid id);

        IEnumerable<Client> GetAll();

        IEnumerable<Client> GetByFirstLetterAndSearchText(char letter, string text);

        Result Insert(Client client);

        Result Update(Client client);

        Result Delete(Client client);
    }
}
