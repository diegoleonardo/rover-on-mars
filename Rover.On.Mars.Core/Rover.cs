namespace Rover.On.Mars.Core
{
    public class Rover
    {
        private const int MAX_POSITION_X = 0;
        private const int MAX_POSITION_Y = 4;
        private RoverPosition Position { get; set; }
        private Facing Facing { get; set; }

        private bool CanMove(RoverFacing facing)
        {
            switch (facing)
            {
                case RoverFacing.North:
                    return this.Position.PositionX > 0;
                case RoverFacing.West:
                    return this.Position.PositionY > 0;
                case RoverFacing.East:
                    return this.Position.PositionY < 5;
                case RoverFacing.South:
                    return this.Position.PositionX < 5;
                default:
                    return true;
            }
        }

        public Rover(int positionX, int positionY, RoverFacing facing)
        {
            var posX = positionX > MAX_POSITION_X ? positionX : MAX_POSITION_X;
            var posY = positionY < MAX_POSITION_Y ? positionY : MAX_POSITION_Y;
            this.Position = new RoverPosition(posX, posY);
            this.Facing = new Facing(facing);
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

        public RoverFacing FacingTo()
        {
            return this.Facing.CurrentFacing;
        }
    }
}
