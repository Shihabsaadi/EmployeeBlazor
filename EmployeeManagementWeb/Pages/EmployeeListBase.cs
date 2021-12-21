using EmployeeManagementModel;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using EmployeeManagementWeb.Services;
using System.Linq;

namespace EmployeeManagementWeb.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee>  Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployeesAsync);
            //Employees = (await EmployeeService.GetEmployees()).ToList();
        }
        public async Task LoadEmployeesAsync()
        {
            System.Threading.Thread.Sleep(5000);
            //Employee employee = new Employee
            //{
            //    EmployeeId = 1,
            //    FirstName = "Ahmad",
            //    LastName = "Shihab",
            //    DepartmentId = 1,
            //    CreatedDate = DateTime.Now,
            //    EmployementDate = DateTime.Now,
            //    Gender = Gender.Male,
            //    ImagePath = Gender.Male + ".png"
            //};
            //Employee employee2 = new Employee
            //{
            //    EmployeeId = 1,
            //    FirstName = "Ahmad",
            //    LastName = "Saquib",
            //    DepartmentId = 2,
            //    CreatedDate = DateTime.Now,
            //    EmployementDate = DateTime.Now,
            //    Gender = Gender.Male,
            //    ImagePath = Gender.Male + ".png"
            //};
            //Employee employee3 = new Employee
            //{
            //    EmployeeId = 1,
            //    FirstName = "Ahmad",
            //    LastName = "Tofayel",
            //    DepartmentId = 3,
            //    CreatedDate = DateTime.Now,
            //    EmployementDate = DateTime.Now,
            //    Gender = Gender.Male,
            //    ImagePath = Gender.Male + ".png"
            //};
            //Employee employee4 = new Employee
            //{
            //    EmployeeId = 1,
            //    FirstName = "Ahmad",
            //    LastName = "Nazrul",
            //    DepartmentId = 1,
            //    CreatedDate = DateTime.Now,
            //    EmployementDate = DateTime.Now,
            //    Gender = Gender.Male,
            //    ImagePath = Gender.Male + ".png"
            //};
            //Employee employee5 = new Employee
            //{
            //    EmployeeId = 1,
            //    FirstName = "Ahmad",
            //    LastName = "Anika",
            //    DepartmentId = 1,
            //    CreatedDate = DateTime.Now,
            //    EmployementDate = DateTime.Now,
            //    Gender = Gender.Female,
            //    ImagePath = Gender.Female + ".png"
            //};
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
    }
}
