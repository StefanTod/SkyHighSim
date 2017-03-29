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
        List<Airplane> airplanes = new List<Airplane>();
        List<Airport> airports = new List<Airport>();
        List<Flight> flights = new List<Flight>();
        List<Queue> queues = new List<Queue>();
        Network airNetwork;
        public Form1()
        {
            InitializeComponent();
            airNetwork = new Network(Regions.EUROPE,airplanes,airports,flights,queues);
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
            }
            //call painter
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            StartSimulation();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}


