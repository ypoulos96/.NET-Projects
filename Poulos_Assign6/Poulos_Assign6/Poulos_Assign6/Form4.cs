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
    public partial class Graph3 : Form
    {
        public Graph3()
        {
            InitializeComponent();
        }

        private void Graph3_Load(object sender, EventArgs e)
        {
            string line;            

            //Read data from file
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

                    //Add data to chart
                    this.Precipitation.Series["Chicago"].Points.AddXY(month, chicagoPrecip);
                    this.Precipitation.Series["Sahara Desert"].Points.AddXY(month, saharaPrecip);
                    this.Precipitation.Series["Amazon Rainforest"].Points.AddXY(month, amazonPrecip);
                    
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
