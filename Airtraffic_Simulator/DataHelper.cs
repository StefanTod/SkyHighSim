using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Airtraffic_Simulator
{
    public class DataHelper
    {
        public MySqlConnection connection;
        Network Network;

        public DataHelper(Network network)
        {
            String connectionInfo = "server=localhost;user id=root;password=;database=airnetwork;";
            connection = new MySqlConnection(connectionInfo);
            this.Network = network;
            
        }

        public List<Airport> GetAllAirports()
        {
           // String sql = "SELECT * FROM airport";
            //String sql = "SELECT * FROM `airport` WHERE Region_idRegion = " + this.Network.Region.ToString();
            String sql = "SELECT * FROM `airport` JOIN `region` ON (`airport`.Region_idRegion = `region`.idRegion) WHERE `region`.Name = '" + this.Network.Region.ToString() +  "';";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Airport> tempAirports = new List<Airport>();


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                PointF location;
                int capacity, nrOfLanes;

                while (reader.Read())
                {
                    name = Convert.ToString(reader["Name"]);
                    capacity = Convert.ToInt32(reader["Capacity"]);
                    string[] s = reader["Location"].ToString().Split(',');
                    location = new PointF((float)Convert.ToDouble(s[0]), (float)Convert.ToDouble(s[1]));
                    nrOfLanes = Convert.ToInt32(reader["NbOfLanes"]);

                    tempAirports.Add(new Airport(name, capacity, location, nrOfLanes));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading the airports");
            }
            finally
            {
                connection.Close();
            }
            return tempAirports;
        }


        public List<Airplane> GetAllAirplanes()
        {
           // String sql = "SELECT * FROM airplane";
            String sql = "SELECT airplane.idAirplane, airplane.Capacity, airplane.Speed, airplane.Fuel, airplane.Location, airplane.Type, region.Name FROM `airplane` JOIN flight ON (airplane.idAirplane = flight.Airplane_idAirplane) JOIN airport ON (flight.LandsTo = airport.IdAirport)" + "JOIN region ON (airport.Region_idRegion = region.idRegion) WHERE `region`.Name = '" + this.Network.Region.ToString() +  "';";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Airplane> tempAirplanes = new List<Airplane>();


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String  id;
                PointF location;
                double speed, fuel;
                int capacity;
                string type;
                
                while (reader.Read())
                {
                    id = Convert.ToString(reader["idAirplane"]);
                    capacity = Convert.ToInt32(reader["Capacity"]);
                    speed = Convert.ToDouble(reader["Speed"]);
                    fuel = Convert.ToDouble(reader["Fuel"]);
                    string[] s = Convert.ToString(reader["Location"]).Split(',');
                    location = new PointF((float)Convert.ToDouble(s[0]), (float)Convert.ToDouble(s[1]));
                    type = Convert.ToString(reader["Type"]);
                    if (type == "Cargo")
                    {
                        tempAirplanes.Add(new AirplaneCargo(id, capacity, speed, fuel, location));
                    }
                    else if (type == "Passenger")
                    {
                        tempAirplanes.Add(new AirplanePassenger(id, capacity, speed, fuel, location));
                    }
                    
                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading the airplanes");
            }
            finally
            {
                connection.Close();
            }
            return tempAirplanes;
        }

        public List<Flight>GetAllFlights()
        {
          
            //String sql = "SELECT `flight`.idFlight, `tf`.Name AS takingOff, `ar`.Name AS Arrival, `flight`.EstimatedDuration, `flight`.DepartureTime, `flight`.ArrivalTime, `airplane`.idAirplane, `airplane`.Type, `flight`.NbOfPassengers, `flight`.CargoWeight FROM `flight` JOIN `airplane` ON(`flight`.Airplane_idAirplane=`airplane`.idAirplane) JOIN `airport` AS tf ON(`flight`.takesOffFrom=`tf`.idAirport) JOIN `airport` AS ar ON(`flight`.LandsTo=`ar`.idAirport)";
            //String sql = "SELECT `flight`.idFlight, `tf`.Name AS takingOff, `ar`.Name AS Arrival, `flight`.EstimatedDuration, `flight`.DepartureTime, `flight`.ArrivalTime, `airplane`.idAirplane, `airplane`.Type, `flight`.`Loaded` FROM `flight` JOIN `airplane` ON(`flight`.Airplane_idAirplane=`airplane`.idAirplane) JOIN `airport` AS tf ON(`flight`.takesOffFrom=`tf`.idAirport) JOIN `airport` AS ar ON(`flight`.LandsTo=`ar`.idAirport)";
            String sql = "SELECT `flight`.idFlight, `tf`.Name AS takingOff, `ar`.Name AS Arrival, `flight`.EstimatedDuration, `flight`.DepartureTime, `flight`.ArrivalTime, `airplane`.idAirplane, `airplane`.Type, `flight`.`Loaded` FROM `flight` JOIN `airplane` ON(`flight`.Airplane_idAirplane=`airplane`.idAirplane) JOIN `airport` AS tf ON(`flight`.takesOffFrom=`tf`.idAirport) JOIN `airport` AS ar ON(`flight`.LandsTo=`ar`.idAirport) JOIN region ON (tf.Region_idRegion = region.idRegion) WHERE `region`.Name = '" + this.Network.Region.ToString() + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Flight> tempFlights = new List<Flight>();


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

     
                String id;
                Airport destination, takingOff;
                TimeSpan duration;
                DateTime departureTime, arrivalTime;
                Airplane airplane;
                string typeAirplane;
                int loaded;
                

                while (reader.Read())
                {
                    id = Convert.ToString(reader["idFlight"]);
                    takingOff = Network.FindAirport(Convert.ToString(reader["takingOff"]));
                    destination = Network.FindAirport(Convert.ToString(reader["Arrival"]));
                    string[] s = Convert.ToString(reader["EstimatedDuration"]).Split(' ');
                    s = s[1].Split(':');
                    string[] sx = s[2].Split('.');
                    duration = new TimeSpan(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(sx[0]));

                    string[] s1 = Convert.ToString(reader["DepartureTime"]).Split(' ');
                    string[] s1a = s1[0].Split('-');
                    string[] s1b = s1[1].Split(':');
                    departureTime = new DateTime(Convert.ToInt32(s1a[0]), Convert.ToInt32(s1a[1]), Convert.ToInt32(s1a[2]), Convert.ToInt32(s1b[0]), Convert.ToInt32(s1b[1]), Convert.ToInt32(s1b[2]));


                    string[] s2 = Convert.ToString(reader["ArrivalTime"]).Split(' ');
                    string[] s2a = s2[0].Split('-');
                    string[] s2b = s2[1].Split(':');

                    arrivalTime = new DateTime(Convert.ToInt32(s2a[0]), Convert.ToInt32(s2a[1]), Convert.ToInt32(s2a[2]), Convert.ToInt32(s2b[0]), Convert.ToInt32(s2b[1]), Convert.ToInt32(s2b[2]));

                    airplane = Network.FindAirplane(Convert.ToString(reader["idAirplane"]));
                    typeAirplane = Convert.ToString(reader["Type"]);
                    loaded = Convert.ToInt32(reader["Loaded"]);
                    

                    //Check whether the plane is a passenger or cargo plane and create a flight accordingly
                    if (typeAirplane == "Passenger")
                    {
                        FlightPassenger fp = new FlightPassenger(id, takingOff, destination, duration, departureTime, arrivalTime, loaded);
                        airplane.AddFlight(fp);
                        tempFlights.Add(fp);
                    }
                    else {
                        FlightCargo fc = new FlightCargo(id, takingOff, destination, duration, departureTime, arrivalTime, loaded);
                        airplane.AddFlight(fc);
                        tempFlights.Add(fc);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading the flights");
            }
            finally
            {
                connection.Close();
            }
            return tempFlights;

        }

    }
}
