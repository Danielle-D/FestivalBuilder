namespace FestivalGenerator.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestClass]
    public class FestivalTests
    {
        private Festival _festival;

        [SetUp]
        public void SetUp()
        {
            _festival = new Festival();
        }

        [Test]
        public void StartDayCalculator_ValidDate_ReturnsCorrectDayOfWeek()
        {
            var expectedResult = new DateTime(2094, 02, 02).DayOfWeek;

            var actualResult = _festival.StartDayCalculator(new DateTime(2094, 02, 02));

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EndDayCalculator_ValidDate_ReturnsCorrectEndDay()
        {
            var expectedResult = new DateTime(2094, 01, 03).DayOfWeek;

            var actualResult = _festival.EndDayCalculator(new DateTime(2094, 01, 01), 2); 

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EndDateCalculator_ValidDate_ReturnsCorrectEndDate()
        {
            var expectedResult = new DateTime(2094, 01, 03);

            var actualResult = _festival.EndDateCalculator(new DateTime(2094, 01, 01), 2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}