using System;

namespace MarsRover
{
    public class Rover : IRover
    {
        private IGrid _grid;
        private IDirections _directions;
        public ISquare CurrentSquare { get; set;}
        public IDirection CurrentDirection { get; set; }

        public Rover(IGrid grid, IDirections directions)
        {
            // TODO: remove grid, rover should not know grid
            _grid = grid;
            _directions = directions;
            CurrentDirection = _directions.Head;
        }

        public void TurnRight()
        {
            CurrentDirection = CurrentDirection.Right;
            CurrentSquare.State = CurrentDirection.RoverState;
        }

        public void TurnLeft()
        {
            CurrentDirection = CurrentDirection.Left;
            CurrentSquare.State = CurrentDirection.RoverState;
        }

        public void MoveForward()
        {
            CurrentSquare.State = SquareState.Empty;
            CurrentSquare = CurrentDirection.GetSquareInfront(CurrentSquare, _grid);
            CurrentSquare.State = CurrentDirection.RoverState;
        }

        public void MoveBackwards()
        {
            CurrentSquare.State = SquareState.Empty;
            CurrentSquare = CurrentDirection.GetSquareBehind(CurrentSquare, _grid);
            CurrentSquare.State = CurrentDirection.RoverState;
        }
        public void DetectObstacleInfront()
        {
            var squareInfront = CurrentDirection.GetSquareInfront(CurrentSquare, _grid);
            if (squareInfront.State.Equals(SquareState.Obstacle))
            {
                throw new ArgumentException("Obstacle infront of Rover!");
            }
        }
        public void DetectObstacleBehind()
        {
            var squareBehind = CurrentDirection.GetSquareBehind(CurrentSquare, _grid);
            if (squareBehind.State.Equals(SquareState.Obstacle))
            {
                throw new ArgumentException("Obstacle behind of Rover!");
            }
        }
    }
}