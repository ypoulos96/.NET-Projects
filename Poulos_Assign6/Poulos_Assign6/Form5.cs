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

            using (StreamReader inFile = new StreamReader(@"StudentScores.txt"))
            {
                line = inFile.ReadLine();

                while (line != null)
                {
                    List<string> stringList = line.Split(',').ToList();

                    string studentName = stringList[0];
                    uint score = uint.Parse(stringList[1]);

                    this.Students.Series["Scores"].Points.AddXY(studentName, score);

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
