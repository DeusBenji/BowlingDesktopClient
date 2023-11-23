using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface IBookingAccess
    {
        Task<List<Booking>?>? GetBookings(string tokenToUse, int id = -1);
        Task<int> SaveBooking(Booking bookingToSave);
        Task<List<Booking>?> FindBookingsByCustomerPhone(string tokenToUse, string phone);
        Task<Booking?> FindBookingById(int id);
        Task<bool> DeleteBooking(string tokenToUse, int bookingId);
        HttpStatusCode CurrentHttpStatusCode { get; set; }
    }
}
