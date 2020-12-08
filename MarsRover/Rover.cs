using System.Collections.Generic;

namespace MarsRover
{
    public class Rover
    {
        private Grid _grid;
        private IDirections _directions;

        public Square CurrentPosition { get; private set;}
        public DirectionNode CurrentDirection { get; private set; }

        public Rover(Grid grid, IDirections directions)
        {
            _grid = grid;
            _directions = directions;
            CurrentPosition = grid.Squares[0];
            CurrentDirection = _directions.Head;
        }
        
        public void Turn(char command)
        {
            if(command.Equals('r'))
            {
                CurrentDirection = CurrentDirection.NextClockwiseDirection;
                return;
            }

            if(command.Equals('l'))
            {
                CurrentDirection = CurrentDirection.NextAntiClockwiseDirection;
                return;
            }
        }

        public void Move(char command)
        {
            if(command.Equals('f'))
            {
                if(CurrentDirection.Name.Equals(DirectionName.North))
                {
                   MoveNorth();
                }

                if(CurrentDirection.Name.Equals(DirectionName.South))
                {
                   MoveSouth();
                }

                if(CurrentDirection.Name.Equals(DirectionName.East))
                {
                   MoveEast();
                }

                if(CurrentDirection.Name.Equals(DirectionName.West))
                {
                   MoveWest();
                }
            }

            if(command.Equals('b'))
            {
                if(CurrentDirection.Name.Equals(DirectionName.North))
                {
                   MoveSouth();
                }

                if(CurrentDirection.Name.Equals(DirectionName.South))
                {
                   MoveNorth();
                }

                if(CurrentDirection.Name.Equals(DirectionName.East))
                {
                   MoveWest();
                }

                if(CurrentDirection.Name.Equals(DirectionName.West))
                {
                   MoveEast();
                }
            }
        }

        private void MoveNorth()
        {
            var newRow = (CurrentPosition.Row + 1 > _grid.Rows) ? 1 : CurrentPosition.Row + 1;
            CurrentPosition = _grid.Find(newRow, CurrentPosition.Column);
        }

        private void MoveSouth()
        {
            var newRow = (CurrentPosition.Row - 1).Equals(0) ? _grid.Rows : CurrentPosition.Row - 1;
            CurrentPosition = _grid.Find(newRow, CurrentPosition.Column);
        }

        private void MoveEast()
        {
            var newColumn = (CurrentPosition.Column + 1 > _grid.Columns) ? 1 : CurrentPosition.Column + 1;
            CurrentPosition = _grid.Find(CurrentPosition.Row, newColumn);
        }

        private void MoveWest()
        {
            var newColumn = (CurrentPosition.Column - 1).Equals(0) ? _grid.Columns : CurrentPosition.Column - 1;
            CurrentPosition = _grid.Find(CurrentPosition.Row, newColumn);
        }
    }
}