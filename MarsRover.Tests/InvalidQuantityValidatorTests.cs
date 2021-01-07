using System;
using MarsRover;
using Xunit;

namespace MarsRover.Tests
{
    public class InvalidQuantityValidatorTests
    {
        [Theory]
        [InlineData("1")]
        [InlineData("10")]
        [InlineData("0")]
        public void IsValid_ShouldReturnTrueForValidQuantity(string input)
        {
            var invalidQuantityValidator = new InvalidQuantityValidator();

            var actual = invalidQuantityValidator.IsValid(input);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("a")]
        public void IsValid_ShouldReturnFalseForInvalidQuantity(string input)
        {
            var invalidQuantityValidator = new InvalidQuantityValidator();

            var ex = Assert.Throws<ArgumentException>(() => invalidQuantityValidator.IsValid(input));

            Assert.Equal("Invalid quantity!", ex.Message);
        }
    }
}