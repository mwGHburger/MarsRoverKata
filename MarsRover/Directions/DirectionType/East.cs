namespace MarsRover
{
    public class East : IDirection
    {
        public DirectionName Name { get; } = DirectionName.East;
        public IDirection TurnRight { get; set; }
        public IDirection TurnLeft { get; set; }

        public Square MoveForward(Square currentSquare, Grid grid)
        {
            var newColumn = (currentSquare.Column + 1 > grid.Columns) ? 1 : currentSquare.Column + 1;
            return grid.Find(currentSquare.Row, newColumn);
        }

        public Square MoveBackwards(Square currentSquare, Grid grid)
        {
            var newColumn = (currentSquare.Column - 1).Equals(0) ? grid.Columns : currentSquare.Column - 1;
            return grid.Find(currentSquare.Row, newColumn);
        }
    }
}