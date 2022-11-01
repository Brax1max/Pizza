using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        //global variables  

        double slicePrice = 3.25;

        int numOfSlices = 0;
        double taxRate = 0.13;

        double subtotal = 0;

        double taxAmount = 0;

        double totalPrice = 0;
        int numOfDrink = 0;
        double Drinkprice = 1.50;



        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //get inputs
            numOfSlices = Convert.ToInt32(slicesInput.Text);
            numOfDrink = Convert.ToInt32(drinkInput.Text);

            //do calculations
            subtotal = slicePrice * numOfSlices + Drinkprice * numOfDrink;
            taxAmount = taxRate * subtotal;
            totalPrice = subtotal + taxAmount;
           


            //show outputs
            subtotalOutput.Text = $"{subtotal.ToString("C")}";
            taxOutput.Text = $"{taxAmount.ToString("C")}";
            totalOutput.Text = $"{totalPrice.ToString("C")}";
        }

        private void slicesLabel_Click(object sender, EventArgs e)
        {

        }

        private void DrinkLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Big Tony's pizza \n";
            label2.Text += $"slices ordered {numOfSlices}  @{slicePrice}\n\n";
            label2.Text += $"drink ordered {numOfDrink}    @{Drinkprice}\n\n\n";
            label2.Text += $" subtotal @{subtotal}\n\n\n\n";
            label2.Text += $"tax       @{taxAmount}\n\n\n\n\n";
            label2.Text += $" total    @{totalPrice}\n\n\n\n\n\n";


        }

        private void slicesInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
