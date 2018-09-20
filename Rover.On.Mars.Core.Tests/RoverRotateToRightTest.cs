using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverRotateToRightTest
    {
        [TestMethod]
        public void Must_be_changed_facing_to_east_when_rotate_to_right()
        {
            // GIVEN
            var facing = new Facing(RoverFacing.North);

            // WHEN
            facing.MoveToRight();

            // THEN 
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.East, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_south_when_rotate_to_right()
        {
            // GIVEN
            var facing = new Facing(RoverFacing.East);

            // WHEN
            facing.MoveToRight();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.South, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_west_when_rotate_to_right()
        {
            // GIVEN
            var facing = new Facing(RoverFacing.South);

            // WHEN
            facing.MoveToRight();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.West, facing.CurrentFacing);
        }

        [TestMethod]
        public void Must_be_changed_facing_to_north_rotate_to_right()
        {
            // GIVEN
            var facing = new Facing(RoverFacing.West);

            // WHEN 
            facing.MoveToRight();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(RoverFacing.North, facing.CurrentFacing);
        }
    }
}
