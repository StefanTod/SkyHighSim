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
        private Graphics graphics { get; set; }
    
       // public Painter(Graphics gr)
       // {
         //   this.graphics = gr;
       // }
        public void DrawNetwork(Network n)
        {
            foreach (Airplane a in n.Airplanes)
            {
                this.DrawAirplane(a);
            }
            foreach(Airport a in n.Airports)
            {
                this.DrawAirport(a);
            }
            foreach(Flight f in n.Flights)
            {
                this.DrawFlightPath(f);
            }
        }

        public void RedrawAirplanes(Network n)
        {
            foreach (Airplane a in n.Airplanes)
            {
                this.DrawAirplane(a);
            }
        }
        public void DrawAirplane(Airplane airplaneToDraw)
        {
            if(airplaneToDraw.status != Status.LANDED)
            {
                graphics.DrawImage(airplaneToDraw.Image, airplaneToDraw.CurrentLocation);
            }
        }
        public void DrawAirport(Airport airportToDraw)
        {
            graphics.DrawImage(airportToDraw.Image, airportToDraw.Location);
        }
        public void DrawFlightPath(Flight flightToDraw)
        {
            graphics.DrawLine(Pens.Yellow, flightToDraw.DepartureAirport.Location, flightToDraw.DestinationAirport.Location);
        }
    }
}
