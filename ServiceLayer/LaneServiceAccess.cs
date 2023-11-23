using BowlingDesktopClient.Models;
using BowlingDesktopClient.Security;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    public class LaneServiceAccess : ILaneAccess
    {
        readonly IServiceConnection _LaneService;
        readonly String _serviceBaseUrl = "https://localhost:7197/api/lanes";
        static readonly string authenType = "Bearer";
        public HttpStatusCode CurrentHttpStatusCode { get; set; }
        public LaneServiceAccess()
        {
            _LaneService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Lane>?>? GetLanes(string tokenToUse, int id = -1)
        {
            List<Lane>? lanesFromService = null;

            _LaneService.UseUrl = _LaneService.BaseUrl;
            bool hasValidId = (id > 0);
            if (hasValidId)
            {
                _LaneService.UseUrl += id.ToString();
            }
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _LaneService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _LaneService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            if (_LaneService != null)
            {
                try
                {
                    var serviceResponse = await _LaneService.CallServiceGet();
                    CurrentHttpStatusCode = serviceResponse != null ? serviceResponse.StatusCode : HttpStatusCode.BadRequest;

                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        if (hasValidId)
                        {
                            Lane? foundLane = JsonConvert.DeserializeObject<Lane>(content);
                            if (foundLane != null)
                            {
                                lanesFromService = new List<Lane>() { foundLane };
                            }
                        }
                        else
                        {
                            lanesFromService = JsonConvert.DeserializeObject<List<Lane>>(content);
                        }
                    }
                    else
                    {
                        if(serviceResponse != null && serviceResponse.StatusCode == HttpStatusCode.NoContent)
                        {
                            lanesFromService = new List<Lane>();
                        }
                        else
                        {
                            lanesFromService = null;
                        }
                       
                    }
                }
                catch
                {
                    lanesFromService = null;
                }
            }
            return lanesFromService;
        }
        public async Task<int> SaveLane(string tokenToUse, Lane laneToSave)
        {
            int insertedLaneId = -1;
            
            _LaneService.UseUrl = _LaneService.BaseUrl;
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _LaneService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _LaneService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);

            try
            {
                var json = JsonConvert.SerializeObject(laneToSave);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _LaneService.CallServicePost(content);
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse.IsSuccessStatusCode)
                {
                    if (serviceResponse.IsSuccessStatusCode)
                    {
                        string resIdString = await serviceResponse.Content.ReadAsStringAsync();
                        Int32.TryParse(resIdString, out insertedLaneId);
                    }
                    else
                    {
                        insertedLaneId = -2;
                    }
                }
            }
            catch
            {
                insertedLaneId = -3;
            }
            return insertedLaneId;
        }
        public async Task<Lane?> FindLaneById(string tokenToUse, int laneId)
        {
            Lane? foundLane = null;
            _LaneService.UseUrl = $"{_LaneService.BaseUrl}/{laneId}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _LaneService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _LaneService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            try
            {
                var serviceResponse = await _LaneService.CallServiceGet();
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    var content = await serviceResponse.Content.ReadAsStringAsync();
                    foundLane = JsonConvert.DeserializeObject<Lane>(content);
                }
            }
            catch
            {
                foundLane = null;
            }

            return foundLane;
        }
        public async Task<bool> UpdateLane(string tokenToUse, int id, Lane laneToUpdate) 
        {
            bool isUpdated = false;

            _LaneService.UseUrl = $"{_LaneService.BaseUrl}/{id}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _LaneService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _LaneService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            try
            {
                var json = JsonConvert.SerializeObject(laneToUpdate);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _LaneService.CallServicePut(content);
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

        public async Task<bool> DeleteLane(string tokenToUse, int laneId)
        {
            bool isDeleted = false;

            _LaneService.UseUrl = $"{_LaneService.BaseUrl}/{laneId}";
            // Must add Bearer token to request header
            string bearerTokenValue = authenType + " " + tokenToUse;
            _LaneService.HttpEnabler.DefaultRequestHeaders.Remove("Authorization");   // To avoid more Authorization headers
            _LaneService.HttpEnabler.DefaultRequestHeaders.Add("Authorization", bearerTokenValue);
            try
            {
                var serviceResponse = await _LaneService.CallServiceDelete();
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
