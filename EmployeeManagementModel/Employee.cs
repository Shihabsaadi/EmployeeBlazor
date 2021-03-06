using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementModel
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set;}
        public DateTime EmployementDate { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string ImagePath { get; set; }
    }
}
