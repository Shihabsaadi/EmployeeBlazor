using EmployeeManagementModel;
using System.Collections.Generic;

namespace EmployeeManagementApi.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
