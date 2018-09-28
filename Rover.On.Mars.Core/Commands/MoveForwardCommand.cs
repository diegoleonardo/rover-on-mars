using Rover.On.Mars.Core.Moves;
using System.Collections.Generic;

namespace Rover.On.Mars.Core.Commands
{
    public class MoveForwardCommand : IMoveCommand
    {
        private IDictionary<FacingTypes, IMoveForward> _movesStrategy = new Dictionary<FacingTypes, IMoveForward>();
        private const int MIN_POSITION = 0;
        private const int MAX_POSITION = 4;

        private bool CanMove(RoverState state)
        {
            switch (state.CurrentFacing)
            {
                case FacingTypes.North:
                    return state.PositionX > MIN_POSITION;
                case FacingTypes.West:
                    return state.PositionY > MIN_POSITION;
                case FacingTypes.East:
                    return state.PositionY < MAX_POSITION;
                case FacingTypes.South:
                    return state.PositionX < MAX_POSITION;
                default:
                    return true;
            }
        }

        public MoveForwardCommand()
        {
            _movesStrategy.Add(FacingTypes.North, new MoveForwardToNorth());
            _movesStrategy.Add(FacingTypes.South, new MoveForwardToSouth());
            _movesStrategy.Add(FacingTypes.East, new MoveForwardToEast());
            _movesStrategy.Add(FacingTypes.West, new MoveForwardToWest());
        }

        public void ExecuteCommand(RoverState state)
        {
            if (CanMove(state))
            {
                _movesStrategy[state.CurrentFacing].Move(state);
            }
        }
    }
}
