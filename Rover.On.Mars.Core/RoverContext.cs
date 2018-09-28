using Rover.On.Mars.Core.Commands;
using System.Collections.Generic;

namespace Rover.On.Mars.Core
{
    public class RoverContext : IContext
    {
        private readonly IDictionary<CommandTypes, IMoveCommand> _moviments = new Dictionary<CommandTypes, IMoveCommand>();
        private RoverState State { get; set; }

        public RoverContext(RoverState initialState)
        {
            State = initialState;
            _moviments.Add(CommandTypes.MOVE_FORWARD, new MoveForwardCommand());
            _moviments.Add(CommandTypes.ROTATE_TO_RIGHT, new RotateToRightCommand());
            _moviments.Add(CommandTypes.ROTATE_TO_LEFT, new RotateToLeftCommand());
        }

        public void ExecuteCommand(CommandTypes command)
        {
            _moviments[command].ExecuteCommand(this.State);
        }

        public int GetPositionX()
        {
            return State.PositionX;
        }

        public int GetPositionY()
        {
            return State.PositionY;
        }

        public FacingTypes GetCurrentFacing()
        {
            return State.CurrentFacing;
        }
    }
}
