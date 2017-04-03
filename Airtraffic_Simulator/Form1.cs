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
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
            airplanes = new List<Airplane>();
            airports = new List<Airport>();
            flights = new List<Flight>();
            queues  = new List<Queue>();
            airNetwork = new Network(Regions.EUROPE, airplanes, airports, flights, queues);
            painter = new Painter();
            //Airport arp1 = new Airport("Schiphol",100,p,2,arp1.landingQueue,arp1.takingOffQueue,arp1.problems,arp1.listOfFlights);
            airNetwork.AddAirport("Schiphol", 100, new Point(480,390), 2);
            airNetwork.AddAirport("Test", 100, new Point(770,520), 4);
            airNetwork.AddFlight("1", airNetwork.FindAirport("Schiphol"), airNetwork.FindAirport("Test"), TimeSpan.Zero, DateTime.Now, DateTime.Now);
            airNetwork.AddAirplane("00", 1, 1, 1);
            airNetwork.FindAirplane("00").Flight = airNetwork.FindFlight("1");
            airNetwork.FindAirplane("00").CurrentLocation = new Point(480, 390);
            gr = this.panelDrawing.CreateGraphics();
        }
        

        private void StartSimulation()
        {
            
            foreach (Airport a in airNetwork.Airports)
            {
                painter.DrawAirport(gr,a);
            }
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {         
            panelDrawing.Invalidate();
            
            //call painter
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            painter.DrawNetwork(gr,airNetwork);
            timer.Interval = 500;
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

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            foreach (Airplane a in airNetwork.Airplanes)
            {
                a.Update();
            }
            painter.DrawNetwork(e.Graphics, airNetwork);
        }

        private void btFastForward_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
        }
    }
}


