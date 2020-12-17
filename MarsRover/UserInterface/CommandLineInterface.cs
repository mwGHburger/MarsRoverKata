namespace MarsRover
{
    public class CommandLineInterface : IUserInterface
    {
        private IInput _input;
        private IOutput _output;

        public CommandLineInterface(IInput input, IOutput output)
        {
            _input = input;
            _output = output;
        }

        public string GetUserInput()
        {
            return _input.ReadLine();
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
            var gridRow = "";
            foreach(Square square in grid.Squares)
            {
                var icon = icons.GetIconFromSquareState(square.State);
                if (square.Column < grid.Columns)
                {
                    gridRow += icon;
                }
                else
                {
                    gridRow += icon;
                    gridString = "\n" + gridRow + gridString;
                    gridRow = "";
                }
            }
            return gridString;
        }
    }
}