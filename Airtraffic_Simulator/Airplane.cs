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
        private string id;
        private int capacity;
        private double speed;
        private double fuel;
        public Status status = Status.LANDED;
        private int counterTicks = 0;
        private Flight flight;

        public Point CurrentLocation { get; set; }
        public Bitmap Image { get; set; }
        public string Id { get; private set; }
        public int Capacity { get; private set; }
        public double Speed { get; private set; }
        public double Fuel { get; private set; }

        public void Update()
        {
            switch (this.status)
            {
                case Status.LANDED:
                    //if check flight timing then we take off
                    // check if lanes are free
                    if(flight.DepartureAirport.LanesTaken < flight.DepartureAirport.Lanes) {
                        status = Status.TAKINGOFF;
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
                        status = Status.LANDED;
                        //add plane into destination airport
                    }
                    break;
                case Status.TAKINGOFF:
                    counterTicks++;
                    if (counterTicks >= 2)
                    {
                        status = Status.INAIR;
                        // remove plane from airport 
                        counterTicks = 0;
                        // release lane
                        
                    }
                    break;
            }
        }
        public void UpdateMovement()
        {
            int x1 = this.flight.DepartureAirport.Location.X;
            int x2 = this.flight.DestinationAirport.Location.X;
            int y1 = this.flight.DepartureAirport.Location.Y;
            int y2 = this.flight.DestinationAirport.Location.Y;

            int xCurrent = this.CurrentLocation.X;
            int yCurrent = this.CurrentLocation.Y;
            // calculations of movement
            double currentdistance = Math.Sqrt(Math.Pow(xCurrent - x1, 2) + Math.Pow(yCurrent - y1, 2));
            double distancepassed = (20 * 30 / 60); // Distance = speed * time  --> speed = 20px/hour time = 20 minutes 
            int A = (y1 - y2);
            int B = (x1 - x2);
            if(B!=0 && A!=0) // calculate new point based on distance passed and current location
            {
                double slope = A / B;
                double k = distancepassed / Math.Sqrt(1 + Math.Pow(slope, 2));
                int xNew = (int)Math.Round(xCurrent + k * 1);
                int yNew = (int)Math.Round(yCurrent + k * slope);
                this.CurrentLocation = new Point(xNew, yNew);
            }
            else if (A==0) //then y stays the same, add distance to x
            {
                int xNew = (int)Math.Round(distancepassed) + xCurrent;
                int yNew = yCurrent;
                this.CurrentLocation = new Point(xNew, yNew);
            }
            else //x stays the same, add distance to y
            {
                int xNew = xCurrent;
                int yNew = (int)Math.Round(distancepassed) + yCurrent;
                this.CurrentLocation = new Point(xNew, yNew);
            }

           
         }
        public Airplane(string id,int capacity,double speed, double fuel)
        {
            this.id = id;
            this.capacity=capacity;
            this.speed=speed;
            this.fuel=fuel;
        }
    }
}
