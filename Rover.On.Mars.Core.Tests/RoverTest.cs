using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverTest
    {
        private Rover GenerateRover(int positionX, int positionY, RoverFacing facing)
        {
            return new Rover(positionX, positionY, facing);
        }

        [TestMethod]
        public void Must_be_move_forward()
        {
            // GIVEN
            var rover = GenerateRover(1, 1, RoverFacing.North);

            // WHEN
            rover.MoveForward();

            // THEN
            Assert.AreEqual("0,1", rover.CurrenPosition());
        }

        [TestMethod]
        public void Must_be_possible_seeing_rover_position()
        {
            // GIVEN
            var rover = GenerateRover(1, 1, RoverFacing.North);

            // WHEN
            var currentPosition = rover.CurrenPosition();

            // THEN
            Assert.AreEqual($"1,1", currentPosition);
        }

        [TestMethod]
        public void Must_be_not_possible_move_rover_outside_confines_of_the_grid()
        {
            // GIVEN
            var rover = GenerateRover(0, 0, RoverFacing.West);

            // WHEN
            rover.MoveForward();
            var currentPosition = rover.CurrenPosition();

            // THEN
            Assert.AreEqual("0,0", currentPosition);
        }

        [TestMethod]
        public void Must_be_rotated_from_north_to_west_with_rotate_to_left()
        {
            // GIVEN
            var rover = GenerateRover(0, 1, RoverFacing.North);

            // WHEN
            rover.Rotate("L");

            // THEN
            Assert.AreEqual(RoverFacing.West, rover.FacingTo());
        }

        [TestMethod]
        public void Must_be_rotated_from_north_to_east_with_rotate_to_right()
        {
            // GIVEN
            var rover = GenerateRover(0, 0, RoverFacing.North);

            // WHEN
            rover.Rotate("R");

            // THEN
            Assert.AreEqual(RoverFacing.East, rover.FacingTo());
        }
    }
}
