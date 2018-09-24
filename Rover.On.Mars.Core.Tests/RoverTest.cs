using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverTest
    {
        private Rover GenerateRover(int positionX, int positionY, FacingTypes facingTo)
        {
            var roverInitialconfiguration = new RoverConfiguration();
            var roverInitialState = new RoverState(positionX, positionY, facingTo, roverInitialconfiguration);

            return new Rover(roverInitialState);
        }

        [TestMethod]
        public void Should_move_forward()
        {
            // GIVEN
            var rover = GenerateRover(1, 1, FacingTypes.North);

            // WHEN
            rover.ExecuteCommand(CommandTypes.MOVE_FORWARD);

            // THEN
            Assert.AreEqual("0,1", rover.CurrenPosition());
        }

        [TestMethod]
        public void Should_show_the_rover_position_when_get_current_rover_position()
        {
            // GIVEN
            var rover = GenerateRover(1, 1, FacingTypes.North);

            // WHEN
            var currentPosition = rover.CurrenPosition();

            // THEN
            Assert.AreEqual($"1,1", currentPosition);
        }

        [TestMethod]
        public void Shoud_not_possible_change_rover_position_when_facing_to_west_and_positions_equals_zero()
        {
            // GIVEN
            var rover = GenerateRover(0, 0, FacingTypes.West);

            // WHEN
            rover.ExecuteCommand(CommandTypes.MOVE_FORWARD);
            var currentPosition = rover.CurrenPosition();

            // THEN
            Assert.AreEqual("0,0", currentPosition);
        }

        [TestMethod]
        public void Should_rotate_to_left_and_change_facing_from_north_to_west()
        {
            // GIVEN
            var rover = GenerateRover(0, 1, FacingTypes.North);

            // WHEN
            rover.ExecuteCommand(CommandTypes.ROTATE_TO_LEFT);

            // THEN
            Assert.AreEqual(FacingTypes.West, rover.FacingTo());
        }

        [TestMethod]
        public void Should_rotate_to_right_and_change_facing_from_north_to_east()
        {
            // GIVEN
            var rover = GenerateRover(0, 0, FacingTypes.North);

            // WHEN
            rover.ExecuteCommand(CommandTypes.ROTATE_TO_RIGHT);

            // THEN
            Assert.AreEqual(FacingTypes.East, rover.FacingTo());
        }
    }
}
