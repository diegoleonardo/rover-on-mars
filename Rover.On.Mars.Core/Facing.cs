namespace Rover.On.Mars.Core
{
    public class Facing
    {
        public RoverFacing CurrentFacing { get; private set; }
        private void ChangeCurrentFacing(RoverFacing facingTo)
        {
            CurrentFacing = facingTo;
        }
        public Facing(RoverFacing roverFacing)
        {
            ChangeCurrentFacing(roverFacing);
        }
        public void MoveToLeft()
        {
            switch (CurrentFacing)
            {
                case RoverFacing.North:
                    ChangeCurrentFacing(RoverFacing.West);
                    break;
                case RoverFacing.West:
                    ChangeCurrentFacing(RoverFacing.South);
                    break;
                case RoverFacing.South:
                    ChangeCurrentFacing(RoverFacing.East);
                    break;
                case RoverFacing.East:
                    ChangeCurrentFacing(RoverFacing.North);
                    break;
            }
        }
        public void MoveToRight()
        {
            switch (CurrentFacing)
            {
                case RoverFacing.North:
                    ChangeCurrentFacing(RoverFacing.East);
                    break;
                case RoverFacing.East:
                    ChangeCurrentFacing(RoverFacing.South);
                    break;
                case RoverFacing.South:
                    ChangeCurrentFacing(RoverFacing.West);
                    break;
                case RoverFacing.West:
                    ChangeCurrentFacing(RoverFacing.North);
                    break;
            }
        }
    }
}
