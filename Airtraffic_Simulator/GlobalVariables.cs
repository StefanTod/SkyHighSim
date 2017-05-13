using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    //All images should be initialized here and classes should reference these objects.
    public static class GlobalVariables
    {
       public static Bitmap AirplaneInFlight = new Bitmap(Airtraffic_Simulator.Properties.Resources.airplane_flying,25,25);
    }
}
