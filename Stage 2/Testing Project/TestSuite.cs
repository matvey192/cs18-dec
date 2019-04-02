using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Testing_Project
{
    [TestClass]
    public class TestSuite
    {
        //15.11 Hashcode
        [TestMethod]
        public void SamePointsWithSameHashcode()
        {
            Point a = new Point(0, 0);
            a.setColor("green");
            Point b = new Point(0, 0);
            b.setColor("green");
            Point c = new Point(0, 0);
            c.setColor("red");
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
            Assert.AreNotEqual(c.GetHashCode(), b.GetHashCode());
            bool r = b.Equals(a);
            Assert.IsTrue(r);
            r = a.Equals(b);
            Assert.IsTrue(r);
            r = c.Equals(a);
            Assert.IsFalse(r);
            r = c.Equals(b);
            Assert.IsFalse(r);
        }
        [TestMethod]
        public void HashSetContainsOnlyOneOfSamePoints()
        {
            HashSet<Point> pts = new HashSet<Point>();
            Point a = new Point(0, 0);
            a.setColor("red");
            pts.Add(a);
            Point b = new Point(0, 0);
            b.setColor("red");
            pts.Add(b);
            Point c = new Point(0, 0);
            c.setColor("green");
            pts.Add(c);
            bool r = pts.Contains(a);
            Assert.IsTrue(r);

        }
        [TestMethod]
        public void DifferentPointsWithDifferentHashcode()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 5);
            Point c = new Point(5, 0);
            Point d = new Point(5, 5);
            Assert.AreNotEqual(a.GetHashCode(), b.GetHashCode());
            Assert.AreNotEqual(a.GetHashCode(), c.GetHashCode());
            Assert.AreNotEqual(a.GetHashCode(), d.GetHashCode());
            Assert.AreNotEqual(b.GetHashCode(), c.GetHashCode());
            Assert.AreNotEqual(b.GetHashCode(), d.GetHashCode());
            Assert.AreNotEqual(c.GetHashCode(), d.GetHashCode());
            Assert.IsFalse(a.Equals(b));
            Assert.IsFalse(a.Equals(c));
            Assert.IsFalse(a.Equals(d));
            Assert.IsFalse(b.Equals(c));
            Assert.IsFalse(b.Equals(d));
            Assert.IsFalse(c.Equals(d));
        }
        [TestMethod]
        public void DifferentPointsWithSameHashcode()
        {
            Point a = new Point(0, 1);
            Point b = new Point(31, 0);
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
            Assert.IsFalse(a.Equals(b));

        }
        [TestMethod]
        public void HashSetContainsAllDifferentPointsWithDifferentHashcode()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 5);
            Point c = new Point(5, 0);
            Point d = new Point(5, 5);
            HashSet<Point> pts = new HashSet<Point>();
            pts.Add(a);
            pts.Add(b);
            pts.Add(c);
            pts.Add(d);
            Assert.AreEqual(4, pts.Count);
            Assert.IsTrue(pts.Contains(a));
            Assert.IsTrue(pts.Contains(b));
            Assert.IsTrue(pts.Contains(c));
            Assert.IsTrue(pts.Contains(d));
        }
        [TestMethod]
        public void hashSetContainsAllDifferentPointsWithSameHashcode()
        {
            Point a = new Point(0, 1);
            Point b = new Point(31, 0);
            HashSet<Point> pts = new HashSet<Point>();
            pts.Add(a);
            pts.Add(b);
            Assert.IsTrue(pts.Contains(a));
            Assert.IsTrue(pts.Contains(b)); // ru.wikipedia.org/wiki/A*   number 12 / 

        }

        //15.2
        [TestMethod]
        public void Task8418Test()
        {
            List<int> expected = new List<int>();
            List<int> actual = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(6);
            actual = Methods.Task8418(6);
            CollectionAssert.AreEqual(expected, actual);

            List<int> expected1 = new List<int>()
            {
                1 ,5 ,7 ,11, 35, 55, 77, 385
            };
            List<int> actual1 = new List<int>();
            actual1 = Methods.Task8418(385);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotAcceptNegativeArg()
        {
            Methods.Task8418(-385);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotAcceptZero()
        {
            Methods.Task8418(0);
        }

        [TestMethod]
        public  void task4411test()
        {
            double actual;
            actual = Methods.task4411(11.13);
            Assert.AreEqual(18.13, actual, 0.0001);
            actual = Methods.task4411(-7919);
            Assert.AreEqual(-7912, actual, 0.0001);
            actual = Methods.task4411(0);
            Assert.AreEqual(7, actual, 0.0001);
        }
        [TestMethod]
        public void task2790test()
        {
            double actual;
            actual = Methods.task2790(6997);
            Assert.AreEqual(0.9205 , actual, 0.0001);
            actual = Methods.task2790(31);
            Assert.AreEqual(0.8572, actual, 0.0001);
            actual = Methods.task2790(90);
            Assert.AreEqual(0.0000, actual, 0.0001);
            actual = Methods.task2790(0);
            Assert.AreEqual(1.0000, actual, 0.0001);
            actual = Methods.task2790(180);
            Assert.AreEqual(1.0000, actual, 0.0001);
        }
        [TestMethod]
        public void task3946()
        {
            int[] data = new int[] { 1, 2, 3, 4, 1 };
            double res = Methods.task3946(data);
            Assert.AreEqual(2.2, res, 0.0001);
            int[] data1 = new int[] { 1, 2, 3, 4, 1, 3, 4, 4, 4, 4 };
            res = Methods.task3946(data1);
            Assert.AreEqual(3, res, 0.0001);
            int[] data2 = new int[] {  };
             res = Methods.task3946(data2);
            Assert.AreEqual(0, res, 0.0001);
        }
        [TestMethod]
        public void task9774()
        {
            int[] data = new int[] { 9 ,8 ,7 ,6, 5 ,4 };
            int[] expected= new int[] { 279 ,248, 217 ,186, 155, 124 };
            int m = 31;
            Methods.task9774(m, data);
            CollectionAssert.AreEqual(expected, data);
            int[] data1 = new int[] { 9, 8, 7, 6, 5, 4 };
            int[] expected1 = new int[] { -27, - 24, - 21, - 18, - 15, - 12 };
             m = -3;
            Methods.task9774(m, data1);
            CollectionAssert.AreEqual(expected1, data1);
            int[] data2 = new int[] { 98 ,76 ,54 };
            int[] expected2 = new int[] { 1078, 836 ,594 };
             m = 11;
            Methods.task9774(m, data2);
            CollectionAssert.AreEqual(expected2, data2);
            int[] data3 = new int[] {};
            int[] expected3 = new int[] {};
            m = 73;
            Methods.task9774(m, data3);
            CollectionAssert.AreEqual(expected3, data3);
        }
        [TestMethod]
        public void task4847()
        {
            bool c =  Methods.task4847(31, 59, 83);
            bool d =  Methods.task4847(19 ,19 ,41);
            bool e = Methods.task4847(7 ,11 , 11);
            bool f = Methods.task4847(67 ,- 67, 67);
            bool g = Methods.task4847(1 ,1,1);
            Assert.IsFalse(c);
            Assert.IsTrue(d);
            Assert.IsTrue(e);
            Assert.IsTrue(f);
            Assert.IsTrue(g);
        }
        [TestMethod]
        public void task5662()
        {
            string d ;
            string res;
           res= Methods.Task5662(1, 2, 3);
            d = "Вещественных корней уравнения1x ^ 2 + 2x + 3= 0 нет";
            Assert.AreEqual(d, res);
            res=Methods.Task5662(11, 13, 19);
            d = "Вещественных корней уравнения11x ^ 2 + 13x + 19= 0 нет";
            Assert.AreEqual(d, res);
            res =Methods.Task5662(3, 17, 5);
            d = "У уравнения3x ^ 2 + 17x + 5 = 0 два вещественных корня";
            Assert.AreEqual(d, res);
            res =Methods.Task5662(5, 31, 29);
            d = "У уравнения5x ^ 2 + 31x + 29 = 0 два вещественных корня";
            Assert.AreEqual(d, res);
            res =Methods.Task5662(3, 6, 3);
            d = "Уравнение 3x ^ 2 + 6x + 3 = 0 имеет один корень";
            Assert.AreEqual(d, res);
            res =Methods.Task5662(1, 2, 1);
            d = "Уравнение 1x ^ 2 + 2x + 1 = 0 имеет один корень";
            Assert.AreEqual(d, res);
            res =Methods.Task5662(0, 7, 13);
            d = "Данное уравнение не является квадратным";
            Assert.AreEqual(d, res);
        }
        [TestMethod]
        public void task3669()
        {
            long i = 0;
            i = Methods.Task3669(8, 13);
            Assert.AreEqual(1235520, i);
            i = Methods.Task3669(13, 8);
            Assert.AreEqual(1235520, i);
            i = Methods.Task3669(159, 161);
            Assert.AreEqual(4095840, i);
            i = Methods.Task3669(648, 648);
            Assert.AreEqual(648, i);
            i = Methods.Task3669(-2, 600);
            Assert.AreEqual(0, i);
            i = Methods.Task3669(35, 24);
            Assert.AreEqual(399703747322880000, i);
        }
        [TestMethod]
        public void task1292()
        {
            string b = "";
            b = Methods.Task1292("a");
            Assert.AreEqual("a", b);
            b = Methods.Task1292("b");
            Assert.AreEqual("ab", b);
            b = Methods.Task1292("d");
            Assert.AreEqual("abcd", b);
            b = Methods.Task1292("h");
            Assert.AreEqual("abcdefgh", b);
            b = Methods.Task1292("i");
            Assert.AreEqual("abcdefgh", b);
        }
        [TestMethod]
        public void task4283()
        {
            int res = 0;
            res = Methods.task4283(3, new int[] { 1, 2, 3, 4, 1, 2 });
            Assert.AreEqual(1, res);
            res = Methods.task4283(5, new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3 });
            Assert.AreEqual(0, res);
            res = Methods.task4283(2, new int[] { 3, 2, 2, 2, 2, 2 });
            Assert.AreEqual(5, res);
            res = Methods.task4283(1, new int[] { 4, 4, 4, 4, 4, 4 });
            Assert.AreEqual(0, res);
        }
        //13/5
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9020assertion1()
        {
            Methods.Task9020(62);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9020assertion2()
        {
            Methods.Task9020(7573);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9020assertion3()
        {
            Methods.Task9020(75);
        }
        //13/6
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task5871assertion1()
        {
            Methods.Task5871(2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task5871assertion2()
        {
            Methods.Task5871(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task5871assertion3()
        {
            Methods.Task5871(-4);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task5871assertion4()
        {
            Methods.Task5871(-20);
        }
        //13/7
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
       public void Task7799assertion1()
        {
            Methods.Task7799(0,45);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task7799assertion2()
        {
            Methods.Task7799(-10, 5);
        }
        //13/8
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9354assertion1()
        {
            Methods.Task9354(0,1,3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9354assertion2()
        {
            Methods.Task9354(0,1000,2000);
        }
        //13/9
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task5170assertion()
        {
            Methods.task5170(-10);
        }
    }
}
