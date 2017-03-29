using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Airtraffic_Simulator
{
    class Airport
    {
        private string name;
        private int capacity;
        private Point location;
        private int lanes;

        public Airport(string name, int cap, Point location, int lanes)
        {
            this.name = name;
            this.capacity = cap;
            this.location = location;
            this.lanes = lanes;
        }
        
        public bool AddToQueue(Airplane p)
        {
            return true;
        }

        public bool RemoveFromQueue(Airplane p)
        {
            return true;
        }

        public bool AddFlight(Flight f)
        {
            return true;
        }

        public bool CreateProblem(int id, string type, TimeSpan duration)
        {
            return true;
        }
    }
}
