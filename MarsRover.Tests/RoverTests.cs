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
        [InlineData(DirectionName.North, 2, 1)]
        [InlineData(DirectionName.East, 1, 2)]
        [InlineData(DirectionName.South, 5, 1)]
        [InlineData(DirectionName.West, 1, 5)]
        public void Move_ShouldChangeTheRoversCurrentPostion(DirectionName directionName, int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new DirectionNode(directionName));

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);
            
            rover.Move('f');
            
            Assert.Equal(expected, rover.CurrentPosition);
        }
    }
}