using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface IPriceAccess
    {
        Task<List<Price>?>? GetPrices(int id = -1);
        Task<int> SavePrice(string tokenToUse, Price priceToSave);
        Task<Price?> FindPriceById(string tokenToUse, int priceId);
        Task<bool> UpdatePrice(string tokenToUse, int id, Price priceToUpdate);
        Task<bool> DeletePrice(string tokenToUse, int id);
        HttpStatusCode CurrentHttpStatusCode { get; set; }
    }
}
