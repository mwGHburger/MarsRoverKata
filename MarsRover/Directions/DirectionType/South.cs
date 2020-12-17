namespace MarsRover
{
    public class South : IDirection
    {
        public DirectionName Name { get; } = DirectionName.South;
        public IDirection Right { get; set; }
        public IDirection Left { get; set; }

        public ISquare GetSquareInfront(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareDown(currentSquare);
        }

        public ISquare GetSquareBehind(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareUp(currentSquare);
        }
    }
}