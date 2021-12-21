using EmployeeManagementModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagementApi.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId=1,DepartmentName="CRM"});
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Media" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "Designing" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 5, DepartmentName = "Management" });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Ahmad",
                LastName = "Shihab",
                DepartmentId = 1,
                CreatedDate = DateTime.Now,
                EmployementDate = DateTime.Now,
                Gender = Gender.Male,
                ImagePath = Gender.Male + ".png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Ahmad",
                LastName = "Saquib",
                DepartmentId = 2,
                CreatedDate = DateTime.Now,
                EmployementDate = DateTime.Now,
                Gender = Gender.Male,
                ImagePath = Gender.Male + ".png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Ahmad",
                LastName = "Tofayel",
                DepartmentId = 3,
                CreatedDate = DateTime.Now,
                EmployementDate = DateTime.Now,
                Gender = Gender.Male,
                ImagePath = Gender.Male + ".png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Ahmad",
                LastName = "Nazrul",
                DepartmentId = 1,
                CreatedDate = DateTime.Now,
                EmployementDate = DateTime.Now,
                Gender = Gender.Male,
                ImagePath = Gender.Male + ".png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Ahmad",
                LastName = "Anika",
                DepartmentId = 1,
                CreatedDate = DateTime.Now,
                EmployementDate = DateTime.Now,
                Gender = Gender.Female,
                ImagePath = Gender.Female + ".png"
            });
        }
    }
}
