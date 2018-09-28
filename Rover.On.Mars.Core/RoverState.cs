namespace Rover.On.Mars.Core
{
    public class RoverState
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public FacingTypes CurrentFacing { get; set; }

        public RoverState(int positionX, int positionY, FacingTypes facingTo)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.CurrentFacing = facingTo;
        }
    }
}
