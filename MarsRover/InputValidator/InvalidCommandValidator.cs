using System.Net.Mime;
using System;
namespace MarsRover
{
    public class InvalidCommandValidator : IValidator
    {
        public bool IsValid(string input)
        {
            input = input.Replace(",", "").Replace(" ","").ToLower();
            var commands = input.ToCharArray();
            foreach(var command in commands)
            {
                if(!ApplicationProperties.ValidCommands.Contains(command))
                {
                    throw new ArgumentException("Invalid command!");
                }
            }
            return true;
        }
    }
}