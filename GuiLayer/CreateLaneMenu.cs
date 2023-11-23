using BowlingDesktopClient.ControlLayer;
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
    public partial class CreateLaneMenu : Form
    {
        readonly LaneControl _laneControl;
        public CreateLaneMenu()
        {
            InitializeComponent();
            _laneControl = new LaneControl();
        }

        private async void buttonSaveLane_Click(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;
            // Values from testboxes must be fetched
            int laneNumber = int.Parse(textBoxLaneNumber.Text);

            // Evaluate and act accordingly
            if (InputIsOk(laneNumber))
            {
                // Call the ControlLayer to get the data saved
                insertedId = await _laneControl.SaveLane(laneNumber);
                messageText = (insertedId > 0) ? $"Lane saved with no {insertedId}" : "Failure: An error occurred!";
            }
            else
            {
                messageText = "Please input valid informations";
            }
            // Finally put out a message saying if the saving went well 
            labelProcessText.Text = messageText;
        }
        private bool InputIsOk(int laneNumber)
        {
            string ln = laneNumber.ToString();
            bool isValidInput = false;
            if (!String.IsNullOrWhiteSpace(ln))
            {
                if (laneNumber > 0)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }
    }
}
