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
        public void Should_increase_positionX_when_change_position_and_facing_to_south()
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
        public void Should_increase_positionY_when_change_position_and_facing_to_east()
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
        public void Should_decrease_positionX_when_change_position_and_facing_to_north()
        {
            // GIVEN
            var positionX = 1;
            var positionY = 1;
            var position = new RoverPosition(positionX, positionY);

            // WHEN
            position.ChangePosition(FacingTypes.North);

            // THEN
            Assert.AreEqual(positionY, position.PositionY);
            Assert.AreNotEqual(positionX, position.PositionX);
            Assert.AreEqual((positionX - 1), position.PositionX);
        }

        [TestMethod]
        public void Should_decrease_positionY_when_change_position_and_facing_to_west()
        {
            // GIVEN
            var positionX = 0;
            var positionY = 10;
            var position = new RoverPosition(positionX, positionY);

            // WHEN
            position.ChangePosition(FacingTypes.West);

            // THEN
            Assert.AreEqual(positionX, position.PositionX);
            Assert.AreNotEqual(positionY, position.PositionY);
            Assert.AreEqual((positionY - 1), position.PositionY);
        }
    }
}
