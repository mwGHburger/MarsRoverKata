using System;
using Xunit;

namespace MarsRover.Tests
{
    public class EmptyInputValidatorTests
    {
        [Fact]
        public void IsValid_ShouldReturnTrueForNonEmptyStringInput()
        {
            var emptyStringValidator = new EmptyInputValidator();
            var input = "input";

            var actual = emptyStringValidator.IsValid(input);

            Assert.True(actual);

        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void IsValid_ShouldThrowArgumentException_WithCorrectErrorMessage_ForEmptyStringInput(string input)
        {
            var emptyStringValidator = new EmptyInputValidator();
            
            var ex = Assert.Throws<ArgumentException>(() => emptyStringValidator.IsValid(input));
            Assert.Equal("Please enter rover commands!", ex.Message);
        }
    }
}