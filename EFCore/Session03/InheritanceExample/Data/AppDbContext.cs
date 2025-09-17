using InheritanceExample.Models;
using Microsoft.EntityFrameworkCore;

namespace InheritanceExample.Data
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// TPH 2
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            //// TPC 
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");


        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString: "Server=.; Database=App02; Trusted_Connection=True; TrustServerCertificate=True;");


        }


        //public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }



    }
}
