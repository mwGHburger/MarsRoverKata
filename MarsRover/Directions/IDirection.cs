namespace MarsRover
{
    public interface IDirection
    {
        DirectionName Name { get; }
        IDirection Right { get; set; }
        IDirection Left { get; set; }
        SquareState RoverState { get; }
        ISquare GetSquareInfront(ISquare currentSquare, IGrid grid);
        ISquare GetSquareBehind(ISquare currentSquare, IGrid grid);
    }
}