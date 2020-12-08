using System.Collections.Generic;

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
        
        public void Turn(char command)
        {
            if(command.Equals('r'))
            {
                CurrentDirection = CurrentDirection.TurnRight;
                return;
            }

            if(command.Equals('l'))
            {
                CurrentDirection = CurrentDirection.TurnLeft;
                return;
            }
        }

        public void Move(char command)
        {
            if(command.Equals('f'))
            {
                CurrentSquare = CurrentDirection.MoveForward(CurrentSquare, _grid);
                return;
            }

            if(command.Equals('b'))
            {
                CurrentSquare = CurrentDirection.MoveBackwards(CurrentSquare, _grid);
                return;
            }
        }
    }
}