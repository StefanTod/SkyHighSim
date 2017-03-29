using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
   public class FlightPassenger:Flight
    {
       private int nrOfPassengers;

       public FlightPassenger(String Id, Airport DepartureAirport, Airport DestinationAirport,
           TimeSpan EstimatedDuration, DateTime DepartureTime, DateTime ArrivalTime,int NrOfPassengers) 
           :base(Id,DepartureAirport,DestinationAirport,EstimatedDuration,DepartureTime,ArrivalTime)
                {
                     this.nrOfPassengers = NrOfPassengers;
                }
    }
}
