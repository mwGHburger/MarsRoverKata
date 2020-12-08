namespace MarsRover
{
    public interface IDirection
    {
        DirectionName Name { get; }
        IDirection TurnRight { get; set; }
        IDirection TurnLeft { get; set; }
        Square MoveForward(Square currentSquare, Grid grid);
        Square MoveBackwards(Square currentSquare, Grid grid);
    }
}