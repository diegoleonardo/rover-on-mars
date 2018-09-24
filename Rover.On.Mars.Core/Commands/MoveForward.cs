using Rover.On.Mars.Core.Moves;
using System.Collections.Generic;

namespace Rover.On.Mars.Core.Commands
{
    public class MoveForward : IMoveCommandStrategy
    {
        private IDictionary<FacingTypes, IMoveForward> _movesStrategy = new Dictionary<FacingTypes, IMoveForward>();

        public MoveForward()
        {
            _movesStrategy.Add(FacingTypes.North, new MoveForwardToNorth());
            _movesStrategy.Add(FacingTypes.South, new MoveForwardToSouth());
            _movesStrategy.Add(FacingTypes.East, new MoveForwardToEast());
            _movesStrategy.Add(FacingTypes.West, new MoveForwardToWest());
        }

        public void Move(RoverState state)
        {
            if (state.Configuration.CanMove(state))
            {
                _movesStrategy[state.CurrentFacing].Move(state);
            }
        }
    }
}
