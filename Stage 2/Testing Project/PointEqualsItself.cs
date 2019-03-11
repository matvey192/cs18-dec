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
            Point ff = new Point(0,0);
            i = ff.Equals(ff);
            Assert.IsTrue(i);
        }

        [TestMethod]
        public void PointInstanceComparison()
        {
            bool i;
            Point a1, a2, b1, b2, b3,b4,b5,b6,b7;
            a1 = new Point(10,15);
            a2 = new Point(10,15);
            b1 = new Point(0,0);
            b2 = new Point(10,3);
            b3 = new Point(1,15);
            b4 = new Point(5,7);
            b5 = new Point(10,15);
            b6 = new Point(10,3);
            b7 = new Point(2,15);

            i = a2.Equals(a1);
            Assert.IsTrue(i);
            i = a1.Equals(a2);
            Assert.IsTrue(i);

            i = b1.Equals(a2);
            Assert.IsFalse(i);
            i = b2.Equals(a2);
            Assert.IsFalse(i);
            i = b3.Equals(a2);
            Assert.IsFalse(i);
            i = b4.Equals(a2);
            Assert.IsFalse(i);
            i = b5.Equals(a2);
            Assert.IsFalse(i);
            i = b6.Equals(a2);
            Assert.IsFalse(i);
            i = b7.Equals(a2);
            Assert.IsFalse(i);

            i = b1.Equals(a1);
            Assert.IsFalse(i);
            i = b2.Equals(a1);
            Assert.IsFalse(i);
            i = b3.Equals(a1);
            Assert.IsFalse(i);
            i = b4.Equals(a1);
            Assert.IsFalse(i);
            i = b5.Equals(a1);
            Assert.IsFalse(i);
            i = b6.Equals(a1);
            Assert.IsFalse(i);
            i = b7.Equals(a1);
            Assert.IsFalse(i);

            i = a1.Equals(b1);
            Assert.IsFalse(i);
            i = a1.Equals(b2);
            Assert.IsFalse(i);
            i = a1.Equals(b3);
            Assert.IsFalse(i);
            i = a1.Equals(b4);
            Assert.IsFalse(i);
            i = a1.Equals(b5);
            Assert.IsFalse(i);
            i = a1.Equals(b6);
            Assert.IsFalse(i);
            i = a1.Equals(b7);
            Assert.IsFalse(i);

            i = a2.Equals(b1);
            Assert.IsFalse(i);
            i = a2.Equals(b2);
            Assert.IsFalse(i);
            i = a2.Equals(b3);
            Assert.IsFalse(i);
            i = a2.Equals(b4);
            Assert.IsFalse(i);
            i = a2.Equals(b5);
            Assert.IsFalse(i);
            i = a2.Equals(b6);
            Assert.IsFalse(i);
            i = a2.Equals(b7);
            Assert.IsFalse(i);

        }

        [TestMethod]
        public void PointNotEqualNull()
        {
            bool i;
            Point p = new Point(0,0);
            i = p.Equals(null);
            Assert.IsFalse(i);
        }
        [TestMethod]
        public void PointNotEqualOtherClass()
        {
            bool i;
            Point p = new Point(0,0);
            i = p.Equals("not a point");
            Assert.IsFalse(i);
        }
    }
}
