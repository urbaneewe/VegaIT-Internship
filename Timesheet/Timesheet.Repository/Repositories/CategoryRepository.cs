using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Timesheet.Domain.Repository;
using Category = Timesheet.Repository.Models.Category;
using DomainCategory = Timesheet.Domain.Models.Category;

namespace Timesheet.Repository.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TimesheetDbContext _dbContext;
        private DbSet<Category> entities;
        private readonly IMapper _mapper;

        public CategoryRepository(TimesheetDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<Category>();
            _mapper = mapper;
        }

        public Maybe<DomainCategory> GetById(Guid id)
        {
            Category category = entities.Find(id);

            if (category == null)
            {
                return Maybe.None;
            }
            return Maybe.From(_mapper.Map<DomainCategory>(category));
        }

        public IEnumerable<DomainCategory> GetAll()
        {
            return entities.Select(_mapper.Map<DomainCategory>);
        }

        public Maybe<DomainCategory> GetByName(string name)
        {
            var categoryDto = entities.SingleOrDefault(x => x.Name == name);

            if (categoryDto == null)
            {
                return Maybe.None;
            }
            return Maybe.From(_mapper.Map<DomainCategory>(categoryDto));
        }

        public void Insert(DomainCategory entity)
        {
            var category = new Category(entity.Id, entity.Name);
            entities.Add(category);
        }

        public void Update(DomainCategory entity)
        {
            Category category = entities.Find(entity.Id);
            category.Name = entity.Name;
            entities.Update(category);
        }

        public void Delete(DomainCategory entity)
        {
            Category category = entities.Find(entity.Id);
            entities.Remove(category);
        }

        public IEnumerable<DomainCategory> GetByFirstLetterAndSearchText(char letter, string text)
        { 
            return entities.Where(s => s.Name.StartsWith(letter) && s.Name.Contains(text)).Select(_mapper.Map<DomainCategory>);
        }
    }
}
