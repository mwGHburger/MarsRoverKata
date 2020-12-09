using System;
using Xunit;

namespace MarsRover.Tests
{
    public class InvalidCommandValidatorTests
    {
        [Fact]
        public void IsValid_ShouldReturnTrueForValidCommands()
        {
            var invalidCommandValidator = new InvalidCommandValidator();
            var input = "f,b,l,r";

            var actual = invalidCommandValidator.IsValid(input);

            Assert.True(actual);
        }

        [Fact]
        public void IsValid_ShouldThrowArgumentException_WithCorrectErrorMessage_ForInvalidCommands()
        {
            var invalidCommandValidator = new InvalidCommandValidator();
            var input = "f,zz,l,r";

            var ex = Assert.Throws<ArgumentException>(() => invalidCommandValidator.IsValid(input));
            Assert.Equal("Invalid command!", ex.Message);
        }
    }
}