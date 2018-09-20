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
            var facing = new Facing(RoverFacing.North);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.West, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_south_when_rotate_to_left()
        {
            // ARRANGE
            var facing = new Facing(RoverFacing.West);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.South, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_east_when_rotate_to_left()
        {
            // ARRANGE
            var facing = new Facing(RoverFacing.South);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.East, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_north_when_rotate_to_left()
        {
            // ARRANGE
            var facing = new Facing(RoverFacing.East);

            // ACT
            facing.MoveToLeft();

            // ASSERT
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.North, facing.CurrentFacing);
        }
    }
}
