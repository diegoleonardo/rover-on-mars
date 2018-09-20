namespace Rover.On.Mars.Core
{
    public class Rover
    {
        private const int MIN_POSITION = 0;
        private const int MAX_POSITION = 4;
        private RoverPosition Position { get; set; }
        private RoverFacing Facing { get; set; }

        private bool CanMove(FacingTypes facing)
        {
            switch (facing)
            {
                case FacingTypes.North:
                    return this.Position.PositionX > MIN_POSITION;
                case FacingTypes.West:
                    return this.Position.PositionY > MIN_POSITION;
                case FacingTypes.East:
                    return this.Position.PositionY < MAX_POSITION;
                case FacingTypes.South:
                    return this.Position.PositionX < MAX_POSITION;
                default:
                    return true;
            }
        }

        public Rover(int positionX, int positionY, FacingTypes facing)
        {
            var posX = positionX > MIN_POSITION ? positionX : MIN_POSITION;
            var posY = positionY < MAX_POSITION ? positionY : MAX_POSITION;
            this.Position = new RoverPosition(posX, posY);
            this.Facing = new RoverFacing(facing);
        }

        public void MoveForward()
        {
            if (CanMove(this.Facing.CurrentFacing))
            {
                this.Position.ChangePosition(this.Facing.CurrentFacing);
            }
        }

        public void Rotate(string direction)
        {
            if (direction.Equals("L"))
                this.Facing.MoveToLeft();
            else
                this.Facing.MoveToRight();
        }

        public string CurrenPosition()
        {
            return $"{this.Position.PositionX},{this.Position.PositionY}";
        }

        public FacingTypes FacingTo()
        {
            return this.Facing.CurrentFacing;
        }

        public string GetCoordinates()
        {
            return $"Rover is now at {CurrenPosition()} - facing {FacingTo()}";
        }
    }
}
