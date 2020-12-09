using Xunit;

namespace MarsRover.Tests
{
    public class EmptyStringValidatorTests
    {
        [Fact]
        public void Validate_ShouldReturnTrueForNonEmptyStringInput()
        {
            var emptyStringValidator = new EmptyStringValidator();
            var input = "input";

            var actual = emptyStringValidator.IsValid(input);

            Assert.True(actual);

        }
    }
}