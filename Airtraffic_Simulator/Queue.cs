using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public class Queue
    {
        public Airport Airport { get; private set; }
        public PriorityQueue<int, Airplane> pQueue;
        public Queue(Airport airport)
        {
            this.Airport = airport;
            pQueue = new PriorityQueue<int, Airplane>(new MaxQueueComparer());
        }

        public void AddPlaneToQueue(Airplane airplane)
        {
            pQueue.Enqueue(this.CalculatePriority(airplane), airplane);
        }

        public void AddPlaneToQueueTest(int priority,Airplane airplane)
        {
            pQueue.Enqueue(priority, airplane);
        }
        public Airplane DequeueHighestPriority()
        {
            if(pQueue.Count>0)
            {
                return pQueue.DequeueValue();
            }
            else
            {
                return null;
            }
        }
        private int CalculatePriority(Airplane airplane)
        {
            int priority = 0;
            //Calculation logic
            /*  Priority list of points (Total points: 10)
             *  
             *  Max points for a passanger plane: 10
             *  Max points for a cargo plan: 8
             *  
             *  Is passanger plane - 2 points
             *  Low Fuel - max 3 points
             *  Passangers/Cargo - max 2 points 
             *  Travel time - max 1 point
             *  Is budget company - max 2 poitns
             * 
             */

            if(airplane is AirplanePassenger) { priority += 2; }
            if(airplane.Fuel < 10)
            {
                priority += 1;
                if(airplane.Fuel <= 5) { priority += 2; }
            }
            int filled = 0;
            if (airplane.Flight is FlightPassenger) {
                filled = ((FlightPassenger)airplane.Flight).nrOfPassengers;
            }
            else
            {
                filled = ((FlightCargo)airplane.Flight).cargoWeight;
            }
            double percentage = filled / airplane.Capacity * 100;
            if(percentage<30)
            {
                priority += 2;
            }

            return priority;
        }

        private class MaxQueueComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y - x;
            }
        }  
    }
}
