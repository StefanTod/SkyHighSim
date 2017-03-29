using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Airtraffic_Simulator
{
    public class Airport
    {
        private string name;
        private int capacity;
        private Point location;
        private int lanes;

        //TODO add access to list
        
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
