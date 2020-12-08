namespace MarsRover
{
    public class South : IDirection
    {
        public DirectionName Name { get; } = DirectionName.South;
        public IDirection TurnRight { get; set; }
        public IDirection TurnLeft { get; set; }

        public Square MoveForward(Square currentSquare, Grid grid)
        {
            var newRow = (currentSquare.Row - 1).Equals(0) ? grid.Rows : currentSquare.Row - 1;
            return grid.Find(newRow, currentSquare.Column);
        }

        public Square MoveBackwards(Square currentSquare, Grid grid)
        {
            var newRow = (currentSquare.Row + 1 > grid.Rows) ? 1 : currentSquare.Row + 1;
            return grid.Find(newRow, currentSquare.Column);
        }
    }
}