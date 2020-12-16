namespace MarsRover
{
    public class CommandLineInterface
    {
        private IInput _input;
        private IOutput _output;

        public CommandLineInterface(IInput input, IOutput output)
        {
            _input = input;
            _output = output;
        }

        public void DisplayGrid(Grid grid)
        {
            // TODO: Seems more functional
            _output.WriteLine(CreateGridString(grid));
        }

        private string CreateGridString(Grid grid)
        {
            var gridString = "";
            foreach(Square square in grid.Squares)
            {
                gridString += (square.Column < grid.Columns) ? "o" : "o\n";
            }
            return gridString;
        }
    }
}