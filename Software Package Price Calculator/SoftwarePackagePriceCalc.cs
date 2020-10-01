/*AUTHOR: Kyle Huber
 *DATE: 09/28/2020
 *DESCRIPTION: A calculator which will take input from the user and output
 * the total price of purchased software based on a $99 constant retail price
 * and pre-determined discount rates per quantiy as specified in the textbook problem
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Package_Price_Calculator
{
    public partial class SoftwarePackagePriceCalc : Form
    {
        public SoftwarePackagePriceCalc()
        {
            InitializeComponent();
        }
        // Init field vars
        private const int RETAIL_PRICE = 99;
        private const double CONST20 = 0.2;
        private const double CONST30 = 0.3;
        private const double CONST40 = 0.4;
        private const double CONST50 = 0.5;
        private double total_purchase = 0;
        private double original_price = 0;
        private double current_discount = 0;
        private int num_of_packages = 0;
        private const int minimum = 9;

        private void calc_purchaseBtn_Click(object sender, EventArgs e)
        {
            //Init try/catch block
            try
            {
                num_of_packages = int.Parse(num_of_packagesTxtbox.Text);
                

                //Run a default switch case specifically for values under less than or equal to 9

                if (num_of_packages <= minimum)
                {
                    switch (num_of_packages)
                    {
                        default:
                            original_price_outputLbl.Visible = true;
                            total_calcValueLbl.Visible = true;
                            original_price = RETAIL_PRICE * num_of_packages;
                            original_price_outputLbl.Text = original_price.ToString("C");
                            total_purchase = num_of_packages * RETAIL_PRICE;
                            total_calcValueLbl.Text = "Your total purchase amount is " + total_purchase.ToString("C") +
                                " no discount has been applied to this order.";
                            break;
                    }
                }

               
            
                //Init some if-else-ifs
                else if (num_of_packages > minimum && num_of_packages <= 19)
                {
                    original_price_outputLbl.Visible = true;
                    total_calcValueLbl.Visible = true;
                    original_price = RETAIL_PRICE * num_of_packages;
                    original_price_outputLbl.Text = original_price.ToString("C");
                    total_purchase = (num_of_packages * RETAIL_PRICE) - num_of_packages * (RETAIL_PRICE * CONST20);
                    current_discount = num_of_packages * (RETAIL_PRICE * CONST20);
                    total_calcValueLbl.Text = "Your total purchase amount is " + total_purchase.ToString("C") +
                        " after an applied discount of 20%, which is a total savings of " + current_discount.ToString("C");

                }
               
                else if (num_of_packages >= 20 && num_of_packages <= 49)
                {
                    original_price_outputLbl.Visible = true;
                    total_calcValueLbl.Visible = true;
                    original_price = RETAIL_PRICE * num_of_packages;
                    original_price_outputLbl.Text = original_price.ToString("C");
                    total_purchase = (num_of_packages * RETAIL_PRICE) - num_of_packages * (RETAIL_PRICE * CONST30);
                    current_discount = num_of_packages * (RETAIL_PRICE * CONST30);
                    total_calcValueLbl.Text = "Your total purchase amount is " + total_purchase.ToString("C") +
                        " after an applied discount of 30%, which is a total savings of " + current_discount.ToString("C");

                }
                else if (num_of_packages >= 50 && num_of_packages <= 99)
                {
                    original_price_outputLbl.Visible = true;
                    original_price = RETAIL_PRICE * num_of_packages;
                    original_price_outputLbl.Text = original_price.ToString("C");
                    total_calcValueLbl.Visible = true;
                    total_purchase = (num_of_packages * RETAIL_PRICE) - num_of_packages * (RETAIL_PRICE * CONST40);
                    current_discount = num_of_packages * (RETAIL_PRICE * CONST40);
                    total_calcValueLbl.Text = "Your total purchase amount is " + total_purchase.ToString("C") +
                        " after an applied discount of 40%, which is a total savings of " + current_discount.ToString("C");

                }
                else if (num_of_packages >= 100)
                {
                    original_price_outputLbl.Visible = true;
                    original_price = RETAIL_PRICE * num_of_packages;
                    original_price_outputLbl.Text = original_price.ToString("C");
                    total_calcValueLbl.Visible = true;
                    total_purchase = (num_of_packages * RETAIL_PRICE) - num_of_packages * (RETAIL_PRICE * CONST50);
                    current_discount = num_of_packages * (RETAIL_PRICE * CONST50);
                    total_calcValueLbl.Text = "Your total purchase amount is " + total_purchase.ToString("C") +
                        " after an applied discount of 50%, which is a total savings of " + current_discount.ToString("C");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clear all and return focus to top
            num_of_packagesTxtbox.Text = "";
            original_price_outputLbl.Text = "";
            total_calcValueLbl.Text = "";
            num_of_packagesTxtbox.Focus();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //End program or ALT+X
            this.Close();
        }
    }
}

