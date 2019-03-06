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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poulos_Assign6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Show form containing the first graph
        private void graph1Button_Click(object sender, EventArgs e)
        {
            Graph1 graph = new Graph1();

            this.Hide();         //Hide main form
            graph.ShowDialog();  //Open new form            
        }

        //Show form containing the second graph
        private void graph2Button_Click(object sender, EventArgs e)
        {
            Graph2 graph = new Graph2();

            this.Hide();         //Hide main form
            graph.ShowDialog();  //Open new form


        }

        //Show form containg the third graph
        private void graph3Button_Click(object sender, EventArgs e)
        {
            Graph3 graph = new Graph3();

            this.Hide();         //Hide main form
            graph.ShowDialog();  //Open new form
        }

        //Show form containing the fourth graph
        private void graph4Button_Click(object sender, EventArgs e)
        {
            Graph4 graph = new Graph4();

            this.Hide();         //Hide main form
            graph.ShowDialog();  //Open new form
        }
    }
}
