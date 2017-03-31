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
        public string Id { get; }
        public int Capacity { get; }
        public double Speed { get; }
        public double Fuel { get; }

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
            // calculations of movement
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
