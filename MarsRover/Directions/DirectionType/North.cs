namespace MarsRover
{
    public class North : IDirection
    {
        public DirectionName Name { get; } = DirectionName.North;
        public SquareState RoverState { get; } = SquareState.RoverNorth;
        public IDirection Right { get; set; }
        public IDirection Left { get; set; }

        public ISquare GetSquareInfront(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareUp(currentSquare);
        }

        public ISquare GetSquareBehind(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareDown(currentSquare);
        }

    }
}