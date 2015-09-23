using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsIntervalCalculator;

namespace MarsIntervalCalculatorUnitTest
{
    [TestClass]
    [Ignore]
    public class MarsDateTest
    {
        public void Hour00_Minute00_Shall_be_valid_Date()
        {
            var date = MarsDate.Parse("00", "00");
            Assert.AreEqual(0, date.Hour);
            Assert.AreEqual(0, date.Minute);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HourMinus1_Minute70_Shall_be_an_invalid_Date()
        {
            var date = MarsDate.Parse("-1", "00");
            Assert.AreEqual(0, date.Hour);
            Assert.AreEqual(0, date.Minute);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Hour24_Minute100_Shall_be_an_invalid_Date()
        {
            var date = MarsDate.Parse("24", "100");
            Assert.AreEqual(0, date.Hour);
            Assert.AreEqual(0, date.Minute);
        }
    }
}
