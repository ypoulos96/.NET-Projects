using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDLogo
{
    public partial class Form1 : Form
    {
        Image dvd = Image.FromFile("dvd_logo.jpg");
        Random r = new Random();

        private Color[] clrArr = { Color.Yellow, Color.Blue, Color.DeepPink, Color.Purple, Color.Orange };
        private int x;
        private int y;
        private int xspeed = 5;
        private int yspeed = 5;

        public Form1()
        {
            InitializeComponent();
            
            // Start image coordinates at random location
            x = r.Next(0, this.Width - dvd.Width);
            y = r.Next(0, this.Height - dvd.Height);           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
            g.DrawImage(dvd, x, y, 130, 90);    // Draw the image onto the form       
        }

        private void update_Tick(object sender, EventArgs e)
        {            
            // Move the image location every clock tick
            x += xspeed;
            y += yspeed;

            // If a side of the image hits an edge of the form            
            if (x <= 0 || x + 145 >= this.Width)
            {
                int i = r.Next(0, clrArr.Length);

                xspeed *= -1;   // reverse the direction of the x-axis
                this.BackColor = clrArr[i];     // Set background to random color
            }

            // If the top or bottom of the image hits the top or bottom of the form
            if (y <= 0 || y + 125 >= this.Height)
            {
                int i = r.Next(0, clrArr.Length);

                yspeed *= -1;   // Reverse the direction of the y-axis
                this.BackColor = clrArr[i];     // Set background to random color
            }

            Invalidate();   // Update the frame
        }
    }
}
