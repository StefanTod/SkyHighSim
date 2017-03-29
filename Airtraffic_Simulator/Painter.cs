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
        private Graphics Graphics { get; set; }

        public Painter(Graphics gr)
        {
            this.Graphics = gr;
        }
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
        public void DrawAirplane(Airplane airplaneToDraw)
        {
            if(airplaneToDraw.status != Status.LANDED)
            {
                Graphics.DrawImage(airplaneToDraw.Image, airplaneToDraw.CurrentLocation);
            }
        }
        public void DrawAirport(Airport airportToDraw)
        {
            Graphics.DrawImage(airportToDraw.Image, airportToDraw.Location);
        }
        public void DrawFlightPath(Flight flightToDraw)
        {
            
        }
    }
}
