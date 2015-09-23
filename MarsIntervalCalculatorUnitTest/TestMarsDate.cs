using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsIntervalCalculator;

namespace MarsIntervalCalculatorUnitTest
{
    [TestClass]
    public class TestMarsDate
    {
        [TestMethod]
        public void Hour00_Minute00_Shall_be_valid_Date()
        {
            var date = MarsDate.Parse("00", "00");
            Assert.AreEqual(0, date.Hour);
            Assert.AreEqual(0, date.Minute);
        }

        [TestMethod]
        public void HourMinus3_Minute70_Shall_be_valid_Date()
        {
            var date = MarsDate.Parse("-3", "00");
            Assert.AreEqual(0, date.Hour);
            Assert.AreEqual(0, date.Minute);
        }
    }
}
