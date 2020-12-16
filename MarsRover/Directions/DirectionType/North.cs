namespace MarsRover
{
    public class North : IDirection
    {
        public DirectionName Name { get; } = DirectionName.North;
        public IDirection TurnRight { get; set; }
        public IDirection TurnLeft { get; set; }

        public Square MoveForward(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareUp(currentSquare);
        }

        public Square MoveBackwards(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareDown(currentSquare);
        }
    }
}