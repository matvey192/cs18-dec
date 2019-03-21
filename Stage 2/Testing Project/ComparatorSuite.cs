using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
using System.Collections.Generic;
namespace Testing_Project
{
    [TestClass]
    public class ComparatorSuite
    {
        //15.6
        [TestMethod]
        public void Comparator1457SortTest()
        {
            Point a = new Point(5,4);
            double res;
            PointComparator p = new PointComparator();
            res=p.ComparatorP(a, 5, 7);

        }
        //15.4
        [TestMethod]
        public void Comparator4061SortTest()
        {
            List<int> expected = new List<int>()
            {
                1, -3, 5, 7, -10
            };

            List<int> actual = new List<int>()
            {
                -10, 1, -3, 7, 5
            };
            Comparator4061 cmp = new Comparator4061();
            actual.Sort(cmp);
            CollectionAssert.AreEqual(actual, expected);

            List<int> expected1 = new List<int>()
            {
               -3, -3, -3, 3, 3, 3
            };

            List<int> actual1 = new List<int>()
            {
                3, -3, 3, -3, -3, 3
            };
            Comparator4061 cmp1 = new Comparator4061();
            actual1.Sort(cmp1);
            CollectionAssert.AreEqual(actual1, expected1);

            List<int> expected2 = new List<int>()
            {
               0, -2, 2, 13, 25, -37, 10000
            };

            List<int> actual2 = new List<int>()
            {
                13, -2, 25, -37, 10000, 0, 2
            };
            Comparator4061 cmp2 = new Comparator4061();
            actual2.Sort(cmp2);
            CollectionAssert.AreEqual(actual2, expected2);
        }

        //15.3
        [TestMethod]
        public void Comparator8258Test()
        {
            int res;
            Comparator8258 p = new Comparator8258();
            res = p.Compare(5, 10);
            Assert.AreEqual(-1, res);

            res = p.Compare(10, 5);
            Assert.AreEqual(1, res);

            res = p.Compare(4, 20);
            Assert.AreEqual(-1, res);

            res = p.Compare(50, 20);
            Assert.AreEqual(1, res);

            res = p.Compare(15, 15);
            Assert.AreEqual(0, res);

            res = p.Compare(5, 7);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void CComparator8258SortTest()
        {
            List<int> expected = new List<int>()
            {
                7, 3, 10, 1
            };

            List<int> actual = new List<int>()
            {
                1, 3, 7, 10
            };
            Comparator8258 cmp = new Comparator8258();
            actual.Sort(cmp);
            CollectionAssert.AreEqual(actual, expected);

            List<int> expected1 = new List<int>()
            {
                6, 5, 7, 4, 8, 3, 9, 2, 10, 1, 0, -1, -2, -3, -4, -5
            };

            List<int> actual1 = new List<int>()
            {
                -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            Comparator8258 cmp1 = new Comparator8258();
            actual1.Sort(cmp1);
            CollectionAssert.AreEqual(actual1, expected1);

            List<int> expected2 = new List<int>()
            {
                5, 5, 5, 5, 5
            };

            List<int> actual2 = new List<int>()
            {
                5, 5, 5, 5, 5
            };
            Comparator8258 cmp2 = new Comparator8258();
            actual2.Sort(cmp2);
            CollectionAssert.AreEqual(actual2, expected2);

        }
        //15.5
        [TestMethod]
        public void Comparator7186SortTest()
        {
            List<int> expected = new List<int>()
            {
                7, 3, 10, 1
            };

            List<int> actual = new List<int>()
            {
                1, 3, 7, 10
            };
            Comparator7186 cmp = new Comparator7186();
            cmp.p = 6;
            actual.Sort(cmp);
            CollectionAssert.AreEqual(actual, expected);

            List<int> expected1 = new List<int>()
            {
               10, 7, 3, 1
            };

            List<int> actual1 = new List<int>()
            {
                1, 3, 7, 10
            };
            Comparator7186 cmp1 = new Comparator7186();
            cmp1.p = 10;
            actual1.Sort(cmp1);
            CollectionAssert.AreEqual(actual1, expected1);

            List<int> expected2 = new List<int>()
            {
               3, 1, 7, 10
            };

            List<int> actual2 = new List<int>()
            {
                1, 3, 7, 10
            };
            Comparator7186 cmp2 = new Comparator7186();
            cmp2.p = 4;
            actual2.Sort(cmp2);
            CollectionAssert.AreEqual(actual2, expected2);

            List<int> expected3 = new List<int>()
            {
                -49, -47, -55, -55, -60, -60, -39, -65, -28,
                -16, -14, -12, 1, 4, 15, 22, 61, 66, 74, 80
            };

            List<int> actual3 = new List<int>()
            {
                -49, -55, -60, -60, 15, -28, 22, -16, 4, 61,
                 74, -39, -55, -14, -12, 66, 80, -47, 1, -65
            };
            Comparator7186 cmp3 = new Comparator7186();
            cmp3.p = -50;
            actual3.Sort(cmp3);
            CollectionAssert.AreEqual(actual3, expected3);
        }
    }
}
