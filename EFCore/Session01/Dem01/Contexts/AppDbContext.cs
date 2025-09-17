using Dem01.Configurations;
using Dem01.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dem01.Contexts
{
    internal class AppDbContext : DbContext
    {

        // 3. By Flaunt API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Demo1

            //modelBuilder.Entity<Employee>().ToVi;

            ////modelBuilder.Entity<Employee>().HasKey("EmpId");
            ////modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
            //modelBuilder.Entity<Employee>().HasKey(Employee => Employee.EmpId);

            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Name)
            //            .IsRequired()
            //            .HasColumnType("nvarchar")
            //            .HasMaxLength(50)
            //            .HasColumnName("EmpName");

            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Age)
            //            .IsRequired(false);

            //modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("money");

            ////modelBuilder.Entity<Employee>().Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now);

            //modelBuilder.Entity<Employee>().Property(e => e.DateOfCreation).HasDefaultValueSql("GETDATE()");


            //// Best Handing
            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E.HasKey(Employee => Employee.EmpId);

            //    E.Property(E => E.Name)
            //     .IsRequired()
            //     .HasColumnType("nvarchar")
            //     .HasMaxLength(50)
            //     .HasColumnName("EmpName");

            //    E.Property(E => E.Age)
            //     .IsRequired(false);

            //    E.Property(E => E.Salary).HasColumnType("money");

            //    //modelBuilder.Entity<Employee>().Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now);

            //    E.Property(e => e.DateOfCreation).HasDefaultValueSql("GETDATE()");
            //}); 
            #endregion


            #region Relations

            // Relations
            // One To One RelationShip [Manage]


            //// From Employee
            //modelBuilder.Entity<Employee>()
            //            .HasOne(E => E.Department)
            //            .WithOne(D => D.Manager)
            //            .HasForeignKey<Department>(D => D.EmpId);

            //From Department
            modelBuilder.Entity<Department>()
                        .HasOne(D => D.Manager)
                        .WithOne(E => E.Department)
                        .HasForeignKey<Department>(D => D.EmpId);


            //One To Many RelationShip[Work For]

            //From Department
            modelBuilder.Entity<Department>()
                        .HasMany(D => D.Employees)
                        .WithOne(E => E.WorkFor)
                        .HasForeignKey(E => E.WorkForId);


            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.StudentId, SC.CourseId });



            #region Note
            // Note: The Best Practise for Implemeent Relationships is
            // - Flaunt API
            // - Class Configuration

            #endregion


            #endregion




            // 4. By Class Configuration          
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());




            base.OnModelCreating(modelBuilder);
        }

        public AppDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=APP01; Trusted_Connection=True; TrustServerCertificate=True");
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }



    }
}
