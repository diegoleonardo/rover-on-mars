namespace Rover.On.Mars.Core
{
    public class RoverConfiguration
    {
        private const int MIN_POSITION = 0;
        private const int MAX_POSITION = 4;

        public bool CanMove(RoverState state)
        {
            switch (state.CurrentFacing)
            {
                case FacingTypes.North:
                    return state.PositionX > MIN_POSITION;
                case FacingTypes.West:
                    return state.PositionY > MIN_POSITION;
                case FacingTypes.East:
                    return state.PositionY < MAX_POSITION;
                case FacingTypes.South:
                    return state.PositionX < MAX_POSITION;
                default:
                    return true;
            }
        }
    }
}
