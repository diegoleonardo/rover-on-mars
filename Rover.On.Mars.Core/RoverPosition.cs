namespace Rover.On.Mars.Core
{
    public class RoverPosition
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public RoverPosition(int positionX, int positionY)
        {
            PositionX = positionX > 0 ? positionX : 0;
            PositionY = positionY > 0 ? positionY : 0;
        }

        public void ChangePosition(RoverFacing facing)
        {
            switch (facing)
            {
                case RoverFacing.East:
                    PositionY++;
                    break;
                case RoverFacing.South:
                    PositionX++;
                    break;
                case RoverFacing.West:
                    PositionY--;
                    break;
                case RoverFacing.North:
                    PositionX--;
                    break;
            }
        }
    }
}
