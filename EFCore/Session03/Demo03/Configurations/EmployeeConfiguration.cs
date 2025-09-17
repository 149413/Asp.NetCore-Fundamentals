using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo03.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);


            builder.Property(E => E.Id)
                .UseIdentityColumn(10, 10);

            builder.Property(E => E.Name)
                .HasMaxLength(50)
                .HasColumnType("nvarchar(max)");

            builder.Property(E => E.Salary)
                   .HasColumnType("money");


            builder.Property(E => E.Address)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(50);


            builder.HasOne(E => E.WorkFor)
                   .WithMany(D => D.Employees)
                   .HasForeignKey(E => E.Dept_Id);



        }
    }
}
