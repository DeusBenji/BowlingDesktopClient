using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface ILaneAccess
    {
        Task<List<Lane>?>? GetLanes(string tokenToUse, int id = -1);
        Task<int> SaveLane(string tokenToUse, Lane LaneToSave);
        Task<Lane?> FindLaneById(string tokenToUse, int laneId);
        Task<bool> DeleteLane(string tokenToUse, int laneId);
        Task<bool> UpdateLane(string tokenToUse, int id, Lane laneToUpdate);
        HttpStatusCode CurrentHttpStatusCode { get; set; }
    }
}
