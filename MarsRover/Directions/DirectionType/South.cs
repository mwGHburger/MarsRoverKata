namespace MarsRover
{
    public class South : IDirection
    {
        public DirectionName Name { get; } = DirectionName.South;
        public IDirection Right { get; set; }
        public IDirection Left { get; set; }
        public SquareState RoverState { get; } = SquareState.RoverSouth;

        public ISquare GetSquareInfront(ISquare currentSquare, IGrid grid)
        {
            return grid.GetNextSquareDown(currentSquare);
        }

        public ISquare GetSquareBehind(ISquare currentSquare, IGrid grid)
        {
            return grid.GetNextSquareUp(currentSquare);
        }
    }
}