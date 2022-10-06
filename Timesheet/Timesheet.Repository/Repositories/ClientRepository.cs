using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Timesheet.Domain.Repository;
using Client = Timesheet.Repository.Models.Client;
using DomainClient = Timesheet.Domain.Models.Client;


namespace Timesheet.Repository.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly TimesheetDbContext _dbContext;
        private DbSet<Client> entities;
        private readonly IMapper _mapper;

        public ClientRepository(TimesheetDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<Client>();
            _mapper = mapper;
        }

        public void Delete(DomainClient entity)
        {
            Client client= entities.Find(entity.Id);
            entities.Remove(client);
        }

        public IEnumerable<DomainClient> GetAll()
        {
            var clients = entities.Include(x => x.Address)
                                  .Include(x => x.Address.Country);

            return clients.Select(_mapper.Map<DomainClient>);
        }

        public IEnumerable<DomainClient> GetByFirstLetterAndSearchText(char letter, string text)
        {
            return entities.Where(s => s.Name.StartsWith(letter) && s.Name.Contains(text))
                           .Select(_mapper.Map<DomainClient>);
        }

        public Maybe<DomainClient> GetById(Guid id)
        {
            Client client = entities.Find(id);

            if (client == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainClient>(client));
        }

        public Maybe<DomainClient> GetByName(string name)
        {
            var client = entities.SingleOrDefault(x => x.Name == name);
            if (client == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainClient>(client));
        }

        public void Insert(DomainClient entity)
        {
            var client = new Client(entity.Id, entity.Name, entity.Address.Id);
            entities.Add(client);
        }

        public void Update(DomainClient entity)
        {
            Client client = entities.Find(entity.Id);
            client.Name = entity.Name;
            client.Address.Name = entity.Address.Name;
            client.Address.City = entity.Address.City;
            client.Address.PostalCode = entity.Address.PostalCode;

            entities.Update(client);
        }
    }
}
