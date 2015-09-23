using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsIntervalCalculator;

namespace MarsIntervalCalculatorUnitTest
{
    [TestClass]
    public class TestMarsInterval
    {
        [TestMethod]
        public void Intervals_shall_be_NESTED_1()
        {
            var result = MarsIntervalCalc.CalculateInterval("01:20", "24:99", "01:21", "24:98");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void Intervals_shall_be_NESTED_2()
        {
            var result = MarsIntervalCalc.CalculateInterval("13:45", "13:46", "13:45", "13:46");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void Intervals_shall_be_NESTED_3()
        {
            var result = MarsIntervalCalc.CalculateInterval("02:80", "20:44", "05:01", "05:02");
            Assert.AreEqual("NESTED", result);
        }
        [TestMethod]
        public void Negative_Hour_in_Date_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("-02:80", "20:44", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }
    }
}
