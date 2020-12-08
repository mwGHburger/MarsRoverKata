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
                   var newRow = (CurrentPosition.Row + 1 > _grid.Rows) ? 1 : CurrentPosition.Row + 1;
                   var newColumn = CurrentPosition.Column;
                   CurrentPosition = _grid.Find(newRow, newColumn);
                }

                if(CurrentDirection.Name.Equals(DirectionName.South))
                {
                   var newRow = (CurrentPosition.Row - 1).Equals(0) ? _grid.Rows : CurrentPosition.Row - 1;
                   
                   var newColumn = CurrentPosition.Column;
                   CurrentPosition = _grid.Find(newRow, newColumn);
                }

                if(CurrentDirection.Name.Equals(DirectionName.East))
                {
                   var newRow = CurrentPosition.Row;
                   var newColumn = (CurrentPosition.Column + 1 > _grid.Columns) ? 1 : CurrentPosition.Column + 1;
                   CurrentPosition = _grid.Find(newRow, newColumn);
                }

                if(CurrentDirection.Name.Equals(DirectionName.West))
                {
                   var newRow = CurrentPosition.Row;
                   var newColumn = (CurrentPosition.Column - 1).Equals(0) ? _grid.Columns : CurrentPosition.Column - 1;
                   CurrentPosition = _grid.Find(newRow, newColumn);
                }
            }
        }
    }
}