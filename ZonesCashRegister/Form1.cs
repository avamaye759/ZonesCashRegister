using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace ZonesCashRegister
{
    public partial class Form1 : Form
    {
        //global variables
        int pupPrice = 0;
        int pupAmount = 0;
        int raygunPrice = 0;
        int raygunAmount = 0;
        int batPrice = 0;
        int batAmount = 0;
        int subtotal = 0;
        double taxrate = 0.1;
        int taxAmount = 0;
        int total = 0;
        int tendered = 0;
        int change = 0;
        
        public Form1()
        {
            InitializeComponent();
            //disabling buttons
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            newOrderButton.Enabled = false;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //calculating total before tax
            pupAmount = Convert.ToInt32(pupInput.Text);
            raygunAmount = Convert.ToInt32(raygunInput.Text);
            batAmount = Convert.ToInt32(batInput.Text);
            pupPrice = pupAmount * 15;
            raygunPrice = raygunAmount * 115;
            batPrice = batAmount * 25;
            subtotal = pupPrice + raygunPrice + batPrice;
            //calculating tax amount
            taxAmount = (int)(subtotal * taxrate);
            //calculating total with tax
            total = subtotal + taxAmount;
            //displaying results
            subtotalOutput.Text = $"{subtotal}";
            taxOutput.Text = $"{taxAmount}";
            totalOutput.Text = $"{total}";
            //enabling change calculation
            changeButton.Enabled = true;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //getting tendered amount
            tendered = Convert.ToInt32(tenderedInput.Text);
            //calculating change amount
            change = tendered - total;
            //displaying results
            changeOutput.Text = $"{change}";
            //enabling receipt printing
            receiptButton.Enabled = true;
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
