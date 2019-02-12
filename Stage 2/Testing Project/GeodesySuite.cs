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
            src.x = 10; // Записываем 1 в поле x , переменной src
            src.y = 10;
            dest.x = 13;
            dest.y = 14;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000,direction.distance,0.0001);
            Assert.AreEqual(53.1301,direction.angle,0.0001);
            //2
            src.x = 24; // Записываем 1 в поле x , переменной src
            src.y = 4;
            dest.x = 3;
            dest.y = 17;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(24.6982, direction.distance, 0.0001);
            Assert.AreEqual(148.2405, direction.angle, 0.0001);
            //3
            src.x = 23; // Записываем 1 в поле x , переменной src
            src.y = 25;
            dest.x = 12;
            dest.y = 16;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(14.2127, direction.distance, 0.0001);
            Assert.AreEqual(219.2894, direction.angle, 0.0001);
            //4
            src.x = 3; // Записываем 1 в поле x , переменной src
            src.y = 11;
            dest.x = 13;
            dest.y = 5;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(11.6619, direction.distance, 0.0001);
            Assert.AreEqual(329.0362, direction.angle, 0.0001);
            //5
            src.x = 5; // Записываем 1 в поле x , переменной src
            src.y = 5;
            dest.x = 5;
            dest.y = 10;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(90.0000, direction.angle, 0.0001);
            //6
            src.x = 10; // Записываем 1 в поле x , переменной src
            src.y = 5;
            dest.x = 5;
            dest.y = 5;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(180.0000, direction.angle, 0.0001);
            //7
            src.x = 5; // Записываем 1 в поле x , переменной src
            src.y = 10;
            dest.x = 5;
            dest.y = 5;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(270.0000, direction.angle, 0.0001);
            //8
            src.x = 5; // Записываем 1 в поле x , переменной src
            src.y = 5;
            dest.x = 10;
            dest.y = 5;
            direction = Methods.BackwardTask(src, dest);
            Assert.AreEqual(5.0000, direction.distance, 0.0001);
            Assert.AreEqual(360.0000, direction.angle, 0.0001);
        }
    }
}
