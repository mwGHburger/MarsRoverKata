namespace MarsRover
{
    public class Loader
    {
        private IGrid _grid;
        private IRover _rover;

        public Loader(IGrid grid, IRover rover)
        {
            _grid = grid;
            _rover = rover;
        }

        public void LoadRoverOntoGrid()
        {
            var square = _grid.Find(1,1);
            _rover.CurrentSquare = square;
            square.State = SquareState.RoverNorth;
        }
    }
}