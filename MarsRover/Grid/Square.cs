namespace MarsRover
{
    public class Square : ISquare
    {
        public int Row { get; }
        public int Column { get; }
        public SquareState State { get; set; }

        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public void SetStateBasedOnRoverDirection(IRover rover)
        {
            switch(rover.CurrentDirection.Name)
            {
                case(DirectionName.North):
                    State = SquareState.RoverNorth;
                    return;
                case(DirectionName.East):
                    State = SquareState.RoverEast;
                    return;
                case(DirectionName.South):
                    State = SquareState.RoverSouth;
                    return;
                case(DirectionName.West):
                    State = SquareState.RoverWest;
                    return;
            }
        }
    }
}