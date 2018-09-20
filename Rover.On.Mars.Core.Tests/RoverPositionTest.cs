using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverPositionTest
    {
        private RoverPosition GenerateRoverPosition(int positionX, int positionY)
        {
            return new RoverPosition(positionX, positionY);
        }

        [TestMethod]
        public void Must_be_will_increment_positionX()
        {
            // GIVEN 
            var position = GenerateRoverPosition(1, 1);

            // WHEN
            position.ChangePosition(FacingTypes.South);

            // THEN
            Assert.AreEqual(1, position.PositionY);
            Assert.AreNotEqual(1, position.PositionX);
            Assert.AreEqual(2, position.PositionX);
        }

        [TestMethod]
        public void Must_be_will_increment_positionY()
        {
            // GIVEN
            var position = GenerateRoverPosition(0, 3);

            // WHEN
            position.ChangePosition(FacingTypes.East);

            // THEN
            Assert.AreEqual(0, position.PositionX);
            Assert.AreNotEqual(3, position.PositionY);
            Assert.AreEqual(4, position.PositionY);
        }

        [TestMethod]
        public void Must_be_decremented_positionX()
        {
            // GIVEN
            var xAxis = 1;
            var yAxis = 1;
            var position = new RoverPosition(xAxis, yAxis);

            // WHEN
            position.ChangePosition(FacingTypes.North);

            // THEN
            Assert.AreEqual(yAxis, position.PositionY);
            Assert.AreNotEqual(xAxis, position.PositionX);
            Assert.AreEqual((xAxis - 1), position.PositionX);
        }

        [TestMethod]
        public void Must_be_decremented_positionY()
        {
            // GIVEN
            var xAxis = 0;
            var yAxis = 10;
            var position = new RoverPosition(xAxis, yAxis);

            // WHEN
            position.ChangePosition(FacingTypes.West);

            // THEN
            Assert.AreEqual(xAxis, position.PositionX);
            Assert.AreNotEqual(yAxis, position.PositionY);
            Assert.AreEqual((yAxis - 1), position.PositionY);
        }
    }
}
