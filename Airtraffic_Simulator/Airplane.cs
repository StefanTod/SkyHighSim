using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    class Airplane
    {
        private string id;
        private int capacity;
        private double speed;
        private double fuel;
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

        }
        public void UpdateMovement()
        {

        }
        public Airplane(string id,int capacity,double speed, double fuel)
        {
            this.capacity=capacity;
            this.speed=speed;
            this.fuel=fuel;
        }
    }
}
