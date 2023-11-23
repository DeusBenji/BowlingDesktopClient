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
    public partial class Main : Form
    {
        LaneMenu lMenu = new LaneMenu();
        BookingMenu bMenu = new BookingMenu();
        PriceMenu pMenu = new PriceMenu();
        CustomerMenu cMenu = new CustomerMenu();

        public Main()
        {
            InitializeComponent();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {   
           bMenu.ShowDialog();
        }

        private void buttonLane_Click(object sender, EventArgs e)
        {
            lMenu.ShowDialog();
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            pMenu.ShowDialog();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            cMenu.ShowDialog();
        }
    }
}
