using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Demo03.Data
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.Entity<DepaermentManager>().ToView("DepartmentManagersView").HasNoKey();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString: "Server=.; Database=AppG102; Trusted_Connection=True; TrustServerCertificate=True;");


        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<DepaermentManager> DepaermentManagers { get; set; }

    }
}
