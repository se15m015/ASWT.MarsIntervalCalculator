using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsIntervalCalculator;

namespace MarsIntervalCalculatorUnitTest
{

    [TestClass]
    [Ignore]
    public class ThomasTest
    {
        [TestMethod]
        public void TC_1()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "23:00", "02:00", "05:00");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void TC_2()
        {
            var result = MarsIntervalCalc.CalculateInterval("04:00", "06:00", "04:00", "05:00");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void TC_3()
        {
            var result = MarsIntervalCalc.CalculateInterval("03:00", "23:00", "04:00", "23:00");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void TC_4()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:00", "15:00", "15:00", "23:00");
            Assert.AreEqual("TOUCH", result);
        }

        [TestMethod]
        public void TC_5()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:00", "15:00", "04:00", "10:00");
            Assert.AreEqual("TOUCH", result);
        }

        [TestMethod]
        public void TC_6()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:00", "15:00", "14:99", "23:00");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void TC_7()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:00", "14:30", "08:00", "10:01");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void TC_8()
        {
            var result = MarsIntervalCalc.CalculateInterval("10:00", "14:30", "08:00", "10:01");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void TC_9()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "23:100", "2:00", "5:00");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_10()
        {
            var result = MarsIntervalCalc.CalculateInterval("25:00", "23:00", "4:00", "23:00");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_11()
        {
            var result = MarsIntervalCalc.CalculateInterval("-10:00", "23:00", "4:00", "23:00");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_12()
        {
            var result = MarsIntervalCalc.CalculateInterval("12:00", "12:00", "12:00", "12:00");
            Assert.AreEqual("TOUCH", result);
        }

    }
}
