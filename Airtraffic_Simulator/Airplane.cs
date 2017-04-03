using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public class Airplane
    {
        public Status Status { get; private set; }
        public Flight Flight { get; set; }
        public Point CurrentLocation { get; set; }
        public Bitmap Image { get; set; }
        public string Id { get; private set; }
        public int Capacity { get; private set; }
        public double Speed { get; private set; }
        public double Fuel { get; private set; }
        private int counterTicks = 0;
        public Airplane(string id, int capacity, double speed, double fuel)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Speed = speed;
            this.Fuel = fuel;
            this.Image = new Bitmap(Airtraffic_Simulator.Properties.Resources.planeObjectIcon);
            this.Image = new Bitmap(Image, 25, 25);

        }
        public void Update()
        {
            switch (this.Status)
            {
                case Status.LANDED:
                    //if check flight timing then we take off
                    // check if lanes are free
                    if(Flight.DepartureAirport.LanesTaken < Flight.DepartureAirport.Lanes) {
                        Status = Status.TAKINGOFF;
                        break;
                    }
                    else {
                        //add to queue to take off
                       break;
                    }
                    
                case Status.INAIR:
                    UpdateMovement();
                    break;
                case Status.LANDING:
                    counterTicks++;
                    if (counterTicks >= 2)
                    {
                        Status = Status.LANDED;
                        //add plane into destination airport
                    }
                    break;
                case Status.TAKINGOFF:
                    counterTicks++;
                    if (counterTicks >= 2)
                    {
                        Status = Status.INAIR;
                        // remove plane from airport 
                        counterTicks = 0;
                        // release lane
                        
                    }
                    break;
            }
        }
        public void UpdateMovement()
        {
            int x1 = this.Flight.DepartureAirport.Location.X;
            int x2 = this.Flight.DestinationAirport.Location.X;
            int y1 = this.Flight.DepartureAirport.Location.Y;
            int y2 = this.Flight.DestinationAirport.Location.Y;

            int xCurrent = this.CurrentLocation.X;
            int yCurrent = this.CurrentLocation.Y;
            // calculations of movement
            double totaldistance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double currentdistance = Math.Sqrt(Math.Pow(xCurrent - x1, 2) + Math.Pow(yCurrent - y1, 2));
            double distancepassed = (20 * 30 / 60); // Distance = speed * time  --> speed = 20px/hour time = 30 minutes 
            double A = (y2 - y1);
            double B = (x2 - x1);

            int xNew;
            int yNew;
            if(B!=0 && A!=0) // calculate new point based on distance passed and current location
            {
                double slope = A / B;
                double k = distancepassed / Math.Sqrt(1 + Math.Pow(slope, 2));
                if(B<0)
                {
                    k = -k;
                }
                xNew = (int)Math.Round(xCurrent + k * 1);
                k = Math.Abs(k);
                if(A<0)
                {
                    k = -k;
                }
                yNew = (int)Math.Round(yCurrent + k * Math.Abs(slope));
            }
            else if (A==0) //then y stays the same, add distance/substract distance to x
            {
                if(B<0)
                {
                    distancepassed = -distancepassed;
                }
                xNew = (int)Math.Round(distancepassed) + xCurrent;
                yNew = yCurrent;
            }
            else //x stays the same, add distance/substract distance to y
            {
                if(A<0)
                {
                    distancepassed = -distancepassed;
                }
                xNew = xCurrent;
                yNew = (int)Math.Round(distancepassed) + yCurrent;
            }
            if(totaldistance < currentdistance + distancepassed)
            {
                xNew = this.Flight.DestinationAirport.Location.X;
                yNew = this.Flight.DestinationAirport.Location.Y;
                this.Status = Status.LANDING;
            }
            this.CurrentLocation = new Point(xNew, yNew);
           
         }
    }
}
