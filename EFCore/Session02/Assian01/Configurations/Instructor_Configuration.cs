using Assian01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assian01.Configurations
{
    internal class Instructor_Configuration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(Ins => Ins.Ins_Id);
            builder.Property(Ins => Ins.Name).IsRequired().HasMaxLength(50);
            builder.Property(Ins => Ins.Bouns).IsRequired(false);
            builder.Property(Ins => Ins.Salary).HasColumnType("money");
            builder.Property(Ins => Ins.HourRate).IsRequired(false);


            //// Manage Department
            //builder.HasOne(Ins => Ins.Department)
            //       .WithOne(D => D.Manager)
            //       .HasForeignKey<Department>(D => D.MangerId);

            //// Work For
            builder.HasOne(Ins => Ins.WorkFor)
                   .WithMany(D => D.Instructors)
                   .HasForeignKey(Ins => Ins.Dept_Id);




        }
    }
}
