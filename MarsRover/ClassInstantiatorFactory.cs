using System.Collections.Generic;

namespace MarsRover
{
    public static class ClassInstantiatorFactory
    {
        public static MarsRoverApplication CreateApplication()
        {
            return new MarsRoverApplication(CreateCommandLineInterface(), CreateLoader(), grid, CreateIcons(), CreateRoverController());
        }
        public static IUserInterface CreateCommandLineInterface()
        {
            return new CommandLineInterface(CreateConsoleInput(), CreateConsoleOutput());
        }

        public static IInput CreateConsoleInput()
        {
            return new ConsoleInput();
        }

        public static IOutput CreateConsoleOutput()
        {
            return new ConsoleOutput();
        }

        public static ILoader CreateLoader()
        {
            return new Loader(grid, rover);
        }

        public static IGrid grid = new Grid(20,20);
        public static IRover rover = new Rover(grid, CreateDirections());

        public static IDirections CreateDirections()
        {
            return new Directions(CreateDirectionTypes());
        }

        public static List<IDirection> CreateDirectionTypes()
        {
            return new List<IDirection>()
            {
                new North(),
                new East(),
                new South(),
                new West()
            };
        }

        public static IIcons CreateIcons()
        {
            return new Icons();
        }

        public static IRoverController CreateRoverController()
        {
            return new RoverController(rover);
        }
    }
}