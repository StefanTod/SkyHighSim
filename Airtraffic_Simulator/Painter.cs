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
            //foreach(Flight f in n.Flights)
            //{
            //    this.DrawFlightPath(gr,f);
            //}
           
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
            Pen transperentPen = new Pen(Color.Transparent, 1);
            Pen redPen = new Pen(Color.Red, 1);
            if (airplaneToDraw.Status != Status.LANDED && airplaneToDraw.Status != Status.LANDED)
            {
                if (airplaneToDraw.Selected) //Checks if thats the selected airplane
                {
                    gr.DrawRectangle(redPen, airplaneToDraw.CoverArea); //Outlines the cover area with red
                }
                else 
               {
                   gr.DrawRectangle(transperentPen, airplaneToDraw.CoverArea);//Makes the outline transperent again
                }
                gr.DrawImage(airplaneToDraw.Image, airplaneToDraw.CurrentLocation); 
                
                //gr.DrawEllipse(Pens.Red, airplaneToDraw.CurrentLocation.X, airplaneToDraw.CurrentLocation.Y, 20, 20);
            }
            
        }
        public void DrawAirport(Graphics gr,Airport airportToDraw)
        {
            gr.DrawImage(airportToDraw.Image, new PointF(airportToDraw.Location.X-7,airportToDraw.Location.Y-7));
        }
        public void DrawFlightPath(Graphics gr,Flight flightToDraw)
        {
            //gr.DrawLine(Pens.Yellow, new PointF(flightToDraw.DepartureAirport.Location.X + 7,flightToDraw.DepartureAirport.Location.Y + 7), new PointF(flightToDraw.DestinationAirport.Location.X + 7,flightToDraw.DestinationAirport.Location.Y+7));
        }
    }
}
