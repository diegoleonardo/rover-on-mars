namespace Rover.On.Mars.Core
{
    public class Rover
    {
        private readonly IContext _context;

        public Rover(IContext commandContext)
        {
            this._context = commandContext;
        }

        public void ExecuteCommand(CommandTypes command)
        {
            _context.ExecuteCommand(command);
        }

        public string CurrenPosition()
        {
            return $"{_context.GetPositionX()},{_context.GetPositionY()}";
        }

        public FacingTypes FacingTo()
        {
            return _context.GetCurrentFacing();
        }

        public string GetCoordinates()
        {
            return $"Rover is now at {CurrenPosition()} - facing {FacingTo()}";
        }
    }
}
