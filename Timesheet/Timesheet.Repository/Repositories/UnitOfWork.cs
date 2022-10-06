using Timesheet.Domain.Repository;

namespace Timesheet.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TimesheetDbContext _dbContext;

        public UnitOfWork(TimesheetDbContext _dbContext) { 
            this._dbContext = _dbContext;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
