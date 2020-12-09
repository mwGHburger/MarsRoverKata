using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRover.Tests
{
    public class InputValidatorTests
    {
        [Fact]
        public void IsValid_ShouldReturnTrueForValidInput()
        {
            var validators = new List<IValidator>();
            var input = "f,b,r,l";
            var inputValidator = new InputValidator(validators);
            
            var actual = inputValidator.IsValid(input);

            Assert.True(actual);
        }

        [Fact]
        public void IsValid_ShouldThrowArgumentExceptionForEmptyInput()
        {
            var validators = new List<IValidator>()
            {
                new EmptyInputValidator()
            };
            var input = "";
            var inputValidator = new InputValidator(validators);
            
            var ex = Assert.Throws<ArgumentException>(() => inputValidator.IsValid(input));
            Assert.Equal("Please enter rover commands!", ex.Message);
        }

        [Fact]
        public void IsValid_ShouldThrowArgumentExceptionForInvalidCommand()
        {
            var validators = new List<IValidator>()
            {
                new InvalidCommandValidator()
            };
            var input = "zz,wefa!faef";
            var inputValidator = new InputValidator(validators);
            
            var ex = Assert.Throws<ArgumentException>(() => inputValidator.IsValid(input));
            Assert.Equal("Invalid command!", ex.Message);
        }
    }
}