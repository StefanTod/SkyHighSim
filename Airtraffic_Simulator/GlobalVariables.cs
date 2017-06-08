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
        public static Bitmap AirplanePassenger = new Bitmap(Airtraffic_Simulator.Properties.Resources.airplane_flying,25,25);
        public static Bitmap AirplaneCargo = new Bitmap(Airtraffic_Simulator.Properties.Resources.airplane_cargo, 25, 25);
        public static Bitmap selectedAirport = new Bitmap(Airtraffic_Simulator.Properties.Resources.selectedAirrport, 25, 25);
        public static Bitmap airport = new Bitmap(Airtraffic_Simulator.Properties.Resources.airportТerminal, 25, 25);
        public static Bitmap selectedAirplane = new Bitmap(Airtraffic_Simulator.Properties.Resources.selectedplanes, 25, 25);
        public static DateTime globalTime = new DateTime(2017, 06, 8, 17, 0, 0);

    }
}
