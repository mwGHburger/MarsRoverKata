using System;
using System.Text.RegularExpressions;
namespace MarsRover
{
    public class InvalidQuantityValidator : IValidator
    {
        public bool IsValid(string input)
        {
            var pattern = @"^[0-9]+$";
            var regex = new Regex(pattern);
            if(regex.IsMatch(input))
            {
                return true;
            }
            throw new ArgumentException("Invalid quantity!");
        }
    }
}