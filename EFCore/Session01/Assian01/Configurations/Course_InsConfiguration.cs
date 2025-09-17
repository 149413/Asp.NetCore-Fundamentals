using Assian01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assian01.Configurations
{
    internal class Course_InsConfiguration : IEntityTypeConfiguration<Course_Ins>
    {
        public void Configure(EntityTypeBuilder<Course_Ins> builder)
        {
            builder.HasKey(PK => new
            {
                PK.InstructorId,
                PK.CourseId
            });

            builder.Property(b => b.evaluate)
                   .IsRequired();
        }
    }
}
