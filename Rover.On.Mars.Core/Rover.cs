using Rover.On.Mars.Core.Commands;
using System.Collections.Generic;

namespace Rover.On.Mars.Core
{
    public class Rover
    {
        private RoverState State { get; set; }
        private IDictionary<CommandTypes, IMoveCommandStrategy> _strategies = new Dictionary<CommandTypes, IMoveCommandStrategy>();

        public Rover(RoverState initialState)
        {
            this.State = initialState;
            _strategies.Add(CommandTypes.MOVE_FORWARD, new MoveForward());
            _strategies.Add(CommandTypes.ROTATE_TO_RIGHT, new MoveToRight());
            _strategies.Add(CommandTypes.ROTATE_TO_LEFT, new MoveToLeft());
        }

        public void ExecuteCommand(CommandTypes command)
        {
            _strategies[command].Move(this.State);
        }

        public string CurrenPosition()
        {
            return $"{State.PositionX},{State.PositionY}";
        }

        public FacingTypes FacingTo()
        {
            return State.CurrentFacing;
        }

        public string GetCoordinates()
        {
            return $"Rover is now at {CurrenPosition()} - facing {FacingTo()}";
        }
    }
}
