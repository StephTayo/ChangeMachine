using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // gives change using the smallest number of coins (assumes no penny coins)
        private void btnChange_Click(object sender, EventArgs e)
        {
            int nrTwoonies, nrLoonies, nrQuarters, nrDimes, nrNickels;

            double money; // input $ amount as double
            int cents; // money amount in cents
            
            // get  money in dollars and convert to cents
            money = Convert.ToDouble(txtMoney.Text);
            //cents = (int)(money * 100); // could lose one cent.Try 2.03
            cents = (int)Math.Round(money * 100);

            // round cents to the closest multiple of 5
            // do deal with the lack of one penny coins
            switch(cents %5 )
            {
                case 1:
                    cents -= 1;
                    break;
                case 2:
                    cents -= 2;
                    break;
                case 3:
                    cents += 2;
                    break;
                case 4:
                    cents += 1;
                    break;
            }
            lblCents.Text = cents.ToString();

            //give change
            nrTwoonies = cents / 200;
            cents = cents % 200;
            nrLoonies = cents / 100;
            cents = cents % 100;
            nrQuarters = cents / 25;
            cents = cents % 25;
            nrDimes = cents / 10;
            cents = cents % 10;
            nrNickels = cents / 5;

            // display results
            lblTwoonies.Text = nrTwoonies.ToString();
            lblLoonies.Text = nrLoonies.ToString();
            lblQuarters.Text = nrQuarters.ToString();
            lblDimes.Text = nrDimes.ToString();
            lblNickels.Text = nrNickels.ToString();
        }
    }
}
