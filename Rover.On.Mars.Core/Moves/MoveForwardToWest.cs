namespace Rover.On.Mars.Core.Moves
{
    public class MoveForwardToWest : IMoveForward
    {
        public void Move(RoverState state)
        {
            state.PositionY--;
        }
    }
}
