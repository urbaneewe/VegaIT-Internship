using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Timesheet.Domain.Repository;
using DomainCategory = Timesheet.Domain.Models.Category;
using DomainClient = Timesheet.Domain.Models.Client;
using DomainProject = Timesheet.Domain.Models.Project;
using DomainTimesheet = Timesheet.Domain.Models.TimesheetByDay;
using RepositoryTimesheet = Timesheet.Repository.Models.TimesheetByDay;

namespace Timesheet.Repository.Repositories
{
    public class TimesheetByDayRepository : ITimesheetByDayRepository
    {
        private readonly TimesheetDbContext _dbContext;
        private DbSet<RepositoryTimesheet> entities;
        private readonly IMapper _mapper;

        public TimesheetByDayRepository(TimesheetDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<RepositoryTimesheet>();
            _mapper = mapper;
        }

        public Maybe<DomainTimesheet> GetById(Guid id)
        {
            RepositoryTimesheet timesheet = entities.Find(id);

            if (timesheet == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainTimesheet>(timesheet));
        }

        public IEnumerable<DomainTimesheet> GetByDate(DateTime dateFrom, DateTime dateTo, Guid employeeId,
            DomainClient client, DomainProject project, DomainCategory category)
        {
            //TODO: Fix the method.
            var timesheets = from t in _dbContext.TimesheetByDay
                             from c in _dbContext.Client
                             from p in _dbContext.Project
                             from ca in _dbContext.Category
                             where t.EmployeeId == employeeId && (t.Date >= dateFrom && t.Date <= dateTo)
                             select _mapper.Map<DomainTimesheet>(t);

            //var timesheets = _dbContext.TimesheetByDay.Where(s => s.Date >= dateFrom && s.Date <= dateTo && s.EmployeeId == employeeId)
            //.Select(_mapper.Map<DomainTimesheet>);

            return timesheets;
        }

        public void Insert(DomainTimesheet entity)
        {
            var timesheet = new RepositoryTimesheet(entity.Date, entity.Employee.Id, entity.Id, entity.TotalHours);
            entities.Add(timesheet);
        }

        public void Update(DomainTimesheet entity)
        {
            RepositoryTimesheet timesheet = entities.Find(entity.Id);
            timesheet.Date = entity.Date;
            timesheet.EmployeeId = entity.Employee.Id;
            timesheet.TotalHours = entity.TotalHours;

            entities.Update(timesheet);
        }

        public void Delete(DomainTimesheet entity)
        {
            RepositoryTimesheet timesheet = entities.Find(entity.Id);
            entities.Remove(timesheet);
        }
    }
}
