using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Services
{
    public interface ITimesheetService
    {
        TimesheetByDay GetByDate(DateTime dateFrom, DateTime dateTo, Guid employeeId);

        Maybe<TimesheetByDay> GetById(Guid id);

        Result Insert(TimesheetByDay timesheet);

        Result Update(TimesheetByDay timesheet);

        Result Delete(TimesheetByDay timesheet);
    }
}
