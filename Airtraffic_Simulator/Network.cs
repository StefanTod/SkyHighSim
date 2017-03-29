using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    class Network
    {
        public Regions Region;

        private List<Airplane> Airplanes;
        private List<Airport> Airports;
        private List<Flight> Flights;

        public Network(Regions region)
        {
            this.Region = region;
            this.Airplanes = new List<Airplane>();
            this.Airports = new List<Airport>();
            this.Flights = new List<Flight>();
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
