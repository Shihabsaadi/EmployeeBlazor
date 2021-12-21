using EmployeeManagementModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementWeb.Services
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employee>> GetEmployees();
    }
}
