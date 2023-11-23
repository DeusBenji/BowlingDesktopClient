using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface ICustomerAccess
    {
        Task<List<Customer>?>? GetCustomers(string tokenToUse, int id = -1);
        Task<int> SaveCustomer(Customer customerToSave);
        public Task<bool> DeleteCustomer(string tokenToUse, int customerId);
        public Task<bool> UpdateCustomer(string tokenToUse, int id, Customer customerToUpdate);
        Task<Customer?> FindCustomerByPhone(string phone);
        HttpStatusCode CurrentHttpStatusCode { get; set; }


    }
}
