using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.On.Mars.Core.Tests
{
    [TestClass]
    public class RoverRotateToLeftTest
    {
        [TestMethod]
        public void Should_change_facing_to_west_when_rotate_to_left()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.North);

            // WHEN
            facing.MoveToLeft();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.West, facing.CurrentFacing);
        }

        [TestMethod]
        public void Should_change_facing_to_south_when_rotate_to_left()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.West);

            // WHEN
            facing.MoveToLeft();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.South, facing.CurrentFacing);
        }

        [TestMethod]
        public void Should_change_facing_to_east_when_rotate_to_left()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.South);

            // WHEN
            facing.MoveToLeft();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.East, facing.CurrentFacing);
        }

        [TestMethod]
        public void Should_change_facing_to_north_when_rotate_to_left()
        {
            // GIVEN
            var facing = new RoverFacing(FacingTypes.East);

            // WHEN
            facing.MoveToLeft();

            // THEN
            Assert.IsNotNull(facing);
            Assert.AreEqual(FacingTypes.North, facing.CurrentFacing);
        }
    }
}
