using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int totalPrice;
        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(nameTextBox.Text);
            int numberOfTicket = Convert.ToInt32(ticketTextBox.Text);
            int unitPrice = 10;
             totalPrice = numberOfTicket * unitPrice;
            MessageBox.Show(name+  ", Please give "  +totalPrice.ToString()+   " taka for "  +numberOfTicket);
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name = "  +nameTextBox.Text+ "\n Number of Ticket = " +ticketTextBox.Text+ "\n Total price = "   +totalPrice.ToString());
        }
    }
}
