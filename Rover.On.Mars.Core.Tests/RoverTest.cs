using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverTest
    {
        private Rover GenerateRover(int positionX, int positionY, FacingTypes facing)
        {
            return new Rover(positionX, positionY, facing);
        }

        [TestMethod]
        public void Should_move_forward()
        {
            // GIVEN
            var rover = GenerateRover(1, 1, FacingTypes.North);

            // WHEN
            rover.MoveForward();

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
            rover.MoveForward();
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
            rover.Rotate("L");

            // THEN
            Assert.AreEqual(FacingTypes.West, rover.FacingTo());
        }

        [TestMethod]
        public void Should_rotate_to_right_and_change_facing_from_north_to_east()
        {
            // GIVEN
            var rover = GenerateRover(0, 0, FacingTypes.North);

            // WHEN
            rover.Rotate("R");

            // THEN
            Assert.AreEqual(FacingTypes.East, rover.FacingTo());
        }
    }
}
