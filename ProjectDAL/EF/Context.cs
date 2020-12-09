
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ProjectDAL.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDAL.EF
{
    public class Context:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public Context(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                Name = "admin",
                Surname="Test",
                Patronimic="Subject",
                DateOfComing=DateTime.Now
            });

            
            modelBuilder.Entity<Employee>().HasOne(t => t.Company).WithMany(t => t.Employees);


        }
    }
}
