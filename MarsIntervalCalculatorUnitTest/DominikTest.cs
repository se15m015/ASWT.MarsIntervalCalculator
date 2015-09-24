using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsIntervalCalculator;

namespace MarsIntervalCalculatorUnitTest
{

    [TestClass]
    public class DominikTest
    {
        [TestMethod]
        public void TC_1()
        {
            var result = MarsIntervalCalc.CalculateInterval("-15:10", "17:99", "12:99","15:09");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_2()
        {
            var result = MarsIntervalCalc.CalculateInterval("25:10", "06:00", "04:00", "05:00");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_3()
        {
            var result = MarsIntervalCalc.CalculateInterval("03:100", "23:00", "04:00", "23:00");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_4()
        {
            var result = MarsIntervalCalc.CalculateInterval("05:05", "20:99", "10:10", "15:15");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void TC_5()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:10", "20:99", "10:10", "15:15");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void TC_6()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:10", "20:99", "20:99", "21:30");
            Assert.AreEqual("TOUCH", result);
        }

        [TestMethod]
        public void TC_7()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:10", "12:99", "08:99", "10:10");
            Assert.AreEqual("TOUCH", result);
        }

        [TestMethod]
        public void TC_8()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:10", "20:99", "15:99", "21:30");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void TC_9()
        {
            var result = MarsIntervalCalc.CalculateInterval("12:10", "22:99", "10:99", "20:30");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void TC_10()
        {
            var result = MarsIntervalCalc.CalculateInterval("05:10", "10:99", "11:00", "20:30");
            Assert.AreEqual("DISJOINT", result);
        }

        [TestMethod]
        public void TC_11()
        {
            var result = MarsIntervalCalc.CalculateInterval("15:10", "17:99", "12:99", "15:09");
            Assert.AreEqual("DISJOINT", result);
        }

        [TestMethod]
        public void TC_12()
        {
            var result = MarsIntervalCalc.CalculateInterval("15:10", "07:99", "12:99", "15:09");
            Assert.AreEqual("ERROR", result);
        }

    }
}
