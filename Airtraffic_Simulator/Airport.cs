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

        public readonly int Lanes;
        public int LanesTaken { get;  private set; }
        public int Capacity { get; private set; }

        public Rectangle CoverArea { get; set; }

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
            this.CoverArea = new Rectangle(Convert.ToInt32(Location.X), Convert.ToInt32(Location.Y), 25, 25);

        }


        /// <summary>
        /// For each tick of the counter the problems need to be updated since they have a duration.
        /// If their duration has expired they must be removed from the list.
        /// </summary>
        public void UpdateTimeOfProblems()
        {
            for (int i = 0; i < Problems.Count;i++ )
            {
                if(Problems[i].StartingTime.Add(Problems[i].Duration).CompareTo(GlobalVariables.globalTime)<1)
                {
                    Problems.RemoveAt(i);
                    i--;
                    if (Problems.Count == 0)
                    {
                        this.Image = new Bitmap(Airtraffic_Simulator.Properties.Resources.airportТerminal);
                        this.Image = new Bitmap(Image, 25, 25);
                        ChangeIcon(Image);
                    }
                }
            }
        }

        public void ChangeIcon(Bitmap newicon)
        {
            this.Image = newicon;
        }

        public bool RequestLandingPermission(Airplane a)
        {
            if(LanesTaken<Lanes)
            {
                LanesTaken++;
                //set status to landing --> free lane
                return true;
            }
            else
            {
                LandingQueue.AddPlaneToQueue(a);
                //plane has to circle until it is removed from the queue.
                return false;
            }
        }

        public void RemoveFromQueue()
        {
            Airplane airplaneToLand = LandingQueue.DequeueHighestPriority();
            if (airplaneToLand != null)
            {
                LanesTaken++;
                airplaneToLand.SetStatusToLanding();
            }
        }

        public void FreeLane()
        {
            LanesTaken--;
            RemoveFromQueue();
        }


        public void CreateProblem(string type, TimeSpan duration)
        {
            Problem problem = new Problem(type, duration,GlobalVariables.globalTime);
            Problems.Add(problem);

            this.Image = new Bitmap(Airtraffic_Simulator.Properties.Resources.airportТerminalRestricted);
            this.Image = new Bitmap(Image, 25, 25);
            ChangeIcon(Image);
        }
    }
}
