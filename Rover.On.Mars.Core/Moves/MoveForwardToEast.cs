namespace Rover.On.Mars.Core.Moves
{
    public class MoveForwardToEast : IMoveForward
    {
        public void Move(RoverState state)
        {
            state.PositionY++;
        }
    }
}
