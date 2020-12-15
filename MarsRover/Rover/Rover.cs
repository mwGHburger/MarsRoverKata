namespace MarsRover
{
    public class Rover
    {
        private Grid _grid;
        private IDirections _directions;
        public Square CurrentSquare { get; private set;}
        public IDirection CurrentDirection { get; private set; }

        public Rover(Grid grid, IDirections directions)
        {
            _grid = grid;
            _directions = directions;
            CurrentSquare = grid.Squares[0];
            CurrentDirection = _directions.Head;
        }

        public void TurnRight()
        {
            CurrentDirection = CurrentDirection.TurnRight;
        }

        public void TurnLeft()
        {
            CurrentDirection = CurrentDirection.TurnLeft;
        }

        public void MoveForward()
        {
            CurrentSquare = CurrentDirection.MoveForward(CurrentSquare, _grid);
        }

        public void MoveBackwards()
        {
            CurrentSquare = CurrentDirection.MoveBackwards(CurrentSquare, _grid);
        }
    }
}