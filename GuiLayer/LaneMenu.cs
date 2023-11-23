using BowlingDesktopClient.ControlLayer;
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

namespace BowlingDesktopClient.GuiLayer
{
    public partial class LaneMenu : Form
    {
        readonly LaneControl _laneControl;
        CreateLaneMenu _clMenu = new CreateLaneMenu();

        public LaneMenu()
        {
            InitializeComponent();

            _laneControl = new LaneControl();
        }
        private async Task buttonGetLanes_Click(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Lane>? fethcedLanes = await _laneControl.GetAllLanes();
            if (fethcedLanes != null)
            {
                if (fethcedLanes.Count >= 1)
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
            labelProcessText.Text = processText;
            listBoxLanes.DataSource = fethcedLanes;
        }

        private async void buttonGetAllLanes_Click_1(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Lane>? fethcedLanes = await _laneControl.GetAllLanes();
            if (fethcedLanes != null)
            {
                if (fethcedLanes.Count >= 1)
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
            labelProcessText.Text = processText;
            listBoxLanes.DataSource = fethcedLanes;
        }

        private async void buttonGetLane_Click_1(object sender, EventArgs e)
        {
            listBoxLanes.DataSource = null;
            listBoxLanes.Items.Clear();
            string processText = "Good or Not";
            List<Lane> fetchedLane = new List<Lane> { };
            Lane? lane = await _laneControl.FindLaneById(int.Parse(textBoxFindBy.Text));
            if (lane.LaneNumber == null)
            {
                MessageBox.Show("Der eksistere ikke en bane med det ID");
            }
            else
            {
                fetchedLane.Add(lane);
                if (fetchedLane != null && lane.LaneNumber > 0)
                {
                    if (fetchedLane != null)
                    {
                        processText = "Ok";
                    }
                    else
                    {
                        processText = "No lanes found";
                    }
                }
                else
                {
                    processText = "Failure: An error occurred";
                }
                labelProcessText.Text = processText;
                listBoxLanes.DataSource = fetchedLane;
            }

        }

        private async void buttonUpdateLane_Click_1(object sender, EventArgs e)
        {
            int laneId = int.Parse(textBoxFindByID.Text);

            // Find the lane by its ID
            Lane? laneToUpdate = await _laneControl.FindLaneById(laneId);

            if (laneToUpdate != null)
            {
                // Update the lane number
                laneToUpdate.LaneNumber = int.Parse(textBoxNewLaneNumber.Text);

                // Update the lane
                bool isUpdated = await _laneControl.UpdateLane(laneId, laneToUpdate); // Pass ID parameter

                if (isUpdated)
                {
                    // Lane was successfully updated
                    MessageBox.Show("Bane opdateret.");
                    List<Lane> fetchedLane = new List<Lane> { };
                    laneToUpdate.Id = laneId;
                    fetchedLane.Add(laneToUpdate);
                    listBoxLanes.DataSource = fetchedLane;
                }
                else
                {
                    // Failed to update lane
                    MessageBox.Show("Fejl ved opdatering.");
                }
            }
            else
            {
                // Lane with the specified ID was not found
                MessageBox.Show("Bane ikke fundet.");
            }
        }

        private async void buttonDeleteLane_Click_1(object sender, EventArgs e)
        {
            int laneId = int.Parse(textBoxLaneToDelete.Text);

            // Delete the lane
            bool isDeleted = await _laneControl.DeleteLane(laneId);

            if (isDeleted)
            {
                // Lane was successfully deleted
                MessageBox.Show("Bane Slettet");
            }
            else
            {
                // Failed to delete lane
                MessageBox.Show("Fejl ved sletning.");
            }
        }

        private void buttonCreateLane_Click_1(object sender, EventArgs e)
        {
            _clMenu.ShowDialog();
        }
    }
}
