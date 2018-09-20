using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverRotateToRightTest
    {
        [TestMethod]
        public void Should_change_facing_to_east_when_rotate_to_right()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.North);

            // WHEN
            facing.MoveToRight();

            // THEN 
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.East, facing.CurrentFacing);
        }

        [TestMethod]
        public void Should_change_facing_to_south_when_rotate_to_right()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.East);

            // WHEN
            facing.MoveToRight();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.South, facing.CurrentFacing);
        }

        [TestMethod]
        public void Should_change_facing_to_west_when_rotate_to_right()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.South);

            // WHEN
            facing.MoveToRight();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.West, facing.CurrentFacing);
        }

        [TestMethod]
        public void Should_change_facing_to_north_rotate_to_right()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.West);

            // WHEN 
            facing.MoveToRight();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.North, facing.CurrentFacing);
        }
    }
}
