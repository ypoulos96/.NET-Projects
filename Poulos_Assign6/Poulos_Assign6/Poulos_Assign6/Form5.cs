/***********************************************************
*  CSCI 473/504          Assignment 6          Fall 2018   *
*                                                          *
*  Programmer: Yiannis Poulos                              *
*              Shaniel Omar Rivas Verdejo                  *
*                                                          *
*  Section:    1                                           *
*                                                          *
*  Date Due:   11/29/2018                                  *
*                                                          *
*  Purpose:    This program different datasets represented * 
*              as different kinds of charts.               *
*                                                          *
***********************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Poulos_Assign6
{
    public partial class Graph4 : Form
    {
        public Graph4()
        {
            InitializeComponent();
        }

        private void Graph4_Load(object sender, EventArgs e)
        {
            string line;

            //Read data from text file
            using (StreamReader inFile = new StreamReader(@"Precipitation.txt"))
            {
                line = inFile.ReadLine();

                while (line != null)
                {
                    List<string> stringList = line.Split(',').ToList();

                    string month = stringList[0];
                    float chicagoPrecip = float.Parse(stringList[1]);
                    float saharaPrecip = float.Parse(stringList[2]);
                    float amazonPrecip = float.Parse(stringList[3]);
                    float size = float.Parse(stringList[4]);

                    //Add data to chart
                    this.chart1.Series["Chicago"].Points.AddXY(month, chicagoPrecip, size);
                    this.chart1.Series["Sahara Desert"].Points.AddXY(month, saharaPrecip, size);
                    this.chart1.Series["Amazon Rainforest"].Points.AddXY(month, amazonPrecip, size);

                    //Read next line
                    line = inFile.ReadLine();
                }
            }
        }

        //Close current window and show main form
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Close();
            form1.Show();
        }
    }
}
