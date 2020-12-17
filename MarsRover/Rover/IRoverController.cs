using System.Collections.Generic;

namespace MarsRover
{
    public interface IRoverController
    {
        void HandleInputCommands(List<char> inputCommands);
    }
}