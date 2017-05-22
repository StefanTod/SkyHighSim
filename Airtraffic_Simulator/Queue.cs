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
            //Calculation logic
            return 5;
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
