namespace Rover.On.Mars.Core
{
    public class Rover
    {
        private RoverPosition Position { get; set; }
        private RoverFacing Facing { get; set; }
        private RoverConfiguration Configuration { get; set; }

        private void MoveForward()
        {
            if (Configuration.CanMove(Facing.CurrentFacing, Position))
            {
                Position.ChangePosition(Facing.CurrentFacing);
            }
        }

        private void Rotate(CommandTypes direction)
        {
            if (direction.Equals(CommandTypes.ROTATE_TO_RIGHT))
                Facing.MoveToRight();
            else
                Facing.MoveToLeft();
        }

        public Rover(RoverPosition initalPosition, RoverFacing initialFacing, RoverConfiguration configuration)
        {
            Position = initalPosition;
            Facing = initialFacing;
            Configuration = configuration;
        }

        public void ExecuteCommand(CommandTypes command)
        {
            if(command.Equals(CommandTypes.MOVE_FORWARD))
            {
                MoveForward();
            }
            else
            {
                Rotate(command);
            }
        }

        public string CurrenPosition()
        {
            return $"{Position.PositionX},{Position.PositionY}";
        }

        public FacingTypes FacingTo()
        {
            return Facing.CurrentFacing;
        }

        public string GetCoordinates()
        {
            return $"Rover is now at {CurrenPosition()} - facing {FacingTo()}";
        }
    }
}
