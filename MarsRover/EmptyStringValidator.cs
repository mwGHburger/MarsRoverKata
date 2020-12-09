using System;

namespace MarsRover
{
    public class EmptyStringValidator : IValidator
    {
        public bool IsValid(string input)
        {
            if(String.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Please enter rover commands!");
            }
            return true;
        }
    }
}