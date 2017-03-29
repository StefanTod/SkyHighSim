using System;
using System.Collections.Generic;
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
        private Status status = Status.LANDED;
        private int counterTicks = 0;
        private Flight flight;
        public string Id
        {
            get
            {
                return id;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public double Speed
        {
            get
            {
                return speed;
            }
        }
        public double Fuel
        {
            get
            {
                return fuel;
            }
        }
        public void Update()
        {
            switch (this.status)
            {
                case Status.LANDED:
                    //if check flight timing then we take off
                    // check if lanes are free
                    status = Status.TAKINGOFF;
                    break;
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
            this.capacity=capacity;
            this.speed=speed;
            this.fuel=fuel;
        }
    }
}
