using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public abstract class Airplane
    {
        public Status PlaneStatus { get; private set; }
        public Flight Flight { get; set; }
        public PointF CurrentLocation { get; set; }
        public Bitmap Image { get; set; }
        public string Id { get; private set; }
        public int Capacity { get; private set; }
        public double Speed { get; private set; }
        public double Fuel { get; private set; }
        public Rectangle CoverArea { get; set; }
        private PointF DepartureLocation;
        private PointF DestinationLocation;
        
        private int counterTicks = 0;
        public Airplane(string id, int capacity, double speed, double fuel, PointF currentLocation, string type)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Speed = speed;
            this.Fuel = fuel;
            this.CurrentLocation = currentLocation;
            this.Image = GlobalVariables.AirplaneInFlight;
        }
        public void Update()
        {
            if (this.Flight != null)
            {
                switch (this.PlaneStatus)
                {
                    case Status.TOTAKEOFF:
                        //if check flight timing then we take off
                        // check if lanes are free
                        if (Flight.DepartureAirport.LanesTaken < Flight.DepartureAirport.Lanes)
                        {
                            PlaneStatus = Status.TAKINGOFF;
                            break;
                        }
                        else
                        {
                            //add to queue to take off
                            break;
                        }

                    case Status.INAIR:
                        UpdateMovement();
                        break;
                    case Status.CIRCLING:
                        //call Circle method
                        break;
                    case Status.LANDING:
                        counterTicks++;
                        if (counterTicks >= 2)
                        {
                            PlaneStatus = Status.LANDED;
                            this.Flight.DestinationAirport.FreeLane();
                        }
                        break;
                    case Status.LANDED:
                        break;
                    case Status.TAKINGOFF:
                        counterTicks++;
                        if (counterTicks >= 2)
                        {
                            PlaneStatus = Status.INAIR;
                            // remove plane from airport 
                            counterTicks = 0;
                            // release lane

                        }
                        break;
                }
            }
        }
        public void UpdateMovement()
        {
            if (this.Flight != null)
            {
                float x1 = this.DepartureLocation.X;
                float x2 = this.DestinationLocation.X;
                float y1 = this.DepartureLocation.Y;
                float y2 = this.DestinationLocation.Y;

                float xCurrent = this.CurrentLocation.X;
                float yCurrent = this.CurrentLocation.Y;
                // calculations of movement
                double totaldistance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double currentdistance = Math.Sqrt(Math.Pow(xCurrent - x1, 2) + Math.Pow(yCurrent - y1, 2));
                double distancepassed = (20 * 30 / 60); // Distance = speed * time  --> speed = 20px/hour time = 30 minutes 
                double A = (y2 - y1);
                double B = (x2 - x1);

                float xNew;
                float yNew;
                if (B != 0 && A != 0) // calculate new point based on distance passed and current location
                {
                    double slope = A / B;
                    double k = distancepassed / Math.Sqrt(1 + Math.Pow(slope, 2));
                    if (B < 0)
                    {
                        k = -k;
                    }
                    xNew = (float)(xCurrent + k * 1);

                    k = Math.Abs(k);
                    if (A < 0)
                    {
                        k = -k;
                    }
                    yNew = (float)(yCurrent + k * Math.Abs(slope));
                }
                else if (A == 0) //then y stays the same, add distance/substract distance to x
                {
                    if (B < 0)
                    {
                        distancepassed = -distancepassed;
                    }
                    xNew = (float)(distancepassed + xCurrent);
                    yNew = yCurrent;
                }
                else //x stays the same, add distance/substract distance to y
                {
                    if (A < 0)
                    {
                        distancepassed = -distancepassed;
                    }
                    xNew = xCurrent;
                    yNew = (float)distancepassed + yCurrent;
                }
                if (totaldistance < currentdistance + distancepassed)
                {
                    xNew = this.DestinationLocation.X;
                    yNew = this.DestinationLocation.Y;

                    //plane has arrived and must request perimission -> be added to the queue or occupy a lane
                    if(this.Flight.DestinationAirport.RequestLandingPermission(this))
                    {
                        this.PlaneStatus = Status.LANDING;
                    }
                    else
                    {
                        this.PlaneStatus = Status.CIRCLING;
                    }
                }
                this.CurrentLocation = new PointF(xNew, yNew);
                this.CoverArea = new Rectangle(Convert.ToInt32(CurrentLocation.X), Convert.ToInt32(CurrentLocation.Y), 25, 25);
                
            }
        }

        public void AddFlight(Flight f)
        {
            this.Flight = f;
            this.ChangeRoute(this.Flight.DepartureAirport.Location, this.Flight.DestinationAirport.Location);
        }

        public void ChangeRoute(PointF start,PointF end)
        {
            this.DepartureLocation = start;
            this.DestinationLocation = end;
            this.TransformImage();
        }
        private void TransformImage()
        {
            float x1 = this.DepartureLocation.X;
            float x2 = this.DestinationLocation.X;
            float y1 = this.DepartureLocation.Y;
            float y2 = this.DestinationLocation.Y;

            float xDiff = x1 - x2;
            float yDiff = y1 - y2;
            // float rotationAngle = (float)Math.Atan2(yDiff, xDiff) * (float)(240/ Math.PI);

            float rotationAngle = (float)toDegree((float)Math.Atan2(yDiff, xDiff)) + 180;
            if (rotationAngle < 0)
            {
                rotationAngle += 360;
            }

            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(Image.Width, Image.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(GlobalVariables.AirplaneInFlight, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            Image = bmp;
        }

        private double toDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        /// <summary>
        /// Changes the fuel of the airplane (Does not affect the simulation yet)
        /// </summary>
        /// <param name="newFuel"></param>
        public void ChangeFuel(int newFuel)
        {
            this.Fuel = newFuel;
        }

        /// <summary>
        /// Changes the speed of the airplane (Doesn't affect the simulation yet)
        /// </summary>
        /// <param name="newSpeed"></param>
        public void ChangeSpeed(int newSpeed)
        {
            this.Speed = newSpeed;
        }
    }
}
