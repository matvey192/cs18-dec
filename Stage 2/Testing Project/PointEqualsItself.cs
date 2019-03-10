using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
namespace Testing_Project
{
    [TestClass]
    public class PointEqualsItself
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool i;
            Point ff = new Point();
            i = ff.Equals(ff);
            Assert.IsTrue(i);
        }

        [TestMethod]
        public void PointInstanceComparison()
        {
            bool i;
            Point a1, a2, b1, b2, b3;
            a1 = new Point();
            a2 = new Point();
            b1 = new Point();
            b2 = new Point();
            b3 = new Point();
            a1.setCoordinates(10, 15);
            a2.setCoordinates(10, 15);
            b1.setCoordinates(0, 0);
            b2.setCoordinates(10, 3);
            b3.setCoordinates(1, 15);

            i = a1.Equals(a1);
            Assert.IsTrue(i);
        }
    }
}
