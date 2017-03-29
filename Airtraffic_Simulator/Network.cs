using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public class Network
    {
        public Regions Region;

        public List<Airplane> Airplanes;
        public List<Airport> Airports;
        public List<Flight> Flights;

        public Network(Regions region, List<Airplane> airplanes, List<Airport> airports, List<Flight> flights, List<Queue> Queues)
        {
            this.Region = region;
            this.Airplanes = new List<Airplane>();
            this.Airports = new List<Airport>();
            this.Flights = new List<Flight>();
            this.Queues = new List<Queue>();
        }

        public bool AddFlight(Flight flight)
        {
            return false;
        }

        public bool RemoveFlight(Flight flight)
        {
            return false;
        }
        public bool CreateAirplane(Airplane airplane)
        {
            return false;
        }
        public bool RemoveAirplane(Airplane airplane)
        {
            return false;
        }
        public bool AddAirport(Airport airport)
        {
            return false;
        }
        public bool RemoveAirport(Airport airport)
        {
            return false;
        }
        public bool CreateProblem(string id, string type, TimeSpan duration)
        {
            return false;
        }

    }
}
