namespace Rover.On.Mars.Core
{
    public class RoverFacing
    {
        public FacingTypes CurrentFacing { get; private set; }
        private void ChangeCurrentFacing(FacingTypes facingTo)
        {
            CurrentFacing = facingTo;
        }
        public RoverFacing(FacingTypes roverFacing)
        {
            ChangeCurrentFacing(roverFacing);
        }
        public void MoveToLeft()
        {
            switch (CurrentFacing)
            {
                case FacingTypes.North:
                    ChangeCurrentFacing(FacingTypes.West);
                    break;
                case FacingTypes.West:
                    ChangeCurrentFacing(FacingTypes.South);
                    break;
                case FacingTypes.South:
                    ChangeCurrentFacing(FacingTypes.East);
                    break;
                case FacingTypes.East:
                    ChangeCurrentFacing(FacingTypes.North);
                    break;
            }
        }
        public void MoveToRight()
        {
            switch (CurrentFacing)
            {
                case FacingTypes.North:
                    ChangeCurrentFacing(FacingTypes.East);
                    break;
                case FacingTypes.East:
                    ChangeCurrentFacing(FacingTypes.South);
                    break;
                case FacingTypes.South:
                    ChangeCurrentFacing(FacingTypes.West);
                    break;
                case FacingTypes.West:
                    ChangeCurrentFacing(FacingTypes.North);
                    break;
            }
        }
    }
}
