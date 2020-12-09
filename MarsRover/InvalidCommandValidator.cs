using System;
namespace MarsRover
{
    public class InvalidCommandValidator
    {
        public bool IsValid(string input)
        {
            var commands = input.Split(',');
            foreach(string command in commands)
            {
                var formattedCommand = command.ToLower();
                var condition = formattedCommand.Equals("f") || formattedCommand.Equals("b") || formattedCommand.Equals("r") || formattedCommand.Equals("l");
                if(!condition)
                {
                    throw new ArgumentException("Invalid command!");
                }
            }
            return true;
        }
    }
}