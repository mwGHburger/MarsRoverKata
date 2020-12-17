namespace MarsRover
{
    public interface ISquare
    {
        int Row { get; }
        int Column { get; }
        SquareState State { get; set; }
    }
}