using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBlazorServer
{
   public interface ICustomerService
    {
        string uid { get; set; }
        Customer GetCustomer(int id);
    }
}
