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
        private IValidator _roverCommandInputValidator;
        private IValidator _obstacleInputValidator;
        private bool hasProvidedInvalidQuantity = true;
        private bool isRoverRunning = true;

        public MarsRoverApplication(IUserInterface userInterface, ILoader loader, IGrid grid, IIcons icons, IRoverController roverController, IValidator roverCommandInputValidator, IValidator obstacleInputValidator)
        {
            _userInterface = userInterface;
            _loader = loader;
            _grid = grid;
            _icons = icons;
            _roverController = roverController;
            _roverCommandInputValidator = roverCommandInputValidator;
            _obstacleInputValidator = obstacleInputValidator;
        }

        public void Run()
        {
            _userInterface.Print("Starting Mars Rover...");
            while(hasProvidedInvalidQuantity)
            {
                try
                {
                    _userInterface.Print("Enter number of obstacle: ");
                    var obstaclesQuantity = _userInterface.GetUserInput();
                    _obstacleInputValidator.IsValid(obstaclesQuantity);
                    _userInterface.Print("Loading Rover...");   
                    _loader.LoadRoverOntoGrid();
                    _userInterface.Print("Loading Obstacles...");   
                    _loader.LoadObstaclesOntoGrid(Convert.ToInt32(obstaclesQuantity));
                    _userInterface.DisplayGrid(_grid, _icons);
                    hasProvidedInvalidQuantity = false;
                }
                catch(ArgumentException ex)
                {
                    _userInterface.Print(ex.Message);
                }
            }
            
            while(isRoverRunning)
            {
                try
                {
                    var input = _userInterface.GetUserInput();
                    _roverCommandInputValidator.IsValid(input);
                    var commands = input.ConvertToCharList();
                    _roverController.HandleInputCommands(commands);
                    Console.Clear();
                    _userInterface.DisplayGrid(_grid, _icons);
                }
                catch(ArgumentException ex)
                {
                    Console.Clear();
                    _userInterface.Print(ex.Message);
                    _userInterface.DisplayGrid(_grid, _icons);
                }
                
            }
        }
        
    }
}