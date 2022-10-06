using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timesheet.Repository.Models;

namespace Timesheet.Repository.Configurations
{
    public class TimesheetByDayConfiguration : IEntityTypeConfiguration<TimesheetByDay>
    {
        public void Configure(EntityTypeBuilder<TimesheetByDay> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Date);
            builder.Property(x => x.EmployeeId);
            builder.Property(x => x.TotalHours);
            builder.HasMany(x => x.Timesheets).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
