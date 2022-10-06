using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Repository
{
    public interface ITimesheetByDayRepository
    {
        Maybe<TimesheetByDay> GetById(Guid id);

        IEnumerable<TimesheetByDay> GetByDate(DateTime dateFrom, DateTime dateTo, Guid employeeId, Client client, Project project, Category category);

        void Insert(TimesheetByDay entity);
        
        void Update(TimesheetByDay entity);

        void Delete(TimesheetByDay entity);
    }
}
