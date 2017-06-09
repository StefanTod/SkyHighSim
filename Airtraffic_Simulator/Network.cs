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

        public Network(Regions region)
        {
            this.Region = region;
            this.Airplanes = new List<Airplane>();
            this.Airports = new List<Airport>();
            this.Flights = new List<Flight>();
            this.Queues = new List<Queue>();
        }

        public void AddFlight(Flight f)
        {
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

        public void AddAirplane(Airplane airplane)
        {
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
        public void AddProblem(Airport a,string type, TimeSpan duration)
        {
            a.CreateProblem(type, duration);
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

        public Airport GetAirport(Point p)
        {
            foreach (Airport a in Airports)
            {
                if (a.CoverArea.IntersectsWith(new Rectangle(p.X, p.Y, 1, 1)))
                {
                    return a;
                }
            }
            return null;
        }


        public int nextAvailableAirplaneId()
        {
            int id = 0;
            for (int i = 0; i < Airplanes.Count; i++)
            {
                if (Convert.ToInt32(Airplanes[i].Id) > id)
                {
                    id = Convert.ToInt32(Airplanes[i].Id);
                    id++;
                }
            }
            return id;
        }
        public int nextAvailableFlightId()
        {
            int id = 0;
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Convert.ToInt32(Flights[i].Id) > id)
                {
                    id = Convert.ToInt32(Flights[i].Id);
                    id++;
                }
            }
            return id;
        }
    }
}
