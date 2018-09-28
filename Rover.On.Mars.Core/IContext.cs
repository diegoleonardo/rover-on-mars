namespace Rover.On.Mars.Core
{
    public interface IContext
    {
        void ExecuteCommand(CommandTypes command);
        int GetPositionX();
        int GetPositionY();
        FacingTypes GetCurrentFacing();
    }
}
