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
        Pen transperentPen = new Pen(Color.Transparent, 1);
        Pen redPen = new Pen(Color.Red, 1);
        
        public void DrawNetwork(Graphics gr, Network n)
        {
            foreach(Airplane a in n.Airplanes)
            {
                this.DrawAirplane(gr, a, false);
            }

            foreach (Airport a in n.Airports)
            {
                this.DrawAirport(gr, a);
            }
        }

        public void RedrawAirplanes(Graphics gr, Network n, Airplane selectedAirplane)
        {
            foreach (Airplane a in n.Airplanes)
            {
                bool selected = false;
                if (selectedAirplane != null)
                {
                    if (selectedAirplane.Id == a.Id)
                    {
                        selected = true;
                    }
                }
                this.DrawAirplane(gr, a, selected);
            }
        }

        public void DrawAirplane(Graphics gr, Airplane airplaneToDraw, bool isSelected)
        {
            //Pen penToDraw = new Pen(Color.Transparent, 1);
            if (airplaneToDraw.PlaneStatus != Status.LANDED)
            {
                if (isSelected)
                {
                    //penToDraw = new Pen(Color.Red, 1);
                    gr.DrawRectangle(redPen, airplaneToDraw.CoverArea);
                }
                gr.DrawRectangle(transperentPen, airplaneToDraw.CoverArea);
                gr.DrawImage(airplaneToDraw.Image, airplaneToDraw.CurrentLocation);
            }
        }


        public void DrawAirport(Graphics gr, Airport airportToDraw)
        {
            gr.DrawImage(airportToDraw.Image, new PointF(airportToDraw.Location.X - 7, airportToDraw.Location.Y - 7));
        }


        //public void DrawFlightPath(Graphics gr, Flight flightToDraw)
        //{
        //    //gr.DrawLine(Pens.Yellow, new PointF(flightToDraw.DepartureAirport.Location.X + 7,flightToDraw.DepartureAirport.Location.Y + 7), new PointF(flightToDraw.DestinationAirport.Location.X + 7,flightToDraw.DestinationAirport.Location.Y+7));
        //}
    }
}
