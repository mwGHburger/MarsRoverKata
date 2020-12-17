namespace MarsRover
{
    public class Rover
    {
        private Grid _grid;
        private IDirections _directions;
        public ISquare CurrentSquare { get; set;}
        public IDirection CurrentDirection { get; private set; }

        public Rover(Grid grid, IDirections directions)
        {
            // TODO: remove grid, rover should not know grid
            _grid = grid;
            _directions = directions;
            CurrentDirection = _directions.Head;
        }

        public void TurnRight()
        {
            CurrentDirection = CurrentDirection.Right;
        }

        public void TurnLeft()
        {
            CurrentDirection = CurrentDirection.Left;
        }

        public void MoveForward()
        {
            CurrentSquare.State = SquareState.Empty;
            CurrentSquare = CurrentDirection.GetSquareInfront(CurrentSquare, _grid);
            CurrentSquare.State = CurrentDirection.RoverState;
        }

        public void MoveBackwards()
        {
            CurrentSquare = CurrentDirection.GetSquareBehind(CurrentSquare, _grid);
        }
        /*
        public void DetectObstacleInfront()
        {
            CurrentSquare = CurrentDirection.GetSquareInfront(CurrentSquare, _grid);
            if (CurrentSquare.State.Equals(SquareState.Obstacle))
            {
                throw new Exception("Detected obstacle");
            }
        }

        public void DetectObstacleBehind()
        {
            CurrentSquare = CurrentDirection.GetSquareBehind(CurrentSquare, _grid);
            if (CurrentSquare.State.Equals(SquareState.Obstacle))
            {
                throw new Exception("Detected obstacle");
            }
        }
        */
    }
}