namespace Rover.On.Mars.Core.Commands
{
    public interface IMoveCommand
    {
        void ExecuteCommand(RoverState state);
    }
}
