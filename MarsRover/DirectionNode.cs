namespace MarsRover
{
    public class DirectionNode
    {
        public DirectionName Name { get; }
        public DirectionNode NextClockwiseDirection { get; set; }
        public DirectionNode NextAntiClockwiseDirection { get; set; }
        public DirectionNode(DirectionName name)
        {
            Name = name;
        }

    }
}