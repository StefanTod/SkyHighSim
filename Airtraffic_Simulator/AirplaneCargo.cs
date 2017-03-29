using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public class AirplaneCargo : Airplane
    {
        public AirplaneCargo(string id, int capacity, double speed, double fuel) : base(id, capacity, speed, fuel)
        {
        }
    }
}
