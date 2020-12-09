using System;
using Xunit;

namespace MarsRover.Tests
{
    public class EmptyStringValidatorTests
    {
        [Fact]
        public void IsValid_ShouldReturnTrueForNonEmptyStringInput()
        {
            var emptyStringValidator = new EmptyStringValidator();
            var input = "input";

            var actual = emptyStringValidator.IsValid(input);

            Assert.True(actual);

        }

        [Fact]
        public void IsValid_ShouldThrowArgumentException_WithCorrectErrorMessage_ForEmptyStringInput()
        {
            var emptyStringValidator = new EmptyStringValidator();
            var input = "";

            var ex = Assert.Throws<ArgumentException>(() => emptyStringValidator.IsValid(input));
            Assert.Equal("Please enter rover commands!", ex.Message);
        }
    }
}