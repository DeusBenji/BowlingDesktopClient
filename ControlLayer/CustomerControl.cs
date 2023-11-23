using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BowlingDesktopClient.Security;
using System.Net;

namespace BowlingDesktopClient.ControlLayer
{
    public class CustomerControl
    {
        readonly ICustomerAccess _cAccess;

        public CustomerControl()
        {
            _cAccess = new CustomerServiceAccess();
        }

        public async Task<List<Customer>?> GetAllCustomers()
        {
            List<Customer>? foundCustomers = null;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                foundCustomers = await _cAccess.GetCustomers(tokenValue);
                if (_cAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
            }
            else
            {
                currentState = TokenState.Invalid;
            }
            if (currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if (tokenValue != null)
                {
                    foundCustomers = await _cAccess.GetCustomers(tokenValue);
                }
            }
            return foundCustomers;

        }

        public async Task<int> SaveCustomer(string fName, string lName, string email, string mPhone)
        {
            Customer newCustomer = new(fName, lName, email, mPhone);
            int insertedId = await _cAccess.SaveCustomer(newCustomer);
            return insertedId;
        }
        //Method to delete a customer
        public async Task<bool> DeleteCustomer(int customerId)
        {
            bool isDeleted = false;
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);

            if (tokenValue != null)
            {
                _cAccess.DeleteCustomer(tokenValue, customerId);
                if (_cAccess.CurrentHttpStatusCode==HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
                return isDeleted;
            }
            else
            {
                currentState= TokenState.Invalid;
            }
            if(currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if(tokenValue != null)
                {
                    _cAccess.DeleteCustomer(tokenValue, customerId);
                    isDeleted = true;
                }
            }
            return isDeleted;
        }

        public async Task<bool> UpdateCustomer(int id, Customer customerToUpdate)
        {
            bool isUpdated = false;
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (_cAccess != null)
            {
                isUpdated = await _cAccess.UpdateCustomer(tokenValue, id, customerToUpdate);
            }

            return isUpdated;
        }

        public async Task<Customer?> FindCustomerByPhone(string customerPNO)
        {
            Customer? foundCustomer = null;

            if (_cAccess != null)
            {
                foundCustomer = await _cAccess.FindCustomerByPhone(customerPNO);
            }

            return foundCustomer;
        }
        private async Task<string?> GetToken(TokenState useState)
        {
            TokenManager tokenHelp = new TokenManager();
            string? foundToken = await tokenHelp.GetToken(useState);
            return foundToken;
        }



    }
}
