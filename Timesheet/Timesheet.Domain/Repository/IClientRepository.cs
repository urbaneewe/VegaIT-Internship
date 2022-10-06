using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Repository
{
    public interface IClientRepository
    {
        Maybe<Client> GetById(Guid id);

        Maybe<Client> GetByName(string name);

        IEnumerable<Client> GetAll();

        void Insert(Client entity);

        void Update(Client entity);

        void Delete(Client entity);

        IEnumerable<Client> GetByFirstLetterAndSearchText(char letter, string text);
    }
}
