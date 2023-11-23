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
    public partial class CreateCustomerMenu : Form
    {
        readonly CustomerControl _customerControl;
        public CreateCustomerMenu()
        {
            InitializeComponent();
            _customerControl = new CustomerControl();
        }

        private async void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;
            // Values from textboxes must be fetched
            string inFirstName = textBoxFirstName.Text;
            string inLastName = textBoxLastName.Text;
            string inEmail = textBoxEmail.Text;
            string inPhone = textBoxPhone.Text;
            // Evaluate and act accordingly
            if (InputIsOk(inFirstName, inLastName, inEmail, inPhone))
            {
                // Call the ControlLayer to save the data
                insertedId = await _customerControl.SaveCustomer(inFirstName, inLastName, inEmail, inPhone);
                if (insertedId > 0)
                {
                    messageText = $"Kunden gemt med ID'et: {insertedId}";
                    MessageBox.Show(messageText);
                    // Perform any additional actions after successful save
                }
                else
                {
                    messageText = "En fejl er sket";
                    MessageBox.Show(messageText);
                    // Handle save failure
                }
            }
            else
            {
                messageText = "please indtast valid inforation";
                MessageBox.Show(messageText);
            }
        }
        //Checks if the input is okay.
        private bool InputIsOk(string fName, string lName, string email, string phone)
        {
            bool isValidInput = false;
            if (!String.IsNullOrWhiteSpace(fName) && !String.IsNullOrWhiteSpace(lName) && !String.IsNullOrWhiteSpace(email) && !String.IsNullOrWhiteSpace(phone))
            {
                if (fName.Length > 1 && lName.Length > 1 && email.Length > 2 && email.Contains('@') && phone.Length > 1)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }
    }
}
