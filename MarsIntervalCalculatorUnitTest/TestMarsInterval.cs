using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsIntervalCalculator;

namespace MarsIntervalCalculatorUnitTest
{
    [TestClass]
    public class TestMarsInterval
    {
        [TestMethod]
        public void Negative_Hour_in_Date_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("-02:80", "20:44", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void Hour_25_in_Date_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("01:01", "25:44", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void Minute_100_in_Date_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("01:100", "25:44", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }

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
        public void Intervals_shall_be_OVERLAP_1()
        {
            var result = MarsIntervalCalc.CalculateInterval("02:80", "20:44", "20:43", "20:45");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void Intervals_shall_be_OVERLAP_2()
        {
            var result = MarsIntervalCalc.CalculateInterval("12:23", "14:03", "12:24", "14:04");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void Intervals_shall_be_TOUCH_1()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "10:30", "10:30", "24:44");
            Assert.AreEqual("TOUCH", result);
        }

        [TestMethod]
        public void Intervals_shall_be_DISJOINT_1_FarAway()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "00:01", "24:98", "24:99");
            Assert.AreEqual("DISJOINT", result);
        }

        [TestMethod]
        public void Intervals_shall_be_DISJOINT_2_Close()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "12:30", "12:31", "24:99");
            Assert.AreEqual("DISJOINT", result);
        }

        [TestMethod]
        public void Intervals_four_times_same_date_shall_be_TOUCH()
        {
            var result = MarsIntervalCalc.CalculateInterval("12:00", "12:00", "12:00", "12:00");
            Assert.AreEqual("TOUCH", result);
        }

    }
}
