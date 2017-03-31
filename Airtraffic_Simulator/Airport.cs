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
        private int lanesTaken;
        public Queue landingQueue;
        public Queue takingOffQueue;
        public List<Problem> problems;
        public List<Flight> listOfFlights;
        public Bitmap Image;
        public string Name { get; set; }

        //TODO add access to list

        public int Lanes { get; }
        public int LanesTaken { get; set; }
        public int Capacity { get; set; }
        public string Name { get; }

        public Airport(string name, int cap, Point location, int lanes, Queue landingQueue,Queue takingOffQueue,
            List<Problem> problem,List<Flight> listOfFlights)
        {
            this.name = name;
            this.capacity = cap;
            this.Location = location;
            this.lanes = lanes;
            landingQueue = new Queue();
            takingOffQueue = new Queue();
            problem = new List<Problem>();
            listOfFlights = new List<Flight>();
            this.Image = new Bitmap ("../../Resources/airport_terminal.png");
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
