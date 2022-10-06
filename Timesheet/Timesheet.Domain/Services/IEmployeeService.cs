using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Services
{
    public interface IEmployeeService
    {
        Maybe<Employee> GetById(Guid id);

        IEnumerable<Employee> GetAll();

        Result Insert(Employee employee);

        Result Update(Employee employee);

        Result Delete(Employee employee);

        Result ChangePassword(Employee employee);
    }
}
