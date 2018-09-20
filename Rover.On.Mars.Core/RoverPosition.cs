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

        public void ChangePosition(FacingTypes facing)
        {
            switch (facing)
            {
                case FacingTypes.East:
                    PositionY++;
                    break;
                case FacingTypes.South:
                    PositionX++;
                    break;
                case FacingTypes.West:
                    PositionY--;
                    break;
                case FacingTypes.North:
                    PositionX--;
                    break;
            }
        }
    }
}
