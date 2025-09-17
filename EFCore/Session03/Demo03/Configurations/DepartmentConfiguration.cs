using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo03.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Id).UseIdentityColumn(100, 100);

            builder.Property(E => E.Name)
              .HasMaxLength(50)
              .HasColumnName("DeptName")
              .HasColumnType("nvarchar(max)");


        }
    }
}
