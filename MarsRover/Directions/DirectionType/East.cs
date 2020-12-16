namespace MarsRover
{
    public class East : IDirection
    {
        public DirectionName Name { get; } = DirectionName.East;
        public IDirection TurnRight { get; set; }
        public IDirection TurnLeft { get; set; }

        public Square MoveForward(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareRight(currentSquare);
        }

        public Square MoveBackwards(Square currentSquare, Grid grid)
        {
            return grid.GetNextSquareLeft(currentSquare);
        }
    }
}