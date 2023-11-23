using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface ITokenServiceAccess
    {
        Task<string?> GetNewToken(ApiAccount accountToUse);
    }
}

