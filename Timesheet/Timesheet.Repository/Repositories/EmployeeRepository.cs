using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Timesheet.Domain.Repository;
using DomainEmployee = Timesheet.Domain.Models.Employee;
using Employee = Timesheet.Repository.Models.Employee;

namespace Timesheet.Repository.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TimesheetDbContext _dbContext;
        private DbSet<Employee> entities;
        private readonly IMapper _mapper;

        public EmployeeRepository(TimesheetDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<Employee>();
            _mapper = mapper;
        }

        public void Delete(DomainEmployee entity)
        {
            Employee employee = entities.Find(entity.Id);
            entities.Remove(employee);
        }

        public IEnumerable<DomainEmployee> GetAll()
        {
            return entities.Select(_mapper.Map<DomainEmployee>);
        }

        public Maybe<DomainEmployee> GetById(Guid id)
        {
            Employee employee = entities.Find(id);

            if (employee == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainEmployee>(employee));
        }

        public Maybe<DomainEmployee> GetByName(string name)
        {
            var employee = entities.SingleOrDefault(x => x.Name == name);
            if (employee == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainEmployee>(employee));
        }

        public void Insert(DomainEmployee entity)
        {
            var employee = new Employee(entity.Id, entity.Name, entity.Username, entity.Email, entity.Password, entity.HoursPerWeek, entity.Role.ToString(), entity.Status.ToString());
            entities.Add(employee);
        }

        public void ChangePassword(DomainEmployee entity)
        {
            Employee employee = entities.Find(entity.Id);
            employee.Password = entity.Password;

            entities.Update(employee);
        }

        public void Update(DomainEmployee entity)
        {
            Employee employee = entities.Find(entity.Id);
            employee.Name = entity.Name;
            employee.Username = entity.Username;
            employee.Email = entity.Email;
            employee.HoursPerWeek = entity.HoursPerWeek;
            employee.Role = entity.Role.ToString();
            employee.Status = entity.Status.ToString();

            entities.Update(employee);
        }
    }
}
