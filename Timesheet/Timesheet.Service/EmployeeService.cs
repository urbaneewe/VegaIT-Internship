using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;

namespace Timesheet.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public Result ChangePassword(Employee employee)
        {
            if (employee == null)
            {
                return Result.Failure("The employee whose password you are trying to change does not exist.");
            }

            _repository.ChangePassword(employee);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully changed the password.");
        }

        public Result Delete(Employee employee)
        {
            if(employee == null || _repository.GetById(employee.Id).HasNoValue )
            {
                return Result.Failure("The employee that you are trying to delete does not exist.");
            }
            _repository.Delete(employee);
            _unitOfWork.SaveChanges();   
            return Result.Success("You have successfully deleted the employee.");
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public Maybe<Employee> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Result Insert(Employee employee)
        {
            //tehnicki se moze desiti da imamo 2 radnika sa istim imenom i prezimenom, ali zbog jednostavnosti je ovako implementirano
            if (_repository.GetByName(employee.Name) != null)
            {
                return Result.Failure("The employee " + employee.Name + "already exists.");
            }

            _repository.Insert(employee);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully inserted an employee");
        }

        public Result Update(Employee employee)
        {
            if (employee == null)
            {
                return Result.Failure("The employee that you are trying to update does not exist.");
            }

            _repository.Update(employee);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully updated the employee.");
        }
    }
}
