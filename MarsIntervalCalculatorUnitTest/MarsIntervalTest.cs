using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsIntervalCalculator;

namespace MarsIntervalCalculatorUnitTest
{
    [TestClass]
    public class MarsIntervalTest
    {
        [TestMethod]
        public void TC_1_Negative_Hour_in_Date_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("-02:80", "20:44", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_2_Hour_25_in_Date_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("01:01", "25:44", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_3_Minute_100_in_Date_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("01:100", "25:44", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_4_DateStart_after_DateEnd_shall_be_ERROR()
        {
            var result = MarsIntervalCalc.CalculateInterval("15:01", "13:04", "05:01", "05:02");
            Assert.AreEqual("ERROR", result);
        }

        [TestMethod]
        public void TC_5_Intervals_shall_be_NESTED_1_wide()
        {
            var result = MarsIntervalCalc.CalculateInterval("01:20", "24:99", "01:21", "24:98");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void TC_6_Intervals_shall_be_NESTED_2_close()
        {
            var result = MarsIntervalCalc.CalculateInterval("13:45", "13:46", "13:45", "13:46");
            Assert.AreEqual("NESTED", result);
        }

        [TestMethod]
        public void TC_7_Intervals_shall_be_OVERLAP_1_close()
        {
            var result = MarsIntervalCalc.CalculateInterval("02:80", "20:44", "20:43", "20:45");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void TC_8_Intervals_shall_be_OVERLAP_2_wide()
        {
            var result = MarsIntervalCalc.CalculateInterval("12:23", "14:03", "12:24", "14:04");
            Assert.AreEqual("OVERLAP", result);
        }

        [TestMethod]
        public void TC_9_Intervals_shall_be_TOUCH_1()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "10:30", "10:30", "24:44");
            Assert.AreEqual("TOUCH", result);
        }

        [TestMethod]
        public void TC_10_Intervals_shall_be_DISJOINT_1_FarAway()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "00:01", "24:98", "24:99");
            Assert.AreEqual("DISJOINT", result);
        }

        [TestMethod]
        public void TC_11_Intervals_shall_be_DISJOINT_2_Close()
        {
            var result = MarsIntervalCalc.CalculateInterval("00:00", "12:30", "12:31", "24:99");
            Assert.AreEqual("DISJOINT", result);
        }

        [TestMethod]
        public void TC_12_Intervals_four_times_same_date_shall_be_TOUCH()
        {
            var result = MarsIntervalCalc.CalculateInterval("12:00", "12:00", "12:00", "12:00");
            Assert.AreEqual("TOUCH", result);
        }

    }
}
