namespace MarsRover
{
    public class South : IDirection
    {
        public DirectionName Name { get; } = DirectionName.South;
        public IDirection TurnRight { get; set; }
        public IDirection TurnLeft { get; set; }

        public Square MoveForward(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareDown(currentSquare);
        }

        public Square MoveBackwards(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareUp(currentSquare);
        }
    }
}