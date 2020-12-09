using System;

namespace MarsRover
{
    public class EmptyStringValidator : IValidator
    {
        public bool IsValid(string input)
        {
            if(String.IsNullOrEmpty(input.Trim()))
            {
                throw new ArgumentException("Please enter rover commands!");
            }
            return true;
        }
    }
}