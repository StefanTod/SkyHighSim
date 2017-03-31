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
        public Point Location;
        private int lanes;
        private Queue landingQueue;
        private Queue takingOffQueue;
        private List<Problem> problems;
        private List<Flight> listOfFlights;
        public Bitmap Image;
        public string Name { get; set; }

        //TODO add access to list

        public Airport(string name, int cap, Point location, int lanes, Queue landingQueue,Queue takingOffQueue,
            List<Problem> problem,List<Flight> listOfFlights)
        {
            this.name = name;
            this.capacity = cap;
            this.Location = location;
            this.lanes = lanes;
        }

        
        public void AddToQueue(Airplane p)
        {
            
        }


        public bool RemoveFromQueue(Airplane p)
        {
            return true;
        }


        public void CreateProblem(int id, string type, TimeSpan duration)
        {
            Problem proble = new Problem(id, type, duration);
            problems.Add(proble);
        }
    }
}
