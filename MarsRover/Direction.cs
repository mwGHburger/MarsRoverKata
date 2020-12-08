namespace MarsRover
{
    public class Direction
    {
        public DirectionName Name { get; }
        public Direction Next { get; set; }
        public Direction(DirectionName name)
        {
            Name = name;
        }

    }
}