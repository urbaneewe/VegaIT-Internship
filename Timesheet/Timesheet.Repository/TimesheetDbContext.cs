using Microsoft.EntityFrameworkCore;
using Address = Timesheet.Repository.Models.Address;
using Category = Timesheet.Repository.Models.Category;
using Client = Timesheet.Repository.Models.Client;
using Country = Timesheet.Repository.Models.Country;
using Employee = Timesheet.Repository.Models.Employee;
using Project = Timesheet.Repository.Models.Project;
using TimesheetByDay = Timesheet.Repository.Models.TimesheetByDay;

namespace Timesheet.Repository
{
    public class TimesheetDbContext : DbContext
    {
        public DbSet<Timesheet.Repository.Models.Timesheet> Timesheet { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<TimesheetByDay> TimesheetByDay { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Project> Project { get; set; }


        public TimesheetDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Category>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Address>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Models.Timesheet>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Client>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Employee>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Project>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<TimesheetByDay>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TimesheetDbContext).Assembly);
        }
    }
}
