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
        private int tipPercent;

        private float billAmount;
        private float tipAmount;
        private float totalBillAmount;
        private float splitAmount;

        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            tipPercent = tip_Slider.Value;
            tipValue_Label.Text = tipPercent.ToString() + "%";
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
            // Calculate total values when bill amount is changed
            CalculateValues();
        }

        private void split_UpDown_ValueChanged(object sender, EventArgs e)
        {
            // Calculate total values when Split value is changed
            CalculateValues();
        }

        private void tip_Slider_Scroll(object sender, EventArgs e)
        {
            tipPercent = tip_Slider.Value;
            tipValue_Label.Text = tipPercent.ToString() + "%";

            // Determine color of Tip Value text
            if (tipPercent >= 20)
                tipValue_Label.ForeColor = Color.LimeGreen;

            else if (tipPercent >= 18)
                tipValue_Label.ForeColor = Color.GreenYellow;

            else if (tipPercent >= 15 && tip_Slider.Value < 18)
                tipValue_Label.ForeColor = Color.Yellow;

            else if (tipPercent > 10 && tip_Slider.Value < 15)
                tipValue_Label.ForeColor = Color.Orange;

            else
                tipValue_Label.ForeColor = Color.Red;

            // Calculate total values when slider is moved
            CalculateValues();
        }        
    }
}