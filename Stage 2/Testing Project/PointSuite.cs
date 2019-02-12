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
            src.x = 1; // Записываем 1 в поле x , переменной src
            src.y = 1;
            dest.x = 3;
            dest.y = 4;
            act = Point.distanceBetween1(src,dest);
            Assert.AreEqual(3.6056, act, 0.0001);
        }
    }
}
