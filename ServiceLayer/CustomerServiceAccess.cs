using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.Models;
using Newtonsoft.Json;
using System.Net;
using System;
using System.Text;


namespace BowlingDesktopClient.ServiceLayer
{
    public class CustomerServiceAccess : ICustomerAccess
    {
        readonly IServiceConnection _customerService;
        readonly String _serviceBaseUrl = "https://localhost:7197/api/customers";
        static readonly string authenType = "Bearer";
        public HttpStatusCode CurrentHttpStatusCode { get; set; }
        public CustomerServiceAccess()
        {
            _customerService = new ServiceConnection(_serviceBaseUrl);
        }
        //Method to retrieve customers
        public async Task<List<Customer>?>? GetCustomers(string tokenToUse, int id = -1)
        {
            List<Customer>? customersFromService = null;

            _customerService.UseUrl = _customerService.BaseUrl;
            if (id > 0)
            {
                _customerService.UseUrl += id.ToString();
            }
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _customerService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _customerService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);

            if (_customerService != null)
            {
                try
                {
                    var serviceResponse = await _customerService.CallServiceGet();
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        customersFromService = JsonConvert.DeserializeObject<List<Customer>>(content);
                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == HttpStatusCode.NoContent)
                        {
                            customersFromService = new List<Customer>();
                        }
                        else
                        {
                            customersFromService = null;
                        }
                    }
                }

                catch
                {
                    customersFromService = null;
                }

            }
            return customersFromService;
            
        }
        public async Task<int> SaveCustomer(Customer customerToSave)
        {
            int insertedCustomerId = -1;
            //
            _customerService.UseUrl = _customerService.BaseUrl;
           
            try
            {
                var json = JsonConvert.SerializeObject(customerToSave);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _customerService.CallServicePost(content);
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse.IsSuccessStatusCode)
                {
                    if (serviceResponse.IsSuccessStatusCode)
                    {
                        string resIdString = await serviceResponse.Content.ReadAsStringAsync();
                        Int32.TryParse(resIdString, out insertedCustomerId);
                    }
                    else
                    {
                        insertedCustomerId = -2;
                    }
                }
            }
            catch
            {
                insertedCustomerId = -3;
            }
            return insertedCustomerId;
        }
        public async Task<bool> DeleteCustomer(string tokenToUse, int customerId)
        {
            bool isDeleted = false;

            _customerService.UseUrl = $"{_customerService.BaseUrl}/{customerId}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _customerService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _customerService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            try
            {
                var serviceResponse = await _customerService.CallServiceDelete();
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    isDeleted = true;
                }
            }
            catch
            {
                isDeleted = false;
            }

            return isDeleted;
        }
        public async Task<bool> UpdateCustomer(string tokenToUse, int customerId, Customer customerToUpdate)
        {
            bool isUpdated = false;

            _customerService.UseUrl = $"{_customerService.BaseUrl}/{customerId}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _customerService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _customerService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            try
            {
                var json = JsonConvert.SerializeObject(customerToUpdate);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _customerService.CallServicePut(content);
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    isUpdated = true;
                }
            }
            catch
            {
                isUpdated = false;
            }

            return isUpdated;
        }
        public async Task<Customer?> FindCustomerByPhone(string phone)
        {
            _customerService.UseUrl = $"{_customerService.BaseUrl}/{phone}";

            try
            {
                var serviceResponse = await _customerService.CallServiceGet();
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    var content = await serviceResponse.Content.ReadAsStringAsync();
                    Customer foundCustomer = JsonConvert.DeserializeObject<Customer>(content);

                    // Retrieve the customer ID from the service response headers
                    if (serviceResponse.Headers.TryGetValues("CustomerID", out var customerIdValues))
                    {
                        if (int.TryParse(customerIdValues.FirstOrDefault(), out var customerId))
                        {
                            foundCustomer.Id = customerId;
                        }
                    }

                    return foundCustomer;
                }
            }
            catch
            {
                // Handle any exceptions here
            }

            return null; // Return null if the customer is not found or if there was an error
        }
    }
}
