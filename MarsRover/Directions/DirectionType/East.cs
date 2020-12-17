namespace MarsRover
{
    public class East : IDirection
    {
        public DirectionName Name { get; } = DirectionName.East;
        public IDirection Right { get; set; }
        public IDirection Left { get; set; }
        
        public ISquare GetSquareInfront(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareRight(currentSquare);
        }

        public ISquare GetSquareBehind(ISquare currentSquare, Grid grid)
        {
            return grid.GetNextSquareLeft(currentSquare);
        }
    }
}