using Dem01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dem01.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            // Best Handing

            //E.HasKey(E =>  new { E.EmpId , E.Email});   // Create Composite PK  By Anonymous Type new { }
            E.HasKey(Employee => Employee.EmpId);

            E.Property(E => E.Name)
             .IsRequired()
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .HasColumnName("EmpName");

            E.Property(E => E.Age)
             .IsRequired(false);

            //E.Property(E => E.Email)
            // .IsRequired(false);

            E.Property(E => E.Salary).HasColumnType("money");
            //E.Property(e => e.DateOfCreation).HasDefaultValueSql("GETDATE()").IsRequired(false);
        }
    }
}
