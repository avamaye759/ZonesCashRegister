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
using System.Threading;
using System.Media;

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
        //soundplayers
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.clicksound);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.printsound);
        
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
            try
            {
                //button sound
                player1.Play();
                //getting amounts
                pupAmount = Convert.ToInt32(pupInput.Text);
                raygunAmount = Convert.ToInt32(raygunInput.Text);
                batAmount = Convert.ToInt32(batInput.Text);

                //calculating prices
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

                //check if values are all zero
                if (pupAmount == 0 && batAmount == 0 && raygunAmount == 0)
                {
                    totalButton.Text = "You gotta buy something!!";
                    totalButton.ForeColor = Color.Red;
                    changeButton.Enabled = false;
                    subtotalOutput.Text = "";
                    taxOutput.Text = "";
                    totalOutput.Text = "";
                    Refresh();
                    Thread.Sleep(1500);
                    totalButton.Text = "Calculate Total";
                    totalButton.ForeColor = Color.Black;
                }
            }
            catch
            {
                //display error message and reset
                totalButton.Text = "Invalid Entry";
                totalButton.ForeColor = Color.Red;
                pupInput.Text = "";
                raygunInput.Text = "";
                batInput.Text = "";
                Refresh();
                Thread.Sleep(1000);
                totalButton.Text = "Calculate Total";
                totalButton.ForeColor = Color.Black;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //button sound
                player1.Play();

                //getting tendered amount
                tendered = Convert.ToInt32(tenderedInput.Text);

                //calculating change amount
                change = tendered - total;

                //displaying results
                changeOutput.Text = $"{change}";

                //enabling receipt printing
                receiptButton.Enabled = true;

               //check if tendered amount is larger than total
                if (tendered < total)
                {
                    //error message and reset
                    changeButton.Text = "Please enter a larger amount";
                    changeButton.ForeColor = Color.Red;
                    tenderedInput.Text = "";
                    changeOutput.Text = "";
                    receiptButton.Enabled = false;
                    Refresh();
                    Thread.Sleep(1500);
                    changeButton.Text = "Calculate Change";
                    changeButton.ForeColor = Color.Black;
                }
            }
            catch
            {
                //display error message and reset
                changeButton.Text = "Invalid Entry";
                changeButton.ForeColor = Color.Red;
                tenderedInput.Text = "";
                changeOutput.Text = "";
                Refresh();
                Thread.Sleep(1000);
                changeButton.Text = "Calculate Change";
                changeButton.ForeColor = Color.Black;
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //receipt printing sound
            player2.Play();

            //disabling other buttons to prevent errors
            totalButton.Enabled = false;
            changeButton.Enabled = false;
            receiptButton.Enabled = false;

            //disabling inputs to prevent errors/keep it neat and tidy
            pupInput.Enabled = false;
            raygunInput.Enabled = false;
            batInput.Enabled = false;
            tenderedInput.Enabled = false;
            
            //printing receipt
                receiptLabel.Text = $"\n\n       Tommy Chow Mein Supplies Inc.";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n\n   Order Number 1523";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n   July 23, 2019";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n\n   Power Pup               x {pupAmount = Convert.ToInt32(pupInput.Text)} - {pupPrice} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n   Ray Gun                 x {raygunAmount = Convert.ToInt32(raygunInput.Text)} - {raygunPrice} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n   ElectroKat Batteries    x {batAmount = Convert.ToInt32(batInput.Text)} - {batPrice} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n\n   Subtotal                {subtotal} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n   Tax                     {taxAmount} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n   Total                   {total} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n\n   Tendered                {tendered} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n   Change                  {change} C";
                Refresh();
                Thread.Sleep(600);
                receiptLabel.Text += $"\n\n   Thank you for your patronage";
                Refresh();
                Thread.Sleep(300);

                //enabling new order button
                newOrderButton.Enabled = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //button sound
            player1.Play();

            //resetting variables
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

            //clearing outputs
            receiptLabel.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";

            //clearing inputs
            pupInput.Text = "";
            raygunInput.Text = "";
            batInput.Text = "";
            tenderedInput.Text = "";

            //disabling buttons
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            newOrderButton.Enabled = false;

            //re-enabling total button and inputs
            totalButton.Enabled = true;
            pupInput.Enabled = true;
            raygunInput.Enabled = true;
            batInput.Enabled = true;
            tenderedInput.Enabled = true;
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            //button sound
            player1.Play();

            //enabling/disabling image
            if (mapImage.Visible == false)
            {
                mapImage.Visible = true;
                adBox1.Visible = false;
                adBox2.Visible = false;
                adsBackLabel.Visible = false;
            }
            else
            {
                mapImage.Visible = false;   
            }
        }

        private void adsButton_Click(object sender, EventArgs e)
        {
            //button sound
            player1.Play();

            //enabling/disabling images
            if (adBox1.Visible == false && adBox2.Visible == false)
            {
                adBox1.Visible = true;
                adBox2.Visible = true;
                adsBackLabel.Visible = true;
                mapImage.Visible = false;
            }
            else
            {
                adBox1.Visible = false;
                adBox2.Visible = false;
                adsBackLabel.Visible = false;
            }
        }
    }
}
