//Michaela Condari, 2021-04-01, 11:40 am
//purpose: ask a user to enter how many Christmas gifts they are planning to purchase this year.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare variables
            int gifts;
            int price;
            int total = 0;

            //ask number of gifts
            gifts = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Enter how many gifts did you buy","Enter a number"));

            // display that info
            lblOut.Text += "you purchased " + gifts + " gifts" + "\n";

            //for loop structure

            for (int i= 1; i != gifts + 1; i++)
            {
                price = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox(" What is the price of your gift?","Enter a price"));

                total = total + price;

                lblOut.Text += "The price of gift " + i + " is $" + price + "\n";
            }
            
            lblOut.Text += "The total price of the gifts is $" + total;
        }
    }
}
