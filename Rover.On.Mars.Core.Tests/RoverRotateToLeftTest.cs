using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverRotateToLeftTest
    {
        [TestMethod]
        public void Must_be_changed_facing_to_west_when_rotate_to_left()
        {
            // ARRANGE
            var facing = new RoverFacing(FacingTypes.North);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.West, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_south_when_rotate_to_left()
        {
            // ARRANGE
            var facing = new RoverFacing(FacingTypes.West);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.South, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_east_when_rotate_to_left()
        {
            // ARRANGE
            var facing = new RoverFacing(FacingTypes.South);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.East, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_north_when_rotate_to_left()
        {
            // ARRANGE
            var facing = new RoverFacing(FacingTypes.East);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.North, facing.CurrentFacing);
        }
    }
}
