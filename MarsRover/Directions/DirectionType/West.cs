namespace MarsRover
{
    public class West : IDirection
    {
        public DirectionName Name { get; } = DirectionName.West;
        public IDirection TurnRight { get; set; }
        public IDirection TurnLeft { get; set; }

        public Square MoveForward(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareLeft(currentSquare);
        }

        public Square MoveBackwards(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareRight(currentSquare);
        }
    }
}