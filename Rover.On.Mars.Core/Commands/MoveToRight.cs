using Rover.On.Mars.Core.Rotates;
using Rover.On.Mars.Core.Rotates.Right;
using System.Collections.Generic;

namespace Rover.On.Mars.Core.Commands
{
    public class MoveToRight : IMoveCommandStrategy
    {
        private IDictionary<FacingTypes, IRotate> _rotatesToRight = new Dictionary<FacingTypes, IRotate>();

        public MoveToRight()
        {
            _rotatesToRight.Add(FacingTypes.North, new RotateToRightFromNorth());
            _rotatesToRight.Add(FacingTypes.South, new RotateToRightFromSouth());
            _rotatesToRight.Add(FacingTypes.East, new RotateToRightFromEast());
            _rotatesToRight.Add(FacingTypes.West, new RotateToRightFromWest());
        }

        public void Move(RoverState state)
        {
            state.CurrentFacing = _rotatesToRight[state.CurrentFacing].Rotate();
        }
    }
}
