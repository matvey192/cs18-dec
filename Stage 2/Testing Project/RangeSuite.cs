using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
namespace Testing_Project
{
    [TestClass]
    public class RangeSuite
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TangeTest13()
        {
            bool i;
            Range p = new Range();
            Range Et = new Range();
            p.Init(3,5);
            p.shift(7);
            Et.Init(10, 12);
            i = p.Equals(Et);
            Assert.IsTrue(i);

            p.Init(31,43);
            p.shift(-6);
            Et.Init(25,37);
            i = p.Equals(Et);
            Assert.IsTrue(i);

            p.Init(10, 50);
            p.squeeze(30);
            Et.Init(10, 20);
            i = p.Equals(Et);
            Assert.IsTrue(i);

            p.Init(23, 51);
            p.squeeze(100);
            Et.Init(10, 20);
            i = p.Equals(Et);

            p.Init(19, 29);
            p.squeeze(-5);
            Et.Init(19, 34);
            i = p.Equals(Et);
            Assert.IsTrue(i);
        }

        [TestMethod]
        public void IntersectsIntsTest()
        {
            bool res;
            Range left = new Range();
            left.Init(2, 3);
            res =left.Intersects(5,7);
            Assert.IsFalse(res);

            left.Init(11, 17);
            res = left.Intersects(13, 19);
            Assert.IsTrue(res);

            left.Init(23, 37);
            res = left.Intersects(29, 31);
            Assert.IsTrue(res);

            left.Init(53, 43);
            res = left.Intersects(41, 47);
            Assert.IsTrue(res);

            left.Init(5, 15);
            res = left.Intersects(0, 30);
            Assert.IsTrue(res);

            left.Init(67, 71);
            res = left.Intersects(59,61);
            Assert.IsFalse(res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IntersectsIntWrongLeftTest1()
        {
            Range left = new Range();
            left.Init(79, 73);
            left.Intersects(83,89);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IntersectsIntWrongRightTest1()
        {
            Range left = new Range();
            left.Init(97, 101);
            left.Intersects(107,103);
        }

        [TestMethod]
        public void HasIntersectionRangesTest()
        {
            bool res;
            Range left, right;
            left = new Range();
            right = new Range();
            left.Init(2, 3);
            right.Init(5, 7);
            res = Range.HasIntersection(left, right);
            Assert.IsFalse(res);

            left.Init(11, 17);
            right.Init(13, 19);
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.Init(23, 37);
            right.Init(29, 31);
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.Init(43, 53);
            right.Init(41, 47);
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.Init(5, 15);
            right.Init(0, 30);
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.Init(67, 71);
            right.Init(59, 61);
            res = Range.HasIntersection(left, right);
            Assert.IsFalse(res);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IntersectsIntWrongLeftTest()
        {
            Range left, right;
            left = new Range();
            right = new Range();
            left.Init(79, 73);
            right.Init(83, 89);
            Range.HasIntersection(left, right);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IntersectsIntWrongRightTest()
        {
            Range left, right;
            left = new Range();
            right = new Range();
            left.Init(97, 101);
            right.Init(107, 103);
            Range.HasIntersection(left, right);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitWrongTest()
        {
            Range p = new Range();
            p.Init(79, 73);
        }
    }
}
