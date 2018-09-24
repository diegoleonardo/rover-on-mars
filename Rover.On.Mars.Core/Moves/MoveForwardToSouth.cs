namespace Rover.On.Mars.Core.Moves
{
    public class MoveForwardToSouth : IMoveForward
    {
        public void Move(RoverState state)
        {
            state.PositionX++;
        }
    }
}
