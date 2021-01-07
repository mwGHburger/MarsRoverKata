using System.Collections.Generic;

namespace MarsRover
{
    public class InputValidator : IValidator
    {
        private List<IValidator> _validators;

        public InputValidator(List<IValidator> validators)
        {
            _validators = validators;
        }

        public bool IsValid(string input)
        {
            foreach(IValidator validator in _validators)
            {
                validator.IsValid(input);
            }
            return true;
        }
    }
}