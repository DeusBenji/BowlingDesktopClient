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
    public class LaneControl
    {
        readonly ILaneAccess _lAccess;

        public LaneControl()
        {
            _lAccess = new LaneServiceAccess();
        }

        //Method to get all lanes
        public async Task<List<Lane>?> GetAllLanes()
        {
            List<Lane>? foundLanes = null;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                foundLanes = await _lAccess.GetLanes(tokenValue);
                if (_lAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    foundLanes = await _lAccess.GetLanes(tokenValue);
                }
            }

            return foundLanes;
        }
        //Method to save a lane
        public async Task<int> SaveLane(int LaneNumber)
        {
            int insertedId = -1;
            Lane newLane = new(LaneNumber);
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if(tokenValue != null)
            {
                insertedId = await _lAccess.SaveLane(tokenValue, newLane);
                if (_lAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
                return insertedId;
            }
            else
            {
                currentState = TokenState.Invalid;
            }
            if(currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if(tokenValue != null)
                {
                    insertedId = await _lAccess.SaveLane(tokenValue, newLane);
                }
            }

            return insertedId;
        }
        //Method to find a lane by it's ID
        public async Task<Lane?> FindLaneById(int laneId)
        {
            Lane? foundLane = null;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                foundLane = await _lAccess.FindLaneById(tokenValue, laneId);
                if (_lAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    foundLane = await _lAccess.FindLaneById(tokenValue, laneId);
                }
            }

            return foundLane;
        }
        //Method to update a lane by it's ID
        public async Task<bool> UpdateLane(int id, Lane laneToUpdate) 
        {
            bool isUpdated = false;
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                isUpdated = await _lAccess.UpdateLane(tokenValue, id, laneToUpdate);
                if (_lAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    isUpdated = await _lAccess.UpdateLane(tokenValue, id, laneToUpdate);
                }
            }
            

            return isUpdated;
        }

        //Method to delete a lane by it's ID
        public async Task<bool> DeleteLane(int laneId)
        {
            bool isDeleted = false;
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                isDeleted = await _lAccess.DeleteLane(tokenValue, laneId);
                if (_lAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    isDeleted = await _lAccess.DeleteLane(tokenValue, laneId);
                }
            }

            return isDeleted;
        }
        //Gets jwt token
        private async Task<string?> GetToken(TokenState useState)
        {
            TokenManager tokenHelp = new TokenManager();
            string? foundToken = await tokenHelp.GetToken(useState);
            return foundToken;
        }
    }
}
