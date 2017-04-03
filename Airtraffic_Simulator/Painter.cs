using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    class Painter
    {
       // private Graphics graphics { get; set; }
        
    
        //public Painter(Graphics gr)
        //{
        //   this.graphics = gr;
        //}
        public void DrawNetwork(Graphics gr,Network n)
        {
            foreach (Airplane a in n.Airplanes)
            {
                this.DrawAirplane(gr,a);
            }
            foreach(Airport a in n.Airports)
            {
                this.DrawAirport(gr,a);
            }
            foreach(Flight f in n.Flights)
            {
                this.DrawFlightPath(gr,f);
            }
        }

        public void RedrawAirplanes(Graphics gr,Network n)
        {
            foreach (Airplane a in n.Airplanes)
            {
                this.DrawAirplane(gr,a);
            }
        }
        public void DrawAirplane(Graphics gr,Airplane airplaneToDraw)
        {
            if(airplaneToDraw.Status != Status.LANDED)
            {
                gr.DrawImage(airplaneToDraw.Image, airplaneToDraw.CurrentLocation);
                //gr.DrawEllipse(Pens.Red, airplaneToDraw.CurrentLocation.X, airplaneToDraw.CurrentLocation.Y, 20, 20);
            }
        }
        public void DrawAirport(Graphics gr,Airport airportToDraw)
        {
            gr.DrawImage(airportToDraw.Image, new Point(airportToDraw.Location.X-7,airportToDraw.Location.Y-7));
        }
        public void DrawFlightPath(Graphics gr,Flight flightToDraw)
        {
            gr.DrawLine(Pens.Yellow, flightToDraw.DepartureAirport.Location, flightToDraw.DestinationAirport.Location);
        }
    }
}
