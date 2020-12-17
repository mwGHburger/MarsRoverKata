namespace MarsRover
{
    public interface IRover
    {
        ISquare CurrentSquare { get; set; }
        IDirection CurrentDirection { get; set; }
        void TurnRight();
        void TurnLeft();
        void MoveForward();
        void MoveBackwards();
    }
}