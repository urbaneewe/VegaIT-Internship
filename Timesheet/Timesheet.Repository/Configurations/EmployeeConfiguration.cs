using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timesheet.Repository.Models;

namespace Timesheet.Repository.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name);
            builder.Property(x => x.Email);
            builder.Property(x => x.Password);
            builder.Property(x => x.Username);
            builder.Property(x => x.HoursPerWeek);
            builder.Property(x => x.Role);
            builder.Property(x => x.Status);

        }
    }
}
