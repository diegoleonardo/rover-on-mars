namespace Rover.On.Mars.Core
{
    public class RoverConfiguration
    {
        private const int MIN_POSITION = 0;
        private const int MAX_POSITION = 4;

        public bool CanMove(FacingTypes facing, RoverPosition position)
        {
            switch (facing)
            {
                case FacingTypes.North:
                    return position.PositionX > MIN_POSITION;
                case FacingTypes.West:
                    return position.PositionY > MIN_POSITION;
                case FacingTypes.East:
                    return position.PositionY < MAX_POSITION;
                case FacingTypes.South:
                    return position.PositionX < MAX_POSITION;
                default:
                    return true;
            }
        }
    }
}
