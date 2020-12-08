namespace MarsRover
{
    public class DirectionNode
    {
        // TODO: Delete
        public DirectionName Name { get; }
        public DirectionNode TurnRight { get; set; }
        public DirectionNode TurnLeft { get; set; }
        public DirectionNode(DirectionName name)
        {
            Name = name;
        }
        
    }
}