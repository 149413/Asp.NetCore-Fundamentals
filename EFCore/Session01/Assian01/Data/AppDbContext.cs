using Assian01.Configurations;
using Assian01.Models;
using Microsoft.EntityFrameworkCore;

namespace Assian01.Data
{
    internal class AppDbContext : DbContext
    {


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(C =>
            {
                C.HasKey(C => C.CId);

                C.Property(C => C.Name)
                .IsRequired()
                .HasColumnName("CourseName")
                .HasColumnType("nvarchar(30)");

                C.Property(C => C.Description)
                .IsRequired(false);

                C.Property(p => p.Duration)
                .HasDefaultValue(3);


                // Has Topics

                modelBuilder.Entity<Course>()
                            .HasOne(C => C.Topic)
                            .WithMany(T => T.Couses)
                            .HasForeignKey(C => C.Top_Id);




            });

            modelBuilder.Entity<Topic>(T =>
            {
                T.HasKey(T => T.Id);
                T.Property(T => T.Name)
                 .IsRequired()
                 .HasMaxLength(50);

            });

            modelBuilder.ApplyConfiguration(new Instructor_Configuration());

            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());

            modelBuilder.ApplyConfiguration(new Course_InsConfiguration());


            // Studend In Department
            modelBuilder.Entity<Student>()
                        .HasOne(S => S.LearnIn)
                        .WithMany(D => D.Students)
                        .HasForeignKey(S => S.Dept_ID);


            base.OnModelCreating(modelBuilder);
        }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; DataBase= ITI_2; Trusted_Connection=true; TrustServerCertificate=True");

        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }


        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Ins> Courses_Ins { get; set; }

    }
}
