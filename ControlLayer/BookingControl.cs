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
    public class BookingControl
    {
        readonly IBookingAccess _bAccess;

        public BookingControl()
        {
            _bAccess = new BookingServiceAccess();
        }

        //Gets a list of bookings
        public async Task<List<Booking>?> GetAllBookings()
        {
            List<Booking>? foundBookings = null;

            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);

            if(tokenValue != null)
            {
                foundBookings = await _bAccess.GetBookings(tokenValue);
                if(_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    foundBookings = await _bAccess.GetBookings(tokenValue);
                }
            }
            foreach (Booking booking in foundBookings)
                {
                    Booking? foundByBookingId = await _bAccess.FindBookingById(booking.Id); // Find booking using booking ID

                    if (foundByBookingId != null)
                    {
                        booking.PriceId = foundByBookingId.PriceId; 
                        booking.LaneId = foundByBookingId.LaneId; 
                    }
               }
            
            return foundBookings;
        }

        //Saves a booking
        public async Task<int> SaveBooking(DateTime StartDateTime, int hoursToPlay, int noOfPlayers, Customer customer)
        {
            int insertedId = -1;
            if(customer != null){
               
                Booking newBooking = new Booking(StartDateTime, hoursToPlay, noOfPlayers, customer);
                insertedId = await _bAccess.SaveBooking(newBooking);
            }
            return insertedId;
        }

        //Finds booking by the customers phone number
        public async Task<List<Booking>?> FindBookingByCustomerPhone(string customerPNO)
        {
            List<Booking>? foundBookings = null;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);

            if (tokenValue != null)
            {
                foundBookings = await _bAccess.FindBookingsByCustomerPhone(tokenValue, customerPNO);
                if (_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    foundBookings = await _bAccess.FindBookingsByCustomerPhone(tokenValue, customerPNO);
                }
            }
            foundBookings = await _bAccess.FindBookingsByCustomerPhone(tokenValue, customerPNO);

            foreach (Booking booking in foundBookings)
            {
                Booking foundByBookingId = await _bAccess.FindBookingById(booking.Id); // Find booking using booking ID

                if (foundByBookingId != null)
                {
                    booking.PriceId = foundByBookingId.PriceId; // Update priceId
                    booking.LaneId = foundByBookingId.LaneId; // Update laneId
                }
            }


            return foundBookings;
        }
        //Finds booking by ID
        public async Task<Booking?> FindBookingById(int bookingId)
        {
            Booking? foundBooking = null;
            
            if(_bAccess != null)
            {
                foundBooking = await _bAccess.FindBookingById( bookingId);
            }

            return foundBooking;
        }
        //Deletes booking by ID
        public async Task<bool> DeleteBooking(int bookingId)
        {
            bool isDeleted = false;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                isDeleted = await _bAccess.DeleteBooking(tokenValue, bookingId);
                if (_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
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
                    isDeleted = await _bAccess.DeleteBooking(tokenValue, bookingId);
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
