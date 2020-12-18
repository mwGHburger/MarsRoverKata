using System.Collections.Generic;

namespace MarsRover
{
    public class RoverController : IRoverController
    {
        private IRover _rover;

        public RoverController(IRover rover)
        {
            _rover = rover;
        }

        public void HandleInputCommands(List<char> inputCommands)
        {
            foreach(char command in inputCommands)
            {
                ExecuteCommand(command);
            }
        }

        private void ExecuteCommand(char command)
        {
            switch(command)
            {
                case 'f':
                    _rover.DetectObstacleInfront();
                    _rover.MoveForward();
                    return;
                case 'b':
                    _rover.DetectObstacleBehind();
                    _rover.MoveBackwards();
                    return;
                case 'l':
                    _rover.TurnLeft();
                    return;
                case 'r':
                    _rover.TurnRight();
                    return;
            }
        }
    }
}