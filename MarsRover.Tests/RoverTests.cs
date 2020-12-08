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
            var directions = new Directions();
            var rover = new Rover(grid, directions);


            var actual = rover.CurrentPosition;

            Assert.IsType<Square>(actual);
        }

        [Fact]
        public void CurrentDirectionProperty_ShouldBeTypeDirection()
        {
            var grid = new Grid(5,5);
            var directions = new Directions();
            var rover = new Rover(grid, directions);

            var actual = rover.CurrentDirection;

            Assert.IsType<DirectionNode>(actual);
        }

        [Fact]
        public void Turn_ShouldChangeTheRoversCurrentDirectionToTheNextClockwiseDirection_Given_Char_r()
        {
            var grid = new Grid(5,5);
            var directions = new Directions();
            
            var rover = new Rover(grid, directions);

            rover.Turn('r');

            Assert.Equal(DirectionName.East, rover.CurrentDirection.Name);            
        }

        [Fact]
        public void Turn_ShouldChangeTheRoversCurrentDirectionToTheNextAntiClockwiseDirection_Given_Char_l()
        {
            var grid = new Grid(5,5);
            var directions = new Directions();
            
            var rover = new Rover(grid, directions);
            rover.Turn('l');
            Assert.Equal(DirectionName.West, rover.CurrentDirection.Name);            
        }

        [Theory]
        [InlineData('f', DirectionName.North, 2, 1)]
        [InlineData('f', DirectionName.East, 1, 2)]
        [InlineData('f', DirectionName.South, 5, 1)]
        [InlineData('f', DirectionName.West, 1, 5)]
        [InlineData('b', DirectionName.North, 5, 1)]
        [InlineData('b', DirectionName.East, 1, 5)]
        [InlineData('b', DirectionName.South, 2, 1)]
        [InlineData('b', DirectionName.West, 1, 2)]
        public void Move_ShouldChangeTheRoversCurrentPostion(char command, DirectionName directionName, int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new DirectionNode(directionName));

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);
            
            rover.Move(command);
            
            Assert.Equal(expected, rover.CurrentPosition);
        }
    }
}