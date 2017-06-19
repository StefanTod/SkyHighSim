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
        Pen greenPen = new Pen(Color.Green, 2);
        //Pen penToDraw = new Pen(Color.Transparent, 1);
        
        public void DrawNetwork(Graphics gr, Network n)
        {
            foreach(Airplane a in n.Airplanes)
            {
                this.DrawAirplane(gr, a, false);
            }

            foreach (Airport a in n.Airports)
            {
                this.DrawAirport(gr, a, false);
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

        public void RedrawAirports(Graphics gr, Network n, Airport selectedAirport)
        {
            foreach (Airport a in n.Airports)
            {
                bool selected = false;
                if (selectedAirport != null)
                {
                    if (selectedAirport.Name == a.Name)
                    {
                        selected = true;
                    }
                }
                this.DrawAirport(gr, a, selected);
            }
        }

        public void DrawAirplane(Graphics gr, Airplane airplaneToDraw, bool isSelected)
        {
            
            Pen penToDraw = transperentPen;
            if (airplaneToDraw.PlaneStatus != Status.LANDED)
            {
                if (isSelected)
                {
                    
                    penToDraw = greenPen;
                }
                gr.DrawRectangle(penToDraw, airplaneToDraw.CoverArea);
                gr.DrawImage(airplaneToDraw.Image, airplaneToDraw.CurrentLocation);
            }
        }


        public void DrawAirport(Graphics gr, Airport airportToDraw, bool isSelected)
        {
            Pen penToDraw = transperentPen;
            if (isSelected)
            {
                 penToDraw = greenPen;
            }

            gr.DrawRectangle(penToDraw, airportToDraw.CoverArea);
            //gr.DrawImage(airportToDraw.Image, new PointF(airportToDraw.Location.X - 7, airportToDraw.Location.Y - 7));
            gr.DrawImage(airportToDraw.Image, airportToDraw.Location);
        }


        //public void DrawFlightPath(Graphics gr, Flight flightToDraw)
        //{
        //    //gr.DrawLine(Pens.Yellow, new PointF(flightToDraw.DepartureAirport.Location.X + 7,flightToDraw.DepartureAirport.Location.Y + 7), new PointF(flightToDraw.DestinationAirport.Location.X + 7,flightToDraw.DestinationAirport.Location.Y+7));
        //}
    }
}
