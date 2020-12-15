using System.Collections.Generic;

namespace MarsRover.Tests
{
    public static class TestHelper
    {
        public static List<IDirection> SetupDirectionTypes()
        {
            return new List<IDirection>()
            {
                new North(),
                new East(),
                new South(),
                new West()
            };
        }

        public static List<IValidator> SetupValidators()
        {
            return new List<IValidator>()
            {
                new EmptyInputValidator(),
                new InvalidCommandValidator()
            };
        }
    }
}