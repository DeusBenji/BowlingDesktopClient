using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    internal class PriceServiceAccess : IPriceAccess
    {
        readonly IServiceConnection _priceService;
        readonly String _serviceBaseUrl = "https://localhost:7197/api/prices";
        static readonly string authenType = "Bearer";
        public HttpStatusCode CurrentHttpStatusCode { get; set; }
        public PriceServiceAccess()
        {
            _priceService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Price>?>? GetPrices(int id = -1)
        {
            List<Price>? pricesFromService = null;

            _priceService.UseUrl = _priceService.BaseUrl;
            bool hasValidId = (id > 0);
            if (hasValidId)
            {
                _priceService.UseUrl += id.ToString();
            }
            if (_priceService != null)
            {
                try
                {
                    var serviceResponse = await _priceService.CallServiceGet();
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        if (hasValidId)
                        {
                            Price? foundPrice = JsonConvert.DeserializeObject<Price>(content);
                            if (foundPrice != null)
                            {
                                pricesFromService = new List<Price>() { foundPrice };
                            }
                        }
                        else
                        {
                            pricesFromService = JsonConvert.DeserializeObject<List<Price>>(content);
                        }
                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            pricesFromService = new List<Price>();
                        }
                        else
                        {
                            pricesFromService = null;
                        }
                    }
                }
                catch
                {
                    pricesFromService = null;
                }
            }
            return pricesFromService;
        }
        public async Task<int> SavePrice(string tokenToUse, Price priceToSave)
        {
            int insertedPriceId = -1;
            //
            _priceService.UseUrl = _priceService.BaseUrl;
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _priceService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _priceService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            try
            {
                var json = JsonConvert.SerializeObject(priceToSave);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _priceService.CallServicePost(content);
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse.IsSuccessStatusCode)
                {
                    if (serviceResponse.IsSuccessStatusCode)
                    {
                        string resIdString = await serviceResponse.Content.ReadAsStringAsync();
                        Int32.TryParse(resIdString, out insertedPriceId);
                    }
                    else
                    {
                        insertedPriceId = -2;
                    }
                }
            }
            catch
            {
                insertedPriceId = -3;
            }
            return insertedPriceId;
        }
        public async Task<Price?> FindPriceById(string tokenToUse, int priceId)
        {
            Price? foundPrice = null;
            _priceService.UseUrl = $"{_priceService.BaseUrl}/{priceId}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _priceService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _priceService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);

            try
            {
                var serviceResponse = await _priceService.CallServiceGet();
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    var content = await serviceResponse.Content.ReadAsStringAsync();
                    foundPrice = JsonConvert.DeserializeObject<Price>(content);
                }
            }
            catch
            {
                foundPrice = null;
            }

            return foundPrice;
        }
        public async Task<bool> UpdatePrice(string tokenToUse, int id, Price priceToUpdate)
        {
            bool isUpdated = false;
            _priceService.UseUrl = $"{_priceService.BaseUrl}/{id}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _priceService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _priceService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);

            try
            {
                var json = JsonConvert.SerializeObject(priceToUpdate);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _priceService.CallServicePut(content);
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

        public async Task<bool> DeletePrice(string tokenToUse, int id)
        {
            bool isDeleted = false;
            _priceService.UseUrl = $"{_priceService.BaseUrl}/{id}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _priceService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _priceService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            try
            {
                var serviceResponse = await _priceService.CallServiceDelete();
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
    }
}
