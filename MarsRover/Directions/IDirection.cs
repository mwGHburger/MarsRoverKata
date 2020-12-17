namespace MarsRover
{
    public interface IDirection
    {
        DirectionName Name { get; }
        IDirection Right { get; set; }
        IDirection Left { get; set; }
        ISquare GetSquareInfront(ISquare currentSquare, Grid grid);
        ISquare GetSquareBehind(ISquare currentSquare, Grid grid);
    }
}