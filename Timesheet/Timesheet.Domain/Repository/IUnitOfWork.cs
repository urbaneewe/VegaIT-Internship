namespace Timesheet.Domain.Repository
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
