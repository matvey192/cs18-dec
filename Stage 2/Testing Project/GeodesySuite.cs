using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
namespace Testing_Project
{
    [TestClass]
    public class GeodesySuite
    {
        [TestMethod]
        public void BackwardTaskTest()
        {
            Direction direction;
            direction = new Direction();
            Point src, dest; // переменные класса Point
            src = new Point(); // инициализация экземпляров класса 
            dest = new Point();
            //1
            src.setCoordinates(10, 10);
            dest.setCoordinates(13,14);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000,direction.distance,0.0001);
            Assert.AreEqual(53.1301,direction.angle,0.0001);
            //2
            src.setCoordinates(24,4);
            dest.setCoordinates(3,17);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(24.6982, direction.distance, 0.0001);
            Assert.AreEqual(148.2405, direction.angle, 0.0001);
            //3
            src.setCoordinates(23,25);
            dest.setCoordinates(12,16);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(14.2127, direction.distance, 0.0001);
            Assert.AreEqual(219.2894, direction.angle, 0.0001);
            //4
            src.setCoordinates(3,11);
            dest.setCoordinates(13,5);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(11.6619, direction.distance, 0.0001);
            Assert.AreEqual(329.0362, direction.angle, 0.0001);
            //5
            src.setCoordinates(5, 5);
            dest.setCoordinates(5, 10);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(90.0000, direction.angle, 0.0001);
            //6
            src.setCoordinates(10, 5);
            dest.setCoordinates(5, 5);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(180.0000, direction.angle, 0.0001);
            //7
            src.setCoordinates(5, 10);
            dest.setCoordinates(5, 5);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(270.0000, direction.angle, 0.0001);
            //8
            src.setCoordinates(5, 5);
            dest.setCoordinates(10, 5);
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(360.0000, direction.angle, 0.0001);
        }
    }
}
