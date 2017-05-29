using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Airtraffic_Simulator;
using System.Drawing;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestQueueInsertion()
        {
            Airplane plane1 = new AirplanePassenger("1", 1, 1, 1,new PointF(5,5));
            Airplane plane2 = new AirplanePassenger("2", 1, 1, 1, new PointF(5, 5));
            Airplane plane3 = new AirplanePassenger("3", 1, 1, 1, new PointF(5, 5));
            Queue q = new Queue(null);
            q.AddPlaneToQueueTest(5, plane1);
            q.AddPlaneToQueueTest(10, plane2);
            q.AddPlaneToQueueTest(15, plane3);

            Assert.AreEqual(plane3, q.pQueue.PeekValue());
            Assert.AreEqual(plane3,q.DequeueHighestPriority());
            Assert.AreEqual(plane2, q.pQueue.PeekValue());
        }
        [TestMethod]
        public void TestPriorityPointsCalculation()
        {
            Airplane plane1 = new AirplanePassenger("1",200,3,5,new PointF(5,5));
            plane1.AddFlight(new FlightPassenger("1", new Airport("asd", 5, new PointF(5, 5), 5), new Airport("asd", 5, new PointF(5, 5), 5), TimeSpan.MaxValue, DateTime.Now, DateTime.Now, 199));

            Airplane plane2 = new AirplaneCargo("2",50,3,8, new PointF(5, 5));
            plane2.AddFlight(new FlightCargo("2", new Airport("asd",5,new PointF(5,5),5),new Airport("asd",5,new PointF(5,5),5), TimeSpan.MaxValue, DateTime.Now, DateTime.Now, 25));

            Airplane plane3 = new AirplanePassenger("3", 100, 3, 11, new PointF(5, 5));
            plane3.AddFlight(new FlightPassenger("3", new Airport("asd", 5, new PointF(5, 5), 5), new Airport("asd", 5, new PointF(5, 5), 5), TimeSpan.MaxValue, DateTime.Now, DateTime.Now, 25));

            Queue q = new Queue(null);
            q.AddPlaneToQueue(plane1);
            q.AddPlaneToQueue(plane2);
            q.AddPlaneToQueue(plane3);

            Assert.AreEqual(new KeyValuePair<int, Airplane>(7, plane1), q.pQueue.Dequeue());
        }
    }
}
