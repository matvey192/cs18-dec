using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
namespace Testing_Project
{
    [TestClass]
    public class RangeSuite
    {
        [TestMethod]
        public void IntersectsIntsTest()
        {
            bool res;
            Range left = new Range();
            left.from = 2;
            left.to = 3;
            res =left.Intersects(5,7);
            Assert.IsFalse(res);

            left.from = 11;
            left.to = 17;
            res = left.Intersects(13, 19);
            Assert.IsTrue(res);

            left.from = 23;
            left.to = 37;
            res = left.Intersects(29, 31);
            Assert.IsTrue(res);

            left.from = 43;
            left.to = 53;
            res = left.Intersects(41, 47);
            Assert.IsTrue(res);

            left.from = 5;
            left.to = 15;
            res = left.Intersects(0, 30);
            Assert.IsTrue(res);

            left.from = 67;
            left.to = 71;
            res = left.Intersects(59,61);
            Assert.IsFalse(res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IntersectsIntWrongLeftTest1()
        {
            Range left = new Range();
            left.from = 79;
            left.to = 73;
            left.Intersects(83,89);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void IntersectsIntWrongRightTest1()
        {
            Range left = new Range();
            left.from = 97;
            left.to = 101;
            left.Intersects(107,103);
        }

        [TestMethod]
        public void HasIntersectionRangesTest()
        {
            bool res;
            Range left, right;
            left = new Range();
            right = new Range();
            left.from = 2;
            left.to = 3;
            right.from = 5;
            right.to = 7;
            res = Range.HasIntersection(left, right);
            Assert.IsFalse(res);

            left.from = 11;
            left.to = 17;
            right.from = 13;
            right.to = 19;
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.from = 23;
            left.to = 37;
            right.from = 29;
            right.to = 31;
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.from = 43;
            left.to = 53;
            right.from = 41;
            right.to = 47;
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.from = 5;
            left.to = 15;
            right.from = 0;
            right.to = 30;
            res = Range.HasIntersection(left, right);
            Assert.IsTrue(res);

            left.from = 67;
            left.to = 71;
            right.from = 59;
            right.to = 61;
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
            left.from = 79;
            left.to = 73;
            right.from = 83;
            right.to = 89;
            Range.HasIntersection(left, right);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IntersectsIntWrongRightTest()
        {
            Range left, right;
            left = new Range();
            right = new Range();
            left.from = 97;
            left.to = 101;
            right.from = 107;
            right.to = 103;
            Range.HasIntersection(left, right);
        }
    }
}
