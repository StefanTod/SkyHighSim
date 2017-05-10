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

        public List<Airplane> Airplanes { get; set; }
        public List<Airport> Airports { get; set; }
        public List<Flight> Flights { get;  set; }
        public List<Queue> Queues { get; private set; }

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
            Flight flightToRemove = this.FindFlight(id);
            if (flightToRemove == null)
            {
                return false;
            }
            Flights.Remove(flightToRemove);
            return true;
        }
        public void AddPassengerAirplane(string id,int capacity, double speed, double fuel, PointF location,string type)
        {
                AirplanePassanger airplane = new AirplanePassanger(id, capacity, speed, fuel, location, type);
                Airplanes.Add(airplane);     
        }
        public void AddCargoAirplane(string id, int capacity, double speed, double fuel, PointF location, string type)
        {
            AirplaneCargo airplane = new AirplaneCargo(id, capacity, speed, fuel, location, type);
            Airplanes.Add(airplane);
        }
        public bool RemoveAirplane(string id)
        {
            Airplane airplaneToRemove = this.FindAirplane(id);
            if (airplaneToRemove == null)
            {
                return false;
            }
            Airplanes.Remove(airplaneToRemove);
            return true;
        }
        public void AddAirport(string name, int cap, PointF location, int lanes)
        {
            Airport airport = new Airport(name, cap, location, lanes);

            Airports.Add(airport);
        }
        public bool RemoveAirport(string name)
        {
            Airport airportToRemove = FindAirport(name);
            if (airportToRemove == null)
            {
                return false;
            }
            Airports.Remove(airportToRemove);
            return true;
        }
        public void AddProblem(Airport a, int id, string type, TimeSpan duration)
        {
            a.CreateProblem(id, type, duration);
        }

        public Flight FindFlight(string id)
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
        public Airplane FindAirplane(string id)
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
        public Airport FindAirport(string name)
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
        public Airplane GetAirplane(Point p)
        {
            foreach (Airplane c in Airplanes)
            {
                // 1 by 1 cause the method doesnt work with point
                if (c.CoverArea.IntersectsWith(new Rectangle(p.X, p.Y, 1, 1)))
                {
                    return c;
                }
                
            }
            return null;
        }

    }
}
