using System;

namespace MarsRover
{
    public class MarsRoverApplication
    {
        private IUserInterface _userInterface;
        private ILoader _loader;
        private IGrid _grid;
        private IIcons _icons;
        private IRoverController _roverController;

        public MarsRoverApplication(IUserInterface userInterface, ILoader loader, IGrid grid, IIcons icons, IRoverController roverController)
        {
            _userInterface = userInterface;
            _loader = loader;
            _grid = grid;
            _icons = icons;
            _roverController = roverController;
        }

        public void Run()
        {
            _loader.LoadRoverOntoGrid();
            while(true)
            {
                _userInterface.DisplayGrid(_grid, _icons);
                var input = _userInterface.GetUserInput();
                var commands = input.ConvertToCharList();
                _roverController.HandleInputCommands(commands);
                Console.Clear();
            }
        }
        
    }
}