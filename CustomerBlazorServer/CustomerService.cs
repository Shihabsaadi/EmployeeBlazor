using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBlazorServer
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers;
        public string uid { get; set; }
        public CustomerService()
        {
            uid = Guid.NewGuid().ToString();
            customers =new List<Customer>
            {    new Customer { Id=1,Name="Anika Nower"},
                 new Customer { Id=2,Name="Oliul Azam" },
                 new Customer { Id=3,Name="A.F. Rayhan"} 
            };
        }
        public Customer GetCustomer(int id)
        {
            return customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
