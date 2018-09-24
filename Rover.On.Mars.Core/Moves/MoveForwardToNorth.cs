namespace Rover.On.Mars.Core.Moves
{
    public class MoveForwardToNorth : IMoveForward
    {
        public void Move(RoverState state)
        {
            state.PositionX--;
        }
    }
}
