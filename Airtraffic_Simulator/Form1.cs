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
        DataHelper helper;


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
            this.panelDrawing.Paint -=panelDrawing_Paint;
            this.panelDrawing.Paint += new PaintEventHandler(DrawNetwork);
            this.Invalidate();
            this.panelDrawing.Paint +=panelDrawing_Paint;

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
                a.Update();
            }
            panelDrawing.Invalidate();
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
            painter.RedrawAirplanes(e.Graphics, airNetwork, selectedAirplane);
        }

        private void btFastForward_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
        }
     
        private void SelectAirplane(Point clickedLocation)
        {
            this.selectedAirplane = airNetwork.GetAirplane(clickedLocation);
            if (selectedAirplane != null)
            {
                    // Update the panels with airplane info
                    UpdatePanel();
                    panelDrawing.Invalidate();
            }
        }
        private void UpdatePanel()
        {
            lbCapacity.Text=selectedAirplane.Capacity.ToString();
            lbFlightNumber.Text=selectedAirplane.Flight.Id.ToString();
            lbFuel.Text=selectedAirplane.Fuel.ToString();
            lbPlaneLocation.Text=selectedAirplane.CurrentLocation.ToString();
            lbPlaneName.Text=selectedAirplane.Id.ToString();
            lbDepartureTime.Text=selectedAirplane.Flight.DepartureTime.ToString();
            lbArrivalTime.Text=selectedAirplane.Flight.ArrivalTime.ToString();
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
            //Make all labels visible
            lbCapacity.Visible=true;
            lbFlightNumber.Visible = true;
            lbFuel.Visible = true;
            lbPlaneLocation.Visible = true;
            lbPlaneName.Visible = true;
            lbDepartureTime.Visible = true;
            lbArrivalTime.Visible=true;
            
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            SelectAirplane(e.Location);
            string temp = lbPlaneName.Text;

            foreach (Airplane a in airNetwork.Airplanes)
            {
                if (a.Id == temp)
                {
                    selectedAirplane = a;
                }
            }
               panelDrawing.Invalidate();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(selectedAirplane!=null)
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
                            selectedAirplane.ChangeRoute(selectedAirplane.CurrentLocation, a.Location);
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

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelAdvanced.Visible)
            {
                panelAdvanced.Visible = false;
                tc_create.Visible = true;
            }
            else
            {
                tc_create.Visible = true;
            }
        }

        private void rb_passanger_CheckedChanged(object sender, EventArgs e)
        {
            label_flight.Visible = false;
            lb_origin.Visible = false;
            lb_destination.Visible = false;
            cb_auto_orig.Visible = false;
            cb_auto_dest.Visible = false;
            nud_blk_amount.Visible = false;
            lb_blk_amount.Visible = false;
            lb_load.Visible = false;
            numericUpDown4.Visible = false;
            btn_create_plane.Visible = false;
            cb_bulkCreate.Checked = false;

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
            if(nud_capacity.Value > 0 && nud_speed.Value > 0)
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

        private void btn_create_plane_Click(object sender, EventArgs e)
        {
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

            //Find the next ID for the flight
            int id_flight = airNetwork.nextAvailableFlightId();

            //Initializing Airport and Airplane objects to be passed
            Airport origin_airport = null;
            Airport destination_airport = null;
            Airplane airplane = null;

            //Bulk properties
            int bulkAmount = Convert.ToInt32(nud_blk_amount.Value);

            //Search Airport from airport list
            foreach (Airport a in airNetwork.Airports)
            {
                if (origin_countryName == a.Name)
                {
                    origin_airport = a;
                }
                if (destination_countryName == a.Name)
                {
                    destination_airport = a;
                }
            }

            //Adding a passanger Airplane and Flight
            if (rb_passanger.Checked)
            {
                //Check if it should be a bulk create
                if (cb_bulkCreate.Checked)
                {
                    for (int i = 0; i < bulkAmount; i++)
                    {
                        id_flight++;
                        id_plane++;


                        //Creating the plane and flight                      
                        airNetwork.AddFlight(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration);
                        airNetwork.AddPassengerAirplane(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                        //Adding the plane to the flight
                        airplane = airNetwork.FindAirplane(id_plane.ToString());
                        airplane.AddFlight(airNetwork.FindFlight(id_flight.ToString()));
                    }
                    
                }
                else //Proceed with a single airplane creation
                {
                    //Creating the plane and flight                      
                    airNetwork.AddFlight(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration);
                    airNetwork.AddPassengerAirplane(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                    //Adding the plane to the flight
                    airplane = airNetwork.FindAirplane(id_plane.ToString());
                    airplane.AddFlight(airNetwork.FindFlight(id_flight.ToString()));
                }
            }
            else if (rb_cargo.Checked) // Adding a cargo Airplane and Flight
            {
                //Check if it should be a bulk create
                if (cb_bulkCreate.Checked)
                {
                    for (int i = 0; i < bulkAmount; i++)
                    {
                        id_flight++;
                        id_plane++;

                        //Creating the plane and flight  
                        airNetwork.AddFlight(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration);
                        airNetwork.AddCargoAirplane(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                        //Adding the plane to the flight
                        airplane = airNetwork.FindAirplane(id_plane.ToString());
                        airplane.AddFlight(airNetwork.FindFlight(id_flight.ToString()));
                    }

                }
                else  //Proceed with a single airplane creation
                {
                    //Creating the plane and flight  
                    airNetwork.AddFlight(id_flight.ToString(), origin_airport, destination_airport, estimatedDuration, currentTime, currentTime + estimatedDuration);
                    airNetwork.AddCargoAirplane(id_plane.ToString(), capacity, speed, fuel, origin_airport.Location);
                    //Adding the plane to the flight
                    airplane = airNetwork.FindAirplane(id_plane.ToString());
                    airplane.AddFlight(airNetwork.FindFlight(id_flight.ToString()));
                }
            }
        }   

        private void autoCompleteAirport(ComboBox comboBox)
        {
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
        }
    }
}


