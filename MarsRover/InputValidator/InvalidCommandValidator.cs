using System;
namespace MarsRover
{
    public class InvalidCommandValidator : IValidator
    {
        public bool IsValid(string input)
        {
            input = input.Replace(",", "").Replace(" ","");
            var commands = input.ToCharArray();
            foreach(var command in commands)
            {
                var formattedCommand = command.ToString().ToLower();
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