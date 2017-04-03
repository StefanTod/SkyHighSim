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

        DataHelper helper;
        public Form1()
        {
            InitializeComponent();
            helper = new DataHelper();
            airplanes = new List<Airplane>();
            airports = helper.GetAllAirports();
            
            flights = new List<Flight>();
            queues  = new List<Queue>();
            airNetwork = new Network(Regions.EUROPE, airplanes, airports, flights, queues);
            painter = new Painter();
            //Airport arp1 = new Airport("Schiphol",100,p,2,arp1.landingQueue,arp1.takingOffQueue,arp1.problems,arp1.listOfFlights);
            airNetwork.AddAirport("Germany", 100, new Point(480,390), 2);
            airNetwork.AddAirport("Bulgaria", 100, new Point(675,500), 4);
            airNetwork.AddAirport("Ukraine", 100, new Point(780,380), 2);
            airNetwork.AddAirport("Iceland", 100, new Point(270,540), 3);
            airNetwork.AddAirport("Spain", 100, new Point(250,150), 1);


            airNetwork.AddFlight("1", airNetwork.FindAirport("Germany"), airNetwork.FindAirport("Bulgaria"), TimeSpan.Zero, DateTime.Now, DateTime.Now);
            airNetwork.AddFlight("2", airNetwork.FindAirport("Iceland"), airNetwork.FindAirport("Spain"), TimeSpan.Zero, DateTime.Now, DateTime.Now);
            airNetwork.AddFlight("3", airNetwork.FindAirport("Ukraine"), airNetwork.FindAirport("Iceland"), TimeSpan.Zero, DateTime.Now, DateTime.Now);
            airNetwork.AddFlight("4", airNetwork.FindAirport("Bulgaria"), airNetwork.FindAirport("Spain"), TimeSpan.Zero, DateTime.Now, DateTime.Now);

            foreach (Airport a in airports)
            {
                airNetwork.AddAirport(a.Name,a.Capacity,a.Location,a.Lanes);
            }
            airNetwork.AddAirport("Schiphol", 100, new Point(480,390), 2);
            airNetwork.AddAirport("Test", 100, new Point(770,520), 4);
            airNetwork.AddFlight("1", airNetwork.FindAirport("Schiphol"), airNetwork.FindAirport("Test"), TimeSpan.Zero, DateTime.Now, DateTime.Now);
            airNetwork.AddAirplane("00", 1, 1, 1);
            airNetwork.AddAirplane("01", 1, 1, 1);
            airNetwork.AddAirplane("02", 1, 1, 1);
            airNetwork.AddAirplane("03", 1, 1, 1);

            airNetwork.FindAirplane("00").AddFlight(airNetwork.FindFlight("1"));
            airNetwork.FindAirplane("01").AddFlight(airNetwork.FindFlight("2"));
            airNetwork.FindAirplane("02").AddFlight(airNetwork.FindFlight("3"));
            airNetwork.FindAirplane("03").AddFlight(airNetwork.FindFlight("4"));
            gr = this.panelDrawing.CreateGraphics();
            Invalidate();
        }
        

        private void StartSimulation()
        {

            panelDrawing.Invalidate();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Airplane a in airNetwork.Airplanes)
            {
                a.Update();
            }
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
            painter.DrawNetwork(e.Graphics, airNetwork);
        }

        private void btFastForward_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
        }
    }
}


