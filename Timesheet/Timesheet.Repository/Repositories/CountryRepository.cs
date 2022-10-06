using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Timesheet.Domain.Repository;
using Country = Timesheet.Repository.Models.Country;
using DomainCountry = Timesheet.Domain.Models.Country;

namespace Timesheet.Repository.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly TimesheetDbContext _dbContext;
        private DbSet<Country> entities;
        private readonly IMapper _mapper;

        public CountryRepository(TimesheetDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<Country>();
            _mapper = mapper;
        }

        public Maybe<DomainCountry> GetById(Guid id)
        {
            Country country = entities.Find(id);

            if (country == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainCountry>(country));
        }

        public IEnumerable<DomainCountry> GetAll()
        {
            return entities.Select(_mapper.Map<DomainCountry>);
        }

        public void Insert(DomainCountry entity)
        {
            var country = new Country(entity.Id, entity.Name);
            entities.Add(country);
        }

        public void Update(DomainCountry entity)
        {
            Country country = entities.Find(entity.Id);
            country.Name = entity.Name;
            entities.Update(country);
        }

        public void Delete(DomainCountry entity)
        {
            Country country = entities.Find(entity.Id);
            entities.Remove(country);
        }
    }
}
