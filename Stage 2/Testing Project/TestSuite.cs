using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeProject;
namespace Testing_Project
{
    [TestClass]
    public class TestSuite
    {
        [TestMethod]
        public void TestMethod1()
        {
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
            string res;
           res= Methods.Task5662(1, 2, 3);
            Assert.AreEqual("Вещественных корней уравнения 1x ^ 2 + 2x + 3 = 0 нет", res);
            res=Methods.Task5662(11, 13, 19);
            Assert.AreEqual("Вещественных корней уравнения 11x^2 + 13x + 19 = 0 нет", res);
            res =Methods.Task5662(3, 17, 5);
            Assert.AreEqual("У уравнения 3x^2 + 17x + 5 = 0 два вещественных корня", res);
            res =Methods.Task5662(5, 31, 29);
            Assert.AreEqual("У уравнения 5x^2 + 31x + 29 = 0 два вещественных корня", res);
            res =Methods.Task5662(3, 6, 3);
            Assert.AreEqual("Уравнение 3x^2 + 6x + 3 = 0 имеет один корень", res);
            res =Methods.Task5662(1, 2, 1);
            Assert.AreEqual("Уравнение 1x^2 + 2x + 1 = 0 имеет один корень", res);
            res =Methods.Task5662(0, 7, 13);
            Assert.AreEqual("Данное уравнение не является квадратным", res);
        }
    }
}
