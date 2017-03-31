using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airtraffic_Simulator
{
    public partial class Form1 : Form
    {
        List<Airplane> airplanes;
        List<Airport> airports;
        List<Flight> flights;
        List<Queue> queues;
        Network airNetwork;
        Painter painter;
        public Form1()
        {
            InitializeComponent();
            airplanes = new List<Airplane>();
            airports = new List<Airport>();
            flights = new List<Flight>();
            queues  = new List<Queue>();
            airNetwork = new Network(Regions.EUROPE, airplanes, airports, flights, queues);
            painter = new Painter();
        }
        

        private void StartSimulation()
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            foreach (Airplane a in airNetwork.Airplanes)
            {
                a.UpdateMovement();
                painter.DrawAirplane(a);
                panel2.Invalidate();
            }
            //call painter
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            painter.DrawNetwork(airNetwork);
            StartSimulation();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btAdvanced_Click(object sender, EventArgs e)
        {
            panelAdvanced.Visible = true;
            btUpdate.Visible = true;
        }
    }
}


