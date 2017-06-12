using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airtraffic_Simulator
{
    public partial class Form1 : Form
    {
        Network airNetwork;
        Painter painter;
        private Airplane selectedAirplane;
        private Airport selectedAirport;
        DataHelper helper;
        private int X, Y;

        public Form1(Regions region)
        {
            InitializeComponent();
            airNetwork = new Network(region);
            helper = new DataHelper(airNetwork);
            airNetwork.Airports = helper.GetAllAirports(); //consider sending the Airports of airNetwork as a parameter into GetAllAirports instead of assigning it as reference
            airNetwork.Airplanes = helper.GetAllAirplanes();
            airNetwork.Flights = helper.GetAllFlights();
            painter = new Painter();
            selectedAirplane = null;
            selectedAirport = null;
            this.panelDrawing.Paint -= panelDrawing_Paint;
            this.panelDrawing.Paint += new PaintEventHandler(DrawNetwork);
            this.Invalidate();
            this.panelDrawing.Paint += panelDrawing_Paint;
            autoCompleteAirport(cbSearch);
            if (region == Regions.AUSTRALIA)
            {
                this.panelDrawing.BackgroundImage = Properties.Resources.australia;
            }
        }
        private void DrawNetwork(object sender, PaintEventArgs e)
        {
            painter.DrawNetwork(e.Graphics, airNetwork);
        }

        private void StartSimulation()
        {
            panelDrawing.Invalidate();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Airplane a in airNetwork.Airplanes)
            {
                //if (a.Flight.DepartureTime.Equals(GlobalVariables.globalTime))
                //{
                a.Update();
                //}
            }
            panelDrawing.Invalidate();
            GlobalVariables.globalTime = GlobalVariables.globalTime.AddMinutes(30);
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            timer.Interval = 500;
            StartSimulation();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btAdvanced_Click(object sender, EventArgs e)
        {
            if (!tc_create.Visible) {

                if (!panelAdvanced.Visible)
                {
                    panelAdvanced.Visible = true;
                    btUpdate.Visible = true;
                    autoCompleteAirport(cbChangeDestination);
                }
                else
                {
                    panelAdvanced.Visible = false;
                    btUpdate.Visible = false;
                }
            }
            else
            {
                tc_create.Visible = false;
                panelAdvanced.Visible = true;
                btUpdate.Visible = true;
                autoCompleteAirport(cbChangeDestination);
            }
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            painter.RedrawAirports(e.Graphics, airNetwork, selectedAirport);
            painter.RedrawAirplanes(e.Graphics, airNetwork, selectedAirplane);
        }
        private void SelectAirplane(Point clickedLocation)
        {
            tc_create.Visible = false;
            panelAdvanced.Visible = true;
            btUpdate.Visible = true;
            this.selectedAirplane = airNetwork.GetAirplane(clickedLocation);
            if (selectedAirplane != null)
            {
                // Update the panels with airplane info
                UpdatePanel();
                panelDrawing.Invalidate();
            }
        }

        private void SelectAirport(Point clickedLocation)
        {
            btUpdate.Visible = false;
            lblDestination.Visible = false;
            lbOrigin.Visible = false;
            panelAdvanced.Visible = false;
            this.selectedAirport = airNetwork.GetAirport(clickedLocation);
            if (selectedAirport != null)
            {
                // Update the panels with airplane info
                UpdatePanel();
                panelDrawing.Invalidate();
            }
        }
        private void UpdatePanel()
        {
            if (selectedAirplane != null)
            {
                lbOrigin.Visible = true;
                lbOrigin.Text = selectedAirplane.Flight.DepartureAirport.Name.ToString();
                lblDestination.Text = selectedAirplane.Flight.DestinationAirport.Name.ToString();
                lbCapacity.Text = selectedAirplane.Capacity.ToString();
                lbFlightNumber.Text = selectedAirplane.Flight.Id.ToString();
                lbFuel.Text = selectedAirplane.Fuel.ToString();
               // lblDestination.Text = selectedAirplane.CurrentLocation.ToString();
                lbPlaneName.Text = selectedAirplane.Id.ToString();
                lbDepartureTime.Text = selectedAirplane.Flight.DepartureTime.ToString();
                lbArrivalTime.Text = selectedAirplane.Flight.ArrivalTime.ToString();
                cbChangeDestination.Text = selectedAirplane.Flight.DestinationAirport.Name.ToString();
                nUDChangeSpeed.Text = selectedAirplane.Speed.ToString();
                nUDChangeFuel.Text = selectedAirplane.Fuel.ToString();

                if (selectedAirplane is AirplanePassenger)
                {
                    lbCargoWeight.Text = "-";
                    lbCargoWeight.Visible = true;
                    lbNrOfPsngs.Text = ((FlightPassenger)selectedAirplane.Flight).nrOfPassengers.ToString();
                    lbNrOfPsngs.Visible = true;
                }
                else
                {
                    lbNrOfPsngs.Text = "-";
                    lbCargoWeight.Text = ((FlightCargo)selectedAirplane.Flight).cargoWeight.ToString();
                    lbCargoWeight.Visible = true;
                }
            }

            if (selectedAirport != null)
            {
                lbPlaneName.Text = selectedAirport.Name.ToString();
                lbCapacity.Text = selectedAirport.Capacity.ToString();
                lbNrOfPsngs.Text = "-";
                lbCargoWeight.Text = "-";
                lbFlightNumber.Text = "-";
                lbFuel.Text = "-";
                lbDepartureTime.Text = "-";
                lbArrivalTime.Text = "-";
            }

            //Make all labels visible
            lbCapacity.Visible = true;
            lbFlightNumber.Visible = true;
            lbFuel.Visible = true;
            lbPlaneName.Visible = true;
            lbDepartureTime.Visible = true;
            lbArrivalTime.Visible = true;
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            tbLocation.Text = Convert.ToString("X: " + X + " " + "Y: " + Y);
            selectedAirplane = null;
            selectedAirport = null;
            string temp;
            if (airNetwork.GetAirplane(e.Location) != null) {
                SelectAirplane(e.Location);
                temp = lbPlaneName.Text;
                foreach (Airplane a in airNetwork.Airplanes)
                {
                    if (a.Id == temp)
                    {
                        selectedAirplane = a;
                    }
                }
            }
            if (airNetwork.GetAirport(e.Location) != null)
            {
                SelectAirport(e.Location);
                temp = lbPlaneName.Text;

                foreach (Airport a in airNetwork.Airports)
                {
                    if (a.Name == temp)
                    {
                        selectedAirport = a;
                    }
                }
            }
            panelDrawing.Invalidate();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAirplane != null)
            {
                selectedAirplane.ChangeFuel(Convert.ToInt32(nUDChangeFuel.Value));
                selectedAirplane.ChangeSpeed(Convert.ToInt32(nUDChangeSpeed.Value));
                string destination = cbChangeDestination.Text;
                if (!destination.ToUpper().Equals(selectedAirplane.Flight.DestinationAirport.Name.ToUpper()))
                {
                    bool found = false;
                    foreach (Airport a in airNetwork.Airports)
                    {
                        if (a.Name.ToUpper() == destination.ToUpper())
                        {
                            selectedAirplane.ChangeRoute(selectedAirplane.CurrentLocation, a);
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show("No such airport was found. Please enter another one");
                    }
                }
            }
        }
        private void rb_passanger_CheckedChanged(object sender, EventArgs e)
        {
            nud_blk_amount.Visible = false;
            lb_blk_amount.Visible = false;
            cb_bulkCreate.Checked = false;
            lb_load.Visible = true;
            numericUpDown4.Visible = true;
            btn_create_plane.Visible = true;
            label_flight.Visible = true;
            lb_origin.Visible = true;
            lb_destination.Visible = true;
            cb_auto_orig.Visible = true;
            cb_auto_dest.Visible = true;
            cb_bulkCreate.Visible = true;
            lb_capacity.Visible = true;
            lb_speed.Visible = true;
            lb_fuel.Visible = true;
            nud_capacity.Visible = true;
            nud_fuel.Visible = true;
            nud_speed.Visible = true;


            autoCompleteAirport(cb_auto_orig);
            autoCompleteAirport(cb_auto_dest);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (nud_capacity.Value > 0 && nud_speed.Value > 0)
            {
                label_flight.Visible = true;
                lb_origin.Visible = true;
                lb_destination.Visible = true;
                cb_auto_orig.Visible = true;
                cb_auto_dest.Visible = true;

            }
        }

        private void cb_bulkCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_bulkCreate.Checked)
            {
                lb_blk_amount.Visible = true;
                nud_blk_amount.Visible = true;
            }
            else
            {
                nud_blk_amount.Visible = false;
                lb_blk_amount.Visible = false;
            }
        }

        bool created;
        private void btn_create_plane_Click(object sender, EventArgs e)
        {
            created = false;
            //Time Helpers
            TimeSpan estimatedDuration = new TimeSpan(02, 25, 00);
            DateTime currentTime = DateTime.Now;

            //Airplane properties
            int capacity = Convert.ToInt32(nud_capacity.Value);
            double speed = Convert.ToDouble(nud_speed.Value);
            double fuel = Convert.ToDouble(nud_fuel.Value);

            //Find the next ID for the plane
            int id_plane = airNetwork.nextAvailableAirplaneId();

            //Flight properties
            string origin_countryName = cb_auto_orig.Text;
            string destination_countryName = cb_auto_dest.Text;
            int loaded = Convert.ToInt32(numericUpDown4.Value);

            //Find the next ID for the flight
            int id_flight = airNetwork.nextAvailableFlightId();

            //Initializing Airport and Airplane objects to be passed
            Airport origin_airport = null;
            Airport destination_airport = null;
            Airplane airplane = null;
            Flight flight = null;

            //Bulk properties
            int bulkAmount = Convert.ToInt32(nud_blk_amount.Value);
            origin_airport = returnAirportObject(origin_countryName);
            destination_airport = returnAirportObject(destination_countryName);

            if (origin_airport != null && destination_airport != null)
            {
                //Check if it should be a bulk create
                if (cb_bulkCreate.Checked)
                {
                    if (speed > 0 && fuel > 0)
                    {
                        for (int i = 0; i < bulkAmount; i++)
                        {
                            id_flight++;
                            id_plane++;
                            if (capacity > loaded)
                            {
                                if (speed > 0 && fuel > 0)
                                {
                                    if (rb_cargo.Checked)
                                    {
                                        // Adding a cargo Airplane and Flight
                                        //Creating the plane and flight                      
                                        flight = new FlightCargo(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration, loaded);
                                        airplane = new AirplaneCargo(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                                    }
                                    else if (rb_passanger.Checked)
                                    {
                                        //Adding a passanger Airplane and Flight
                                        //Creating the plane and flight                      
                                        flight = new FlightPassenger(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration, loaded);
                                        airplane = new AirplanePassenger(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                                    }

                                    if (flight != null && airplane != null)
                                    {
                                        created = true;
                                        //Adding the flight to the network
                                        airNetwork.Airplanes.Add(airplane);
                                        //Adding the plane to the flight
                                        airplane.AddFlight(flight);
                                    }
                                }
                                else //If speed is <=0
                                {
                                    MessageBox.Show("Please make sure both speed and fuel are more than 0");
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is more cargo on the plane than the capacity would allow!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please make sure both speed and fuel are more than 0");
                    }
                    if (created)
                    {
                        MessageBox.Show(bulkAmount + " airplanes from " + origin_countryName + " to " + destination_countryName + " were succesffully created!");
                        resetAllBoxes();
                        panelDrawing.Invalidate();
                    }
                }
                else //Proceed with a single airplane creation
                {
                    if (capacity > loaded)
                    {
                        if (speed > 0 && fuel > 0)
                        {
                            if (rb_cargo.Checked)
                            {
                                // Adding a cargo Airplane and Flight
                                //Creating the plane and flight                      
                                flight = new FlightCargo(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration, loaded);
                                airplane = new AirplaneCargo(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                            }
                            else if (rb_passanger.Checked)
                            {
                                //Adding a passanger Airplane and Flight
                                //Creating the plane and flight                      
                                flight = new FlightPassenger(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration, loaded);
                                airplane = new AirplanePassenger(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                            }

                            if (flight != null && airplane != null)
                            {
                                created = true;
                                //Adding the flight to the network
                                airNetwork.Airplanes.Add(airplane);
                                //Adding the plane to the flight
                                airplane.AddFlight(flight);
                            }
                        }
                        else //If speed is <=0
                        {
                            MessageBox.Show("Please make sure both speed and fuel are more than 0");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is more cargo on the plane than the capacity would allow!");
                    }
                    if (created)
                    {
                        MessageBox.Show("Airplane from " + origin_countryName + " to " + destination_countryName + " was succesffully created!");
                        resetAllBoxes();
                        panelDrawing.Invalidate();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select both origin and destination airports");
            }
            autoCompleteAirport(cb_auto_orig);
            autoCompleteAirport(cb_auto_dest);
        }
        private void resetAllBoxes()
        {
            nud_capacity.Value = 0;
            nud_speed.Value = 0;
            nud_fuel.Value = 0;
            numericUpDown4.Value = 0;
            cb_auto_orig.ResetText();
            cb_auto_dest.ResetText();

            tbAirportName.ResetText();
            numUpDownAirportCapacity.Value = 0;
            numUpDownNrOfLanes.Value = 0;
            tbLocation.Text = "CLick on the map";
        }

        private void autoCompleteAirport(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (Airport a in airNetwork.Airports)
            {
                comboBox.AutoCompleteCustomSource.Add(a.Name);
                comboBox.Items.Add(a.Name);
            }
        }

        private void cb_auto_dest_TextChanged_1(object sender, EventArgs e)
        {
            lb_load.Visible = true;
            numericUpDown4.Visible = true;
            btn_create_plane.Visible = true;
            autoCompleteAirport(cb_auto_orig);
            string airport = cb_auto_dest.Text;
            cb_auto_orig.Items.Remove(airport);
        }

        private void cb_auto_orig_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoCompleteAirport(cb_auto_dest);
            string airport = cb_auto_orig.Text;
            cb_auto_dest.Items.Remove(airport);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Airport tempairport = null;
            lbBack2.Visible = true;
            string airname = cbSearch.Text;
            foreach (Airport a in airNetwork.Airports)
            {
                if (a.Name == airname)
                {
                    tempairport = a;
                }
            }
            if(tempairport!=null)
            { 
            if (cbFrom.Checked)
            {
                foreach (Airplane a in airNetwork.Airplanes)
                {
                    foreach (Flight f in airNetwork.Flights)
                    {
                        if (f.DepartureAirport.Name == airname)
                        {
                            if (a.Flight == f)
                            {
                                f.DepartureAirport.ChangeIcon(GlobalVariables.selectedAirport);
                                a.ChangeIcon(GlobalVariables.selectedAirplane);
                            }
                        }
                    }
                }
            }
            if (cbTo.Checked)
            {
                foreach (Flight f in airNetwork.Flights)
                {
                    if (f.DestinationAirport.Name == airname)
                    {
                        foreach (Airplane a in airNetwork.Airplanes)
                        {
                            if (a.Flight == f)
                            {
                                f.DestinationAirport.ChangeIcon(GlobalVariables.selectedAirport);
                                a.ChangeIcon(GlobalVariables.selectedAirplane);
                            }
                        }
                    }
                }
            }
            if (cbTo.Checked && cbFrom.Checked && tempairport != null)
            {
                tempairport.ChangeIcon(GlobalVariables.selectedAirport);
                foreach (Airplane a in airNetwork.Airplanes)
                {
                    foreach (Flight f in airNetwork.Flights)
                    {
                        if (f.DepartureAirport.Name == airname || f.DestinationAirport.Name == airname)
                        {
                            if (a.Flight == f)
                            {
                                a.ChangeIcon(GlobalVariables.selectedAirplane);

                            }

                        }
                    }
                }
            }
        
            if(!cbTo.Checked && !cbFrom.Checked && tempairport!=null)
            {
                tempairport.ChangeIcon(GlobalVariables.selectedAirport);
            }
            panelDrawing.Invalidate();
            searchBtn.Visible = false;
            cbSearch.Visible = false;
            lblSearch.Text = airname;
            }
            else
            {
                MessageBox.Show("No such airport");
            }
        }
        private void airplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelAdvanced.Visible)
            {
                panelAdvanced.Visible = false;
                tc_create.Visible = true;
                autoCompleteAirport(cb_problem_airport);
            }
            else
            {
                tc_create.Visible = true;
                tc_create.SelectedTab = tabPage1;
            }
        }

        private void airportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelAdvanced.Visible)
            {
                panelAdvanced.Visible = false;
                tc_create.Visible = true;

            }
            else
            {
                tc_create.Visible = true;
                tc_create.SelectedTab = tabPage2;
            }
        }

        private void problemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelAdvanced.Visible)
            {
                panelAdvanced.Visible = false;
                tc_create.Visible = true;

            }
            else
            {
                tc_create.Visible = true;
                tc_create.SelectedTab = tabPage3;
            }
        }
        private void btn_problem_create_Click(object sender, EventArgs e)
        {
            //Problem properties
            string target_airport = cb_problem_airport.Text;
            string problem_type = tb_problem_desc.Text;
            TimeSpan problem_duration = new TimeSpan(Convert.ToInt16(nud_prob_day.Value), Convert.ToInt16(nud_prob_hour.Value), Convert.ToInt16(nud_prob_min.Value),0);
            Airport target_airport_object = returnAirportObject(target_airport);
            //Problem object
            airNetwork.AddProblem(target_airport_object,problem_type, problem_duration);

            //Assign and create problem
        }

        private Airport returnAirportObject(string airport_Name)
        {
            //Search Airport from airport list
            foreach (Airport a in airNetwork.Airports)
            {
                if (airport_Name == a.Name)
                {
                    return a;
                }
            }
            return null;
        }

        private void rb_cargo_CheckedChanged(object sender, EventArgs e)
        {
            nud_blk_amount.Visible = false;
            lb_blk_amount.Visible = false;
            cb_bulkCreate.Checked = false;
            lb_load.Visible = true;
            numericUpDown4.Visible = true;
            btn_create_plane.Visible = true;
            label_flight.Visible = true;
            lb_origin.Visible = true;
            lb_destination.Visible = true;
            cb_auto_orig.Visible = true;
            cb_auto_dest.Visible = true;
            cb_bulkCreate.Visible = true;
            lb_capacity.Visible = true;
            lb_speed.Visible = true;
            lb_fuel.Visible = true;
            nud_capacity.Visible = true;
            nud_fuel.Visible = true;
            nud_speed.Visible = true;
            autoCompleteAirport(cb_auto_orig);
            autoCompleteAirport(cb_auto_dest);
        }

        private void defaultPicturePlanes()
        {
            foreach (Flight f in airNetwork.Flights)
            {
                if (f.DestinationAirport.Name == lblSearch.Text || f.DepartureAirport.Name == lblSearch.Text)
                {
                    foreach (Airplane a in airNetwork.Airplanes)
                    {
                        if (a.Flight == f)
                        {
                            if (a is AirplaneCargo)
                            {
                                a.ChangeIcon(GlobalVariables.AirplaneCargo);
                            }
                            if (a is AirplanePassenger)
                            {
                                a.ChangeIcon(GlobalVariables.AirplanePassenger);
                            }
                        }
                    }
                }
            }
            panelDrawing.Invalidate();
        }

        private void lbBack2_Click(object sender, EventArgs e)
        {
            cbSearch.Text = "Airport Name";
            lbBack2.Visible = false;
            foreach(Airport a in airNetwork.Airports)
            {
                if(a.Name == lblSearch.Text)
                {
                    a.ChangeIcon(GlobalVariables.airport);
                }
            }
            defaultPicturePlanes();
            searchBtn.Visible = true;
            cbSearch.Visible = true;
            lblSearch.ResetText();
        }

        private void cbTo_CheckedChanged(object sender, EventArgs e)
        {
            defaultPicturePlanes();
            if (cbTo.Checked)
            {
                foreach (Flight f in airNetwork.Flights)
                {

                    if (f.DestinationAirport.Name == lblSearch.Text)
                    {
                        foreach (Airplane a in airNetwork.Airplanes)
                        {
                            if (a.Flight == f)
                            {
                                a.ChangeIcon(GlobalVariables.selectedAirplane);
                            }
                        }
                    }
                }
                panelDrawing.Invalidate();
            }
            if (cbFrom.Checked)
            {
                foreach (Airplane a in airNetwork.Airplanes)
                {
                    foreach (Flight f in airNetwork.Flights)
                    {
                        if (f.DepartureAirport.Name == lblSearch.Text)
                        {
                            if (a.Flight == f)
                            {
                                a.ChangeIcon(GlobalVariables.selectedAirplane);
                            }
                        }
                    }
                }
                panelDrawing.Invalidate();
            }
        }

        private void cbFrom_CheckedChanged(object sender, EventArgs e)
        {
            defaultPicturePlanes();
            if (cbFrom.Checked)
            {
                foreach (Airplane a in airNetwork.Airplanes)
                {
                    foreach (Flight f in airNetwork.Flights)
                    {
                        if (f.DepartureAirport.Name == lblSearch.Text)
                        {
                            if (a.Flight == f)
                            {
                                a.ChangeIcon(GlobalVariables.selectedAirplane);
                            }
                        }
                    }
                }
                panelDrawing.Invalidate();
            }
            if (cbTo.Checked)
            {
                foreach (Flight f in airNetwork.Flights)
                {

                    if (f.DestinationAirport.Name == lblSearch.Text)
                    {
                        foreach (Airplane a in airNetwork.Airplanes)
                        {
                            if (a.Flight == f)
                            {
                                a.ChangeIcon(GlobalVariables.selectedAirplane);
                            }
                        }
                    }
                }
                panelDrawing.Invalidate();
            }

        }

        bool airportCreated;

        private void btCreateAirport_Click(object sender, EventArgs e)
        {
            airportCreated = false;

            //Airport properties
            string airportName = tbAirportName.Text;
            int airportCapacity = Convert.ToInt32(numUpDownAirportCapacity.Value);
            int numberOfLanes = Convert.ToInt32(numUpDownNrOfLanes.Value);
           
            PointF location = new PointF(X,Y);

            //initializing Airport object to be passed
            Airport airportToBeCreated = null;

              if (airportName != "" && airportCapacity > 0 && numberOfLanes > 0 && X != 0 && Y != 0)
              {
                  airportToBeCreated = new Airport(airportName, airportCapacity, location, numberOfLanes);
                  airportCreated = true;
                  airNetwork.Airports.Add(airportToBeCreated);
              }

              else
              {
                  MessageBox.Show("Please make sure that all the fields are filled in.");
              }

              if (airportCreated)
              {
                  MessageBox.Show("Airport " + airportName + " was succesfully created!");
                  resetAllBoxes();
                  panelDrawing.Invalidate();
              }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int v = trackBar1.Maximum - trackBar1.Value;
            timer.Interval = v + 1;
        }
    }
}


