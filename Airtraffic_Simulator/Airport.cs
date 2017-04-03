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
        public PointF Location { get; private set; }
        public Queue LandingQueue { get; private set; }
        public Queue TakingOffQueue { get; private set; }
        public List<Problem> Problems { get; private set; }
        public List<Flight> listOfFlights { get; private set; }
        public Bitmap Image { get; private set; }
        public string Name { get; private set; }

        public int Lanes { get; private set; }
        public int LanesTaken { get;  private set; }
        public int Capacity { get; private set; }

        public Airport(string name, int cap, PointF location, int lanes)
        {
            this.Name = name;
            this.Capacity = cap;
            this.Location = location;
            this.Lanes = lanes;
            this.LandingQueue = new Queue(this);
            this.TakingOffQueue = new Queue(this);
            this.Problems = new List<Problem>();
            this.listOfFlights = new List<Flight>();
            this.Image = new Bitmap(Airtraffic_Simulator.Properties.Resources.airportТerminal);
            this.Image = new Bitmap(Image, 25, 25);
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
            Problem problem = new Problem(id, type, duration);
            Problems.Add(problem);
        }
    }
}
