using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Timesheet.Repository.Configurations
{
    public class TimesheetConfiguration : IEntityTypeConfiguration<Timesheet.Repository.Models.Timesheet>
    {
        public void Configure(EntityTypeBuilder<Timesheet.Repository.Models.Timesheet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Description);
            builder.Property(x => x.Hours);
            builder.Property(x => x.Overtime);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Timesheets)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne(x => x.Project)
                .WithMany(x => x.Timesheets);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.Timesheets)
                .HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
