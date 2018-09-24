namespace Rover.On.Mars.Core.Commands
{
    public interface IMoveCommandStrategy
    {
        void Move(RoverState state);
    }
}
