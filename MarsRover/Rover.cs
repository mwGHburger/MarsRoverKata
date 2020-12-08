using System.Collections.Generic;

namespace MarsRover
{
    public class Rover
    {
        private Grid _grid;
        private List<Direction> _directions;

        public Square CurrentPosition { get; }
        public Direction CurrentDirection { get; private set; }

        public Rover(Grid grid, List<Direction> directions)
        {
            _grid = grid;
            _directions = directions;
            CurrentPosition = grid.Squares[0];
            CurrentDirection = new Direction(DirectionName.North);
        }
        
        public void Turn(char command)
        {
            if(command.Equals('r'))
            {
                CurrentDirection = CurrentDirection.Next;
            }
        }
    }
}