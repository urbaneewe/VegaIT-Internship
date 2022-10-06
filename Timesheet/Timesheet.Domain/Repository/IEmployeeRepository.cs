using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;

namespace Timesheet.Domain.Repository
{
    public interface IEmployeeRepository
    {
        Maybe<Employee> GetById(Guid id);

        Maybe<Employee> GetByName(string name);

        IEnumerable<Employee> GetAll();

        void Insert(Employee entity);

        void Update(Employee entity);

        void Delete(Employee entity);

        void ChangePassword(Employee entity);

    }
}
