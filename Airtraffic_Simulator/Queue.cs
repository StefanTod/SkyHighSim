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

        public Queue(Airport airport)
        {
            this.Airport = airport;
        }

        public void ProcessAirplane(Airplane airplane, Airport airport)
        {
           
        }
    }
}
