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
    public partial class Graph2 : Form
    {
        public Graph2()
        {
            InitializeComponent();
        }

        private void Graph2_Load(object sender, EventArgs e)
        {
            string line;

            //this.NapTime.Titles.Add("Age VS Nap");
            //this.NapTime.Titles.Add("Average Nap Times");           

            using (StreamReader inFile = new StreamReader(@"NapTimes.txt"))
            {
                line = inFile.ReadLine();

                while (line != null)
                {
                    List<string> stringList = line.Split(',').ToList();

                    string name = stringList[0];
                    uint age = uint.Parse(stringList[1]);
                    uint minutes = uint.Parse(stringList[2]);                   

                    this.NapTime.Series["Age"].Points.AddXY(name, age);
                    this.NapTime.Series["Nap (in Minutes)"].Points.AddXY(name, minutes);

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
