using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Timesheet.Domain.Repository;
using Address = Timesheet.Repository.Models.Address;
using DomainAddress = Timesheet.Domain.Models.Address;

namespace Timesheet.Repository.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly TimesheetDbContext _dbContext;
        private DbSet<Address> entities;
        private readonly IMapper _mapper;

        public AddressRepository(TimesheetDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<Address>();
            _mapper = mapper;
        }

        public Maybe<DomainAddress> GetById(Guid id)
        {
            Address address = entities.Find(id);

            if (address == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainAddress>(address));
        }

        public void Insert(DomainAddress entity)
        {
            var address = new Address(entity.Name, entity.City, entity.PostalCode, entity.Country.Id, entity.Id);
            entities.Add(address);
        }

        public void Update(DomainAddress entity)
        {
            Address address = entities.Find(entity.Id);
            address.Name = entity.Name;
            entities.Update(address);
        }

        public void Delete(DomainAddress entity)
        {
            Address address = entities.Find(entity.Id);
            entities.Remove(address);
        }

        public IEnumerable<DomainAddress> GetAll()
        {
            return entities.Select(_mapper.Map<DomainAddress>);
        }
    }
}
