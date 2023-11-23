using BowlingDesktopClient.ControlLayer;
using BowlingDesktopClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingDesktopClient.GuiLayer
{
    public partial class CreatePriceMenu : Form
    {
        readonly PriceControl _priceControl;
        public CreatePriceMenu()
        {
            InitializeComponent();
            _priceControl = new PriceControl();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;
            // Values from testboxes must be fetched
            double normalPrice = double.Parse(textBoxNormalPrice.Text);

            string weekday = textBoxWeekday.Text;
            // Evaluate and act accordingly
            if (InputIsOk(normalPrice, weekday))
            {
                // Call the ControlLayer to get the data saved
                insertedId = await _priceControl.SavePrice(normalPrice, weekday);
                messageText = (insertedId > 0) ? $"Price saved with no {insertedId}" : "Failure: An error occurred!";
            }
            else
            {
                messageText = "Please input valid informations";
            }
            // Finally put out a message saying if the saving went well 
            labelProcessText.Text = messageText;
        }
        private bool InputIsOk(double normalPrice, string weekday)
        {
            bool isValidInput = false;
            string np = normalPrice.ToString();
            if (!String.IsNullOrWhiteSpace(np) && !String.IsNullOrWhiteSpace(weekday))
            {
                if (normalPrice > 0  && weekday.Length > 5)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }
    }
}
