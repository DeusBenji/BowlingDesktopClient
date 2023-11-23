using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BowlingDesktopClient.ControlLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;

namespace BowlingDesktopClient.GuiLayer
{
    public partial class BookingMenu : Form
    {
        readonly BookingControl _bookingControl;
        readonly CustomerControl _cusControl;
        readonly PriceControl _priceControl;
        readonly LaneControl _laneControl;
        public BookingMenu()
        {
            InitializeComponent();

            _bookingControl = new BookingControl();
            _cusControl = new CustomerControl();
            _priceControl = new PriceControl();
            _laneControl = new LaneControl();


        }

        private bool InputIsOk(DateTime startDateTime, int hoursToPlay, int noOfPlayers, Customer? customer)
        {
            bool isValidInput = false;
            string datetime = startDateTime.ToString();
            string htp = hoursToPlay.ToString();
            string players = noOfPlayers.ToString();
            if (!String.IsNullOrWhiteSpace(datetime) && !String.IsNullOrWhiteSpace(htp) && !String.IsNullOrWhiteSpace(players) && !String.IsNullOrWhiteSpace(customer.Phone))
            {
                if (hoursToPlay > 1 && noOfPlayers >= 1 && customer.Phone.Length > 6)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }

        private async void buttonFindAll_Click(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Booking>? fetchedBookings = await _bookingControl.GetAllBookings();
            if (fetchedBookings != null)
            {
                if (fetchedBookings.Count >= 1)
                {
                    processText = "Ok";

                }
                else
                {
                    processText = "No Lanes found";
                }
            }
            else
            {
                processText = "Failure: An error occurred";
            }
            labelProcessBooking.Text = processText;
            listBoxBookings.DataSource = fetchedBookings;
        }

        private async void buttonCreateBooking_Click(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;
            // Values from testboxes must be fetched
            int hoursToPlayer = int.Parse(textBoxHoursToPlay.Text);
            int players = int.Parse(textBoxPlayers.Text);
            string phoneNumber = textBoxCustomerPhone.Text;
            Customer customer = await _cusControl.FindCustomerByPhone(phoneNumber);

            DateTime startDateTime = DateTime.Parse(maskedTextBoxSetBookingDate.Text);

            // Evaluate and act accordingly
            if (InputIsOk(startDateTime, hoursToPlayer, players, customer))
            {
                // Call the ControlLayer to get the data saved
                insertedId = await _bookingControl.SaveBooking(startDateTime, hoursToPlayer, players, customer);
                messageText = (insertedId > 0) ? $"Booking saved with no {insertedId}" : "Failure: An error occurred!";
            }
            else
            {
                messageText = "Please input valid informations";
            }
            // Finally put out a message saying if the saving went well 
            labelProcessCreateBooking.Text = messageText;
        }

        private async void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            int bookingId = int.Parse(textBoxDeleteBooking.Text);

            bool isDeleted = await _bookingControl.DeleteBooking(bookingId);

            if (isDeleted)
            {
                MessageBox.Show("Booking slettet.");
            }
          
        }

        private async void buttonFindCustomerByPhone_Click_1(object sender, EventArgs e)
        {
            bool foundCustomer = false;
            string processText = "Good or Not";
            string phone = textBoxFindBy.Text;

            Customer cus = await _cusControl.FindCustomerByPhone(phone);
            if (cus == null || cus.Phone.Length < 5)
            {
                MessageBox.Show("Der er ikke en kunde med dette nummer.");
            }
            else
            {
                List<Booking>? fetchedBooking = await _bookingControl.FindBookingByCustomerPhone(phone);
                if (fetchedBooking != null)
                {
                    if (fetchedBooking != null)
                    {
                        processText = "Ok";
                    }
                    else
                    {
                        processText = "No customers found";
                    }
                }
                else
                {
                    processText = "Failure: An error occurred";
                }
                labelProcessBooking.Text = processText;
                listBoxBookings.DataSource = fetchedBooking;
            }

        }
    }
}
