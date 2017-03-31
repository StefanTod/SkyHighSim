using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    //fligt class
   public class Flight
    {
        private Airport departureAirport;
        private string id;
        private Airport destinationAirport;
        private TimeSpan estimatedDuration;
        private DateTime departureTime;
        private DateTime arrivalTime;
        public string Id {get; set;}
        public Airport DepartureAirport { get; set; }
        public Airport DestinationAirport { get; set; }

       public Flight(String Id, Airport DepartureAirport, Airport DestinationAirport,
           TimeSpan EstimatedDuration, DateTime DepartureTime, DateTime ArrivalTime)
       {
           this.id = Id;
           this.departureAirport = DepartureAirport;
           this.destinationAirport = DestinationAirport;
           this.estimatedDuration = EstimatedDuration;
           this.departureTime = DepartureTime;
           this.arrivalTime = ArrivalTime;
       }
    }
}
