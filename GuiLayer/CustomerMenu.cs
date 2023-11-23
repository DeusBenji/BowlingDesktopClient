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
    public partial class CustomerMenu : Form
    {
        readonly CustomerControl _customerControl;
        CreateCustomerMenu _ccMenu = new CreateCustomerMenu();
        public CustomerMenu()
        {
            InitializeComponent();

            _customerControl = new CustomerControl();
        }

        private async void buttonGetCustomers_Click(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Customer>? fethcedCustomers = await _customerControl.GetAllCustomers();
            if (fethcedCustomers != null)
            {
                if (fethcedCustomers.Count >= 1)
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
            labelCustomerText.Text = processText;
            listBoxCustomers.DataSource = fethcedCustomers;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            _ccMenu.ShowDialog();
        }

        private async void buttonUpdateCustomer_Click_1(object sender, EventArgs e)
        {
            string inFirstName = textBoxFirstName.Text;
            string inLastName = textBoxLastName.Text;
            string inEmail = textBoxEmail.Text;
            string inPhone = textBoxPhone.Text;
            string findIdByPhone = textBoxFindIdByPhone.Text;

            if (!string.IsNullOrEmpty(findIdByPhone))
            {
                Customer? customerToUpdate = await _customerControl.FindCustomerByPhone(findIdByPhone);
                if (customerToUpdate != null)
                {
                    // Create a new customer object to hold the updated information
                    Customer newCustomerInfo = new Customer();

                    // Update the customer object properties based on the input fields
                    newCustomerInfo.Id = customerToUpdate.Id;

                    if (!string.IsNullOrEmpty(inFirstName))
                    {
                        newCustomerInfo.FirstName = inFirstName;
                    }
                    else
                    {
                        newCustomerInfo.FirstName = customerToUpdate.FirstName;
                    }

                    if (!string.IsNullOrEmpty(inLastName))
                    {
                        newCustomerInfo.LastName = inLastName;
                    }
                    else
                    {
                        newCustomerInfo.LastName = customerToUpdate.LastName;
                    }

                    if (!string.IsNullOrEmpty(inEmail))
                    {
                        newCustomerInfo.Email = inEmail;
                    }
                    else
                    {
                        newCustomerInfo.Email = customerToUpdate.Email;
                    }

                    if (!string.IsNullOrEmpty(inPhone))
                    {
                        newCustomerInfo.Phone = inPhone;
                    }
                    else
                    {
                        newCustomerInfo.Phone = customerToUpdate.Phone;
                    }

                    bool isUpdated = await _customerControl.UpdateCustomer(customerToUpdate.Id, newCustomerInfo);
                    if (isUpdated)
                    {
                        MessageBox.Show("Kunde information er blevet opdateret.");
                        // Perform any additional actions after successful update
                    }
                    else
                    {
                        MessageBox.Show("Fejl ved opdatering af kunden.");
                        // Handle update failure
                    }
                }
                else
                {
                    MessageBox.Show("Kunden blev ikke fundet.");
                    // Handle customer not found
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst et telefonnummer for at finde kunden.");
                // Handle missing phone number
            }

        }

        private async void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            string customerId = textBoxDeleteCustomer.Text;

            if (!string.IsNullOrEmpty(customerId))
            {
                bool isDeleted = await _customerControl.DeleteCustomer(int.Parse(customerId));
                if (isDeleted)
                {
                    MessageBox.Show("Kunden er blevet slettet.");
                    // Perform any additional actions after successful deletion
                }
                else
                {
                    MessageBox.Show("Fejl ved sletning af kunden.");
                    // Handle deletion failure
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst en gyldig kunde-ID.");
                // Handle missing or invalid customer ID
            }

        }

        private async void buttonFindCustomerByPhone_Click(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Customer> fetchedCustomer = new List<Customer> { };
            Customer cus = await _customerControl.FindCustomerByPhone(textBoxFindBy.Text);
            if (cus.Phone == null)
            {
                MessageBox.Show("Der eksistere ikke en bane med det ID");
            }
            else
            {
                fetchedCustomer.Add(cus);
                if (fetchedCustomer != null)
                {
                    if (fetchedCustomer != null)
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
                labelCustomerText.Text = processText;
                listBoxCustomers.DataSource = fetchedCustomer;
            }

        }
    }

}


