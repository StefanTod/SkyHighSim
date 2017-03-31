using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Airtraffic_Simulator
{
    public class Network
    {
        public Regions Region;

        public List<Airplane> Airplanes;
        public List<Airport> Airports;
        public List<Flight> Flights;
        public List<Queue> Queues;

        public Network(Regions region, List<Airplane> airplanes, List<Airport> airports, List<Flight> flights, List<Queue> Queues)
        {
            this.Region = region;
            this.Airplanes = new List<Airplane>();
            this.Airports = new List<Airport>();
            this.Flights = new List<Flight>();
            this.Queues = new List<Queue>();
        }

        public void AddFlight(String Id, Airport DepartureAirport, Airport DestinationAirport,
           TimeSpan EstimatedDuration, DateTime DepartureTime, DateTime ArrivalTime)
        {
            Flight f = new Flight(Id, DepartureAirport, DestinationAirport, EstimatedDuration, DepartureTime, ArrivalTime);
            Flights.Add(f);
        }


        public bool RemoveFlight(String id)
        {
           if (findFlight(id) == null)
            {
                return false;
            }
            Flights.Remove(findFlight(id));
            return true;
        }
        public void AddAirplane(string id,int capacity, double speed, double fuel)
        {
                Airplane airplane = new Airplane(id, capacity, speed, fuel);
                Airplanes.Add(airplane);     
        }
        public bool RemoveAirplane(string id)
        {
            if (findAirplane(id) == null)
            {
                return false;
            }
            Airplanes.Remove(findAirplane(id));
            return true;
        }
        public void AddAirport(string name, int cap, Point location, int lanes)
        {
            Airport airport = new Airport(name, cap, location, lanes);

            Airports.Add(airport);
        }
        public bool RemoveAirport(string name)
        {
            if (findAirport(name) == null)
            {
                return false;
            }
            Airports.Remove(findAirport(name));
            return true;
        }
        public void AddProblem(Airport a, int id, string type, TimeSpan duration)
        {
            a.CreateProblem(id, type, duration);
        }

        public Flight findFlight(string id)
        {
            foreach(Flight f in Flights)
            {
                if(f.Id==id)
                {
                    return f;
                }
            }
            return null;
        }
        public Airplane findAirplane(string id)
        {
            foreach (Airplane a in Airplanes)
            {
                if (a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }
        public Airport findAirport(string name)
        {
            foreach (Airport a in Airports)
            {
                if (a.Name == name)
                {
                    return a;
                }
            }
            return null;
        }

    }
}
