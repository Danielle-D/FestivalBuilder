using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FestivalGenerator;

namespace FestivalGenerator.Tests
{
    [TestClass]
    public class FestivalTests
    {
        [TestMethod]
        public void StartDayCalculator_ValidDate_ReturnsCorrectDayOfWeek()
        {
            //Arrange
            Festival festival = new Festival();
            var expectedResult = new DateTime(2094, 02, 02).DayOfWeek;
            //Act
            var actualResult = festival.StartDayCalculator(new DateTime(2094,02,02));

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EndDayCalculator_ValidDate_ReturnsCorrectEndDay()
        {
            //Arrange
            Festival festival = new Festival();
            var expectedResult = new DateTime(2094, 01, 03).DayOfWeek;
            //Act
            var actualResult = festival.EndDayCalculator(new DateTime(2094, 01, 01), 2); 

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EndDateCalculator_ValidDate_ReturnsCorrectEndDate()
        {
            //Arrange
            Festival festival = new Festival();
            var expectedResult = new DateTime(2094, 01, 03);
            //Act
            var actualResult = festival.EndDateCalculator(new DateTime(2094, 01, 01), 2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}