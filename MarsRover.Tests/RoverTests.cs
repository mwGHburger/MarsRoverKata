using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        [Fact]
        public void CurrentPositionProperty_ShouldBeTypeSquare()
        {
            var grid = new Grid(5,5);
            var directions = new List<Direction>();
            var rover = new Rover(grid, directions);


            var actual = rover.CurrentPosition;

            Assert.IsType<Square>(actual);
        }

        [Fact]
        public void CurrentDirectionProperty_ShouldBeTypeDirection()
        {
            var grid = new Grid(5,5);
            var directions = new List<Direction>();
            var rover = new Rover(grid, directions);

            var actual = rover.CurrentDirection;

            Assert.IsType<Direction>(actual);
        }

        // [Fact]
        public void Turn_ShouldChangeTheRoversCurrentDirection()
        {
            var grid = new Grid(5,5);
            var directions = new List<Direction>()
            {
                new Direction(DirectionName.North),
                new Direction(DirectionName.East)
            };
            var rover = new Rover(grid, directions);

            rover.Turn('r');

            Assert.Equal(DirectionName.East, rover.CurrentDirection.Name);            
        }
    }
}