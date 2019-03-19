/***********************************************
* Programmer: Yiannis Poulos                   *
*                                              *
* Date: March 18, 2019                         *
*                                              *
* Purpose: A simple Tip Calculator application *
***********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        private int tipPercent;         // Percent of bill to be tipped

        private float billAmount;       // Original bill amount
        private float tipAmount;        // Amount to be tipped
        private float totalBillAmount;  // Total bill including tip
        private float splitAmount;      // Total amount per person

        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            tipPercent = tip_Slider.Value;      // Set tipPercent equal to initial value of slider
            tipPercent_Label.Text = tipPercent.ToString() + "%";  // Set text of tip percentage label
            tip_Slider_Scroll(sender, e);
        }

        // Calculate and display total values
        private void CalculateValues()
        {
            billAmount = (float)billAmount_UpDown.Value;
            tipAmount = (billAmount * tipPercent) / 100;
            totalBillAmount = billAmount + tipAmount;
            splitAmount = totalBillAmount / (float)split_UpDown.Value;

            // Display final calculations
            totalTipAmount_Label.Text = String.Format("{0:C2}", tipAmount);
            totalBillAmount_Label.Text = String.Format("{0:C2}", totalBillAmount);
            splitAmount_Label.Text = String.Format("{0:C2}", splitAmount);
        }

        private void billAmount_UpDown_ValueChanged(object sender, EventArgs e)
        {            
            // Recalculate total values when Bill Amount is changed
            CalculateValues();
        }

        private void split_UpDown_ValueChanged(object sender, EventArgs e)
        {
            // Recalculate total values when Split value is changed
            CalculateValues();
        }

        private void tip_Slider_Scroll(object sender, EventArgs e)
        {
            tipPercent = tip_Slider.Value;
            tipPercent_Label.Text = tipPercent.ToString() + "%";

            // Determine color of Tip Percent text
            if (tipPercent >= 20)
                tipPercent_Label.ForeColor = Color.LimeGreen;

            else if (tipPercent >= 18)
                tipPercent_Label.ForeColor = Color.GreenYellow;

            else if (tipPercent >= 15 && tip_Slider.Value < 18)
                tipPercent_Label.ForeColor = Color.Yellow;

            else if (tipPercent > 10 && tip_Slider.Value < 15)
                tipPercent_Label.ForeColor = Color.Orange;

            else
                tipPercent_Label.ForeColor = Color.Red;

            // Recalculate total values when slider is moved
            CalculateValues();
        }        
    }
}