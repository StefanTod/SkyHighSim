using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
  public class FlightCargo:Flight
    {
      public int cargoWeight;
      public FlightCargo(String Id, Airport DepartureAirport, Airport DestinationAirport,
           TimeSpan EstimatedDuration, DateTime DepartureTime, DateTime ArrivalTime, int CargoWeight)
            :base(Id,DepartureAirport,DestinationAirport,EstimatedDuration,DepartureTime,ArrivalTime)
      {
          this.cargoWeight = CargoWeight;
      }
    }
}
