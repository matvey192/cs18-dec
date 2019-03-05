using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
namespace Testing_Project
{
    [TestClass]
    public class PointSuite
    {
        [TestMethod]
        public void distanceBetweenValuesTest()
        {
            double act;
            act = Point.distanceBetween(1  , 1  , 3 ,  4);
            Assert.AreEqual(3.6056,act,0.0001);
            act = Point.distanceBetween(-2 , 4  , 8 ,- 10);
            Assert.AreEqual(17.2046, act, 0.0001);
            act = Point.distanceBetween(0  , 0 ,- 5 ,- 7);
            Assert.AreEqual(8.6023, act, 0.0001);
            act = Point.distanceBetween(0  , 0 ,  0 ,  0);
            Assert.AreEqual(0, act, 0.0001);
            act = Point.distanceBetween(-1 ,- 3,  2 ,  9);
            Assert.AreEqual(12.3693, act, 0.0001);
        }
        [TestMethod]
        public void distanceBetweenPointsTest()
        {
            double act; 
            Point src, dest; // переменные класса Point
            src = new Point(); // инициализация экземпляров класса 
            dest = new Point();
            src.setCoordinates(1, 1);
            dest.setCoordinates(3, 4);
            act = Point.distanceBetween1(src,dest);
            Assert.AreEqual(3.6056, act, 0.0001);
        }
        [TestMethod]
        public void distanceToValuesTest()
        {
            Point src;
            src = new Point();
            src.setCoordinates(1, 1);
            double res = src.distanceTo(3, 4);
            Assert.AreEqual(3.6056, res, 0.0001);
        }
        [TestMethod]
        public void distanceToPointsTest()
        {
            Point src, dest;
            src = new Point();
            dest = new Point();
            src.setCoordinates(1, 1);
            dest.setCoordinates(3, 4);
            double res = src.distanceTo1(dest);
            Assert.AreEqual(3.6056, res, 0.0001);
        }
        [TestMethod]
        public void AreSameTest()
        {
            Point src, dest;
            src = new Point();
            dest = new Point();
            src.setCoordinates(10, 15);
            dest.setCoordinates(10, 15);
            bool res=Point.AreSame(src, dest);
            Assert.IsTrue(res);

            src.setCoordinates(10, 15);
            dest.setCoordinates(0, 0);
            res = Point.AreSame(src, dest);
            Assert.IsFalse(res);

            src.setCoordinates(10, 15);
            dest.setCoordinates(10, 7);
            res = Point.AreSame(src, dest);
            Assert.IsFalse(res);

            src.setCoordinates(10, 15);
            dest.setCoordinates(3, 15);
            res = Point.AreSame(src, dest);
            Assert.IsFalse(res);
        }
    }//12,11,14,16,17
}
