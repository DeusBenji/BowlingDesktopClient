using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingDesktopClient.Security;
using System.Net;

namespace BowlingDesktopClient.ControlLayer
{
    public class PriceControl
    {
        readonly IPriceAccess _pAccess;

        public PriceControl()
        {
            _pAccess = new PriceServiceAccess();
        }

        //Method to get all prices
        public async Task<List<Price>?> GetAllPrices()
        {
            List<Price>? foundPrices = null;
            if (_pAccess != null)
            {
                foundPrices = await _pAccess.GetPrices();
            }
            return foundPrices;
        }
        //Method to create and save a price
        public async Task<int> SavePrice(double? normalPrice, string? weekday)
        {
            int insertedId = -1;
            Price newPrice = new(normalPrice, weekday);
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                insertedId = await _pAccess.SavePrice(tokenValue, newPrice);
                if (_pAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
                return insertedId;
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
                    insertedId = await _pAccess.SavePrice(tokenValue, newPrice);
                }
            }
            await _pAccess.SavePrice(tokenValue, newPrice);
            return insertedId;
        }
        //Method to find a price by it's ID
        public async Task<Price?> FindPriceById(int priceId)
        {
            Price? foundPrice = null;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                foundPrice = await _pAccess.FindPriceById(tokenValue, priceId);
                if (_pAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    foundPrice = await _pAccess.FindPriceById(tokenValue, priceId);
                }
            }

            return foundPrice;
        }
        //Method to find and update a price by ID
        public async Task<bool> UpdatePrice(int id, Price priceToUpdate)
        {
            bool isUpdated = false;
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                isUpdated = await _pAccess.UpdatePrice(tokenValue, id, priceToUpdate);
                if (_pAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    isUpdated = await _pAccess.UpdatePrice(tokenValue, id, priceToUpdate);
                }
            }

            return isUpdated;
        }
        //Method to delete a price by it's ID
        public async Task<bool> DeletePrice(int id)
        {
            bool isDeleted = false;
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                isDeleted = await _pAccess.DeletePrice(tokenValue, id); ;
                if (_pAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    isDeleted = await _pAccess.DeletePrice(tokenValue, id);
                }
            }

            return isDeleted;
        }

        //Gets the jwt token
        private async Task<string?> GetToken(TokenState useState)
        {
            TokenManager tokenHelp = new TokenManager();
            string? foundToken = await tokenHelp.GetToken(useState);
            return foundToken;
        }
    }
}
