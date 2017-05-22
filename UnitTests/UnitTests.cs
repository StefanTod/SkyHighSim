using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Airtraffic_Simulator;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestQueueInsertion()
        {
            Airplane plane1 = new AirplanePassanger("1", 1, 1, 1,new PointF(5,5), " ");
            Airplane plane2 = new AirplanePassanger("2", 1, 1, 1, new PointF(5, 5), " ");
            Airplane plane3 = new AirplanePassanger("3", 1, 1, 1, new PointF(5, 5), " ");
            Queue q = new Queue(null);
            q.AddPlaneToQueueTest(5, plane1);
            q.AddPlaneToQueueTest(10, plane2);
            q.AddPlaneToQueueTest(15, plane3);

            Assert.AreEqual(plane3, q.pQueue.PeekValue());
            Assert.AreEqual(plane3,q.DequeueHighestPriority());
            Assert.AreEqual(plane2, q.pQueue.PeekValue());
        }
    }
}
