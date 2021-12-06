using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBlazor
{
    public class CustomerService:ICustomerService
    {
        public List<Customer> customers;
        public CustomerService()
        {
            customers = new List<Customer>
            {
                new Customer{Id=1,Name="Anika Nower"},
                new Customer{Id=1,Name="A. F. Rayhan"},
                new Customer{Id=1,Name="Oliul Azam"},
                new Customer{Id=1,Name="Nazrul"}
            };
        }
        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
