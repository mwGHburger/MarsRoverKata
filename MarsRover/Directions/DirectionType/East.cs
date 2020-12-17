namespace MarsRover
{
    public class East : IDirection
    {
        public DirectionName Name { get; } = DirectionName.East;
        public IDirection Right { get; set; }
        public IDirection Left { get; set; }
        public SquareState RoverState { get; } = SquareState.RoverEast;
        
        public ISquare GetSquareInfront(ISquare currentSquare, IGrid grid)
        {
            return grid.GetNextSquareRight(currentSquare);
        }

        public ISquare GetSquareBehind(ISquare currentSquare, IGrid grid)
        {
            return grid.GetNextSquareLeft(currentSquare);
        }
    }
}