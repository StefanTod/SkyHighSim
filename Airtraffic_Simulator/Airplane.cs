using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airtraffic_Simulator
{
    public class Airplane
    {
        public Status Status { get; private set; }
        public Flight Flight { get; set; }
        public PointF CurrentLocation { get; set; }
        public Bitmap Image { get; set; }
        public string Id { get; private set; }
        public int Capacity { get; private set; }
        public double Speed { get; private set; }
        public double Fuel { get; private set; }
        public Rectangle CoverArea { get; set; }
        private int counterTicks = 0;
        public Airplane(string id, int capacity, double speed, double fuel, PointF currentLocation)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Speed = speed;
            this.Fuel = fuel;
            this.CurrentLocation = currentLocation;
            this.Image = new Bitmap(Airtraffic_Simulator.Properties.Resources.airplane_flying);
            this.Image = new Bitmap(Image, 25, 25);
           

        }
        public void Update()
        {
            switch (this.Status)
            {
                case Status.LANDED:
                    //if check flight timing then we take off
                    // check if lanes are free
                    if (Flight.DepartureAirport.LanesTaken < Flight.DepartureAirport.Lanes)
                    {
                        Status = Status.TAKINGOFF;
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
                case Status.LANDING:
                    counterTicks++;
                    if (counterTicks >= 2)
                    {
                        Status = Status.LANDED;
                        //add plane into destination airport
                    }
                    break;
                case Status.TAKINGOFF:
                    counterTicks++;
                    if (counterTicks >= 2)
                    {
                        Status = Status.INAIR;
                        // remove plane from airport 
                        counterTicks = 0;
                        // release lane

                    }
                    break;
            }
        }
        public void UpdateMovement()
        {
            if (this.Flight != null)
            {
                float x1 = this.Flight.DepartureAirport.Location.X;
                float x2 = this.Flight.DestinationAirport.Location.X;
                float y1 = this.Flight.DepartureAirport.Location.Y;
                float y2 = this.Flight.DestinationAirport.Location.Y;

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
                    xNew = this.Flight.DestinationAirport.Location.X;
                    yNew = this.Flight.DestinationAirport.Location.Y;
                    this.Status = Status.LANDING;
                }
                this.CurrentLocation = new PointF(xNew, yNew);
                this.CoverArea = new Rectangle(Convert.ToInt32(CurrentLocation.X), Convert.ToInt32(CurrentLocation.Y), 25, 25);
            }
        }

        public void AddFlight(Flight f)
        {
            this.Flight = f;

            float x1 = this.Flight.DepartureAirport.Location.X;
            float x2 = this.Flight.DestinationAirport.Location.X;
            float y1 = this.Flight.DepartureAirport.Location.Y;
            float y2 = this.Flight.DestinationAirport.Location.Y;



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
            gfx.DrawImage(Image, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            Image = bmp;
        }

        private double toDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
    }
}
