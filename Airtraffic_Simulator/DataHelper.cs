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

        public DataHelper()
        {
            String connectionInfo = "server=localhost;user id=root;password=;database=airnetwork;";
            connection = new MySqlConnection(connectionInfo);
        }

        public List<Airport> GetAllAirports()
        {
            String sql = "SELECT * FROM airport";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Airport> tempAirports = new List<Airport>();


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                Point location;
                int capacity, nrOfLanes;

                while (reader.Read())
                {
                    name = Convert.ToString(reader["Name"]);
                    capacity = Convert.ToInt32(reader["Capacity"]);
                    string[] s = reader["Location"].ToString().Split(',');
                    location = new Point(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]));
                    nrOfLanes = Convert.ToInt32(reader["NbOfLanes"]);

                    tempAirports.Add(new Airport(name, capacity, location, nrOfLanes));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("error while loading the airports");
            }
            finally
            {
                connection.Close();
            }
            return tempAirports;
        }
    }
}
