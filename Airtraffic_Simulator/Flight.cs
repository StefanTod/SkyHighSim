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
        public TimeSpan EstimatedDuration { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime ArrivalTime { get; private set; }
        public string Id { get; private set; }
        public Airport DepartureAirport { get; private set; }
        public Airport DestinationAirport { get; private set; }

        public Flight(String id, Airport departureAirport, Airport destinationAirport,
            TimeSpan estimatedDuration, DateTime departureTime, DateTime arrivalTime)
        {
            this.Id = id;
            this.DepartureAirport = departureAirport;
            this.DestinationAirport = destinationAirport;
            this.EstimatedDuration = estimatedDuration;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
        }
    }
}
