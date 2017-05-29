﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            airNetwork = new Network(Regions.EUROPE);
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
            panelAdvanced.Visible = true;
            btUpdate.Visible = true;
                foreach (Airport a in airNetwork.Airports)
                {
                    tbChangeDestination.AutoCompleteCustomSource.Add(a.Name);
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
            tbChangeDestination.Text = selectedAirplane.Flight.DestinationAirport.Name.ToString();
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
                string destination = tbChangeDestination.Text;
                bool found = false;
                foreach(Airport a in airNetwork.Airports)
                {
                    if(a.Name.ToUpper()==destination.ToUpper())
                    {
                        selectedAirplane.ChangeRoute(selectedAirplane.CurrentLocation, a.Location);
                        found = true;
                    }
                }
                if(!found)
                {
                    MessageBox.Show("No such airport was found. Please enter another one");
                }
            }
        }

       
    }
}


