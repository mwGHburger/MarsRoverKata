using System;

namespace MarsRover
{
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string outputString)
        {
            Console.WriteLine(outputString);
        }
    }
}