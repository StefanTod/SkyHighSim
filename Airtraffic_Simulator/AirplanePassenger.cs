using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public class AirplanePassenger : Airplane
    {
        public AirplanePassenger(string id, int capacity, double speed, double fuel, PointF currentLocation)
            : base(id, capacity, speed, fuel, currentLocation)
        {
        }
    }
}
