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
        private Queue landingQueue;
        private Queue takingOffQueue;
        private List<Problem> problems;
        private List<Flight> listOfFlights;
<<<<<<< HEAD
        //TODO add access to list
=======
        public Airport(string name, int cap, Point location, int lanes, Queue landingQueue,Queue takingOffQueue,
            List<Problem> problem,List<Flight> listOfFlights)
        {
            this.name = name;
            this.capacity = cap;
            this.location = location;
            this.lanes = lanes;
            this.landingQueue= new Queue();
            this.takingOffQueue=new Queue();
            this.problems= new List<Problem>();
            this.listOfFlights= new List<Flight>();
        }
>>>>>>> master
        
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
