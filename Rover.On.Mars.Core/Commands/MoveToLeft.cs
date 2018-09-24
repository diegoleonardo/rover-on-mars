using Rover.On.Mars.Core.Rotates;
using Rover.On.Mars.Core.Rotates.Left;
using System.Collections.Generic;

namespace Rover.On.Mars.Core.Commands
{
    public class MoveToLeft : IMoveCommandStrategy
    {
        private IDictionary<FacingTypes, IRotate> _rotatesToLeft = new Dictionary<FacingTypes, IRotate>();

        public MoveToLeft()
        {
            _rotatesToLeft.Add(FacingTypes.North, new RotateToLeftFromNorth());
            _rotatesToLeft.Add(FacingTypes.South, new RotateToLeftFromSouth());
            _rotatesToLeft.Add(FacingTypes.East, new RotateToLeftFromEast());
            _rotatesToLeft.Add(FacingTypes.West, new RotateToLeftFromWest());
        }

        public void Move(RoverState state)
        {
            state.CurrentFacing = _rotatesToLeft[state.CurrentFacing].Rotate();
        }
    }
}
