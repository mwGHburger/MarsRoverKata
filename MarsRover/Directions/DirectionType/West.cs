namespace MarsRover
{
    public class West : IDirection
    {
        public DirectionName Name { get; } = DirectionName.West;
        public IDirection Right { get; set; }
        public IDirection Left { get; set; }

        public ISquare GetSquareInfront(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareLeft(currentSquare);
        }

        public ISquare GetSquareBehind(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareRight(currentSquare);
        }
    }
}