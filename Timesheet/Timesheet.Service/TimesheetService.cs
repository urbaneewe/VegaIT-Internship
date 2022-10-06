using CSharpFunctionalExtensions;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;
using TimesheetByDay = Timesheet.Domain.Models.TimesheetByDay;

namespace Timesheet.Service
{
    public class TimesheetService : ITimesheetService
    {
        private readonly ITimesheetByDayRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public TimesheetService(ITimesheetByDayRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Result Delete(TimesheetByDay timesheet)
        {
            if(timesheet == null || _repository.GetById(timesheet.Id).HasNoValue)
            {
                return Result.Failure("The timesheet that you are trying to delete does not exist.");
            }
            _repository.Delete(timesheet);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully deleted a timesheet");
        }

        public TimesheetByDay GetByDate(DateTime dateFrom, DateTime dateTo, Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public Maybe<TimesheetByDay> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Result Insert(TimesheetByDay timesheet)
        {
            if (_repository.GetById(timesheet.Id).HasValue)
            {
                return Result.Failure("The timesheet already exists.");
            }

            _repository.Insert(timesheet);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully inserted a project.");
        }

        public Result Update(TimesheetByDay timesheet)
        {
            if (timesheet == null)
            {
                return Result.Failure("The timesheet that you are trying to update does not exist.");
            }
            _repository.Update(timesheet);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully updated the project");
        }
    }
}
