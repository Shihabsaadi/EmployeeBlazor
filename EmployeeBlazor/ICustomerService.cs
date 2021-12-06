using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBlazor
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);
    }
}
