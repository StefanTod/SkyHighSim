using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
   public class Flight
    {
        private String id;
        private Airport departudeAirport;
        private Airport destinationAirport;
        private TimeSpan estimatedDuration;
        private DateTime departureTime;
        private DateTime arrivalTime;

        public Airport DepartureAirport { get; set; }
        public Airport DestinationAirport { get; set; }

       public Flight(String Id, Airport DepartureAirport, Airport DestinationAirport,
           TimeSpan EstimatedDuration, DateTime DepartureTime, DateTime ArrivalTime)
       {
           this.id = Id;
           this.departudeAirport = DepartureAirport;
           this.departudeAirport = DestinationAirport;
           this.estimatedDuration = EstimatedDuration;
           this.departureTime = DepartureTime;
           this.arrivalTime = ArrivalTime;
       }
    }
}
