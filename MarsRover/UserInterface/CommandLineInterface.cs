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

        public void DisplayGrid(IGrid grid, IIcons icons)
        {
            // TODO: Seems more functional
            var gridString = CreateGridString(grid, icons);
            _output.WriteLine(gridString);
        }

        private string CreateGridString(IGrid grid, IIcons icons)
        {
            var gridString = "";
            foreach(Square square in grid.Squares)
            {
                var icon = icons.GetIconFromSquareState(square.State);
                gridString += (square.Column < grid.Columns) ? $"{icon}" : $"{icon}\n";
            }
            return gridString;
        }
    }
}