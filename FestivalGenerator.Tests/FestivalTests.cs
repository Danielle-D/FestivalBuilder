using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FestivalGenerator.Tests
{
    [TestClass]
    public class FestivalTests
    {
        private Festival festival;

        [SetUp]
        public void SetUp()
        {
            this.festival = new Festival();
        }

        [Test]
        public void StartDayCalculator_ValidDate_ReturnsCorrectDayOfWeek()
        {
            var expectedResult = new DateTime(2094, 02, 02).DayOfWeek;

            var actualResult = festival.StartDayCalculator(new DateTime(2094,02,02));

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EndDayCalculator_ValidDate_ReturnsCorrectEndDay()
        {
            var expectedResult = new DateTime(2094, 01, 03).DayOfWeek;

            var actualResult = festival.EndDayCalculator(new DateTime(2094, 01, 01), 2); 

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EndDateCalculator_ValidDate_ReturnsCorrectEndDate()
        {
            var expectedResult = new DateTime(2094, 01, 03);

            var actualResult = festival.EndDateCalculator(new DateTime(2094, 01, 01), 2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}