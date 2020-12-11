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
            var directionTypes = TestHelper.SetupDirectionTypes();
            var directions = new Directions(directionTypes);
            var rover = new Rover(grid, directions);


            var actual = rover.CurrentSquare;

            Assert.IsType<Square>(actual);
        }

        [Fact]
        public void CurrentDirectionProperty_ShouldBeTypeDirection()
        {
            var grid = new Grid(5,5);
            var directionTypes = TestHelper.SetupDirectionTypes();
            var directions = new Directions(directionTypes);
            var rover = new Rover(grid, directions);

            var actual = rover.CurrentDirection;

            Assert.IsAssignableFrom<IDirection>(actual);
        }

        [Fact]
        public void TurnRight_ShouldChangeTheRoversCurrentDirectionToTheNextClockwiseDirection()
        {
            var grid = new Grid(5,5);
            var directionTypes = TestHelper.SetupDirectionTypes();
            var directions = new Directions(directionTypes);
            
            var rover = new Rover(grid, directions);

            rover.TurnRight();

            Assert.Equal(DirectionName.East, rover.CurrentDirection.Name);            
        }

        [Fact]
        public void TurnLeft_ShouldChangeTheRoversCurrentDirectionToTheNextAntiClockwiseDirection()
        {
            var grid = new Grid(5,5);
            var directionTypes = TestHelper.SetupDirectionTypes();
            var directions = new Directions(directionTypes);
            
            var rover = new Rover(grid, directions);
            rover.TurnLeft();

            Assert.Equal(DirectionName.West, rover.CurrentDirection.Name);            
        }

        [Theory]
        [InlineData(2, 1)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenNorth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new North());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            
            rover.MoveForward();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        [Theory]
        [InlineData(1, 2)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenEast(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new East());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            
            rover.MoveForward();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        [Theory]
        [InlineData(5, 1)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenSouth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new South());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            
            rover.MoveForward();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        [Theory]
        [InlineData(1, 5)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenWest(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new West());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            
            rover.MoveForward();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        [Theory]
        [InlineData(5, 1)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenNorth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new North());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        [Theory]
        [InlineData(1, 5)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenEast(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new East());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        [Theory]
        [InlineData(2, 1)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenSouth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new South());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        [Theory]
        [InlineData(1, 2)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenWest(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new West());

            var rover = new Rover(grid, mockDirections.Object);
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(expected, rover.CurrentSquare);
        }

        // [Theory]
        // [InlineData('f', 1, 2)]
        // [InlineData('b', 1, 5)]
        // public void Move_ShouldChangeTheRoversCurrentPostion_GivenEast(char command, int newRowPosition, int newColumnPosition)
        // {
        //     var grid = new Grid(5,5);
        //     var mockDirections = new Mock<IDirections>();

        //     mockDirections.SetupGet(x => x.Head).Returns(new East());

        //     var rover = new Rover(grid, mockDirections.Object);
        //     var expected = grid.Find(newRowPosition, newColumnPosition);

            
        //     rover.Move(command);
            
        //     Assert.Equal(expected, rover.CurrentSquare);
        // }

        // [Theory]
        // [InlineData('f', 5, 1)]
        // [InlineData('b', 2, 1)]
        // public void Move_ShouldChangeTheRoversCurrentPostion_GivenSouth(char command, int newRowPosition, int newColumnPosition)
        // {
        //     var grid = new Grid(5,5);
        //     var mockDirections = new Mock<IDirections>();

        //     mockDirections.SetupGet(x => x.Head).Returns(new South());

        //     var rover = new Rover(grid, mockDirections.Object);
        //     var expected = grid.Find(newRowPosition, newColumnPosition);

            
        //     rover.Move(command);
            
        //     Assert.Equal(expected, rover.CurrentSquare);
        // }

        // [Theory]
        // [InlineData('f', 1, 5)]
        // [InlineData('b', 1, 2)]
        // public void Move_ShouldChangeTheRoversCurrentPostion_GivenWest(char command, int newRowPosition, int newColumnPosition)
        // {
        //     var grid = new Grid(5,5);
        //     var mockDirections = new Mock<IDirections>();

        //     mockDirections.SetupGet(x => x.Head).Returns(new West());

        //     var rover = new Rover(grid, mockDirections.Object);
        //     var expected = grid.Find(newRowPosition, newColumnPosition);
            
        //     rover.Move(command);
            
        //     Assert.Equal(expected, rover.CurrentSquare);
        // }

        // [Theory]
        // [InlineData('f', 2, 1)]
        // // [InlineData('f', DirectionName.West, 1, 5)]
        // [InlineData('b', 5, 1)]
        // // [InlineData('b', DirectionName.West, 1, 2)]
        // public void Move_ShouldChangeTheRoversCurrentPostion_GivenNorth(char command, int newRowPosition, int newColumnPosition)
        // {
        //     var grid = new Grid(5,5);
        //     var mockDirections = new Mock<IDirections>();

        //     mockDirections.SetupGet(x => x.Head).Returns(new North());

        //     var rover = new Rover(grid, mockDirections.Object);
        //     var expected = grid.Find(newRowPosition, newColumnPosition);

            
        //     rover.Move(command);
            
        //     Assert.Equal(expected, rover.CurrentSquare);
        // }

        // [Theory]
        // [InlineData('f', 1, 2)]
        // [InlineData('b', 1, 5)]
        // public void Move_ShouldChangeTheRoversCurrentPostion_GivenEast(char command, int newRowPosition, int newColumnPosition)
        // {
        //     var grid = new Grid(5,5);
        //     var mockDirections = new Mock<IDirections>();

        //     mockDirections.SetupGet(x => x.Head).Returns(new East());

        //     var rover = new Rover(grid, mockDirections.Object);
        //     var expected = grid.Find(newRowPosition, newColumnPosition);

            
        //     rover.Move(command);
            
        //     Assert.Equal(expected, rover.CurrentSquare);
        // }

        // [Theory]
        // [InlineData('f', 5, 1)]
        // [InlineData('b', 2, 1)]
        // public void Move_ShouldChangeTheRoversCurrentPostion_GivenSouth(char command, int newRowPosition, int newColumnPosition)
        // {
        //     var grid = new Grid(5,5);
        //     var mockDirections = new Mock<IDirections>();

        //     mockDirections.SetupGet(x => x.Head).Returns(new South());

        //     var rover = new Rover(grid, mockDirections.Object);
        //     var expected = grid.Find(newRowPosition, newColumnPosition);

            
        //     rover.Move(command);
            
        //     Assert.Equal(expected, rover.CurrentSquare);
        // }

        // [Theory]
        // [InlineData('f', 1, 5)]
        // [InlineData('b', 1, 2)]
        // public void Move_ShouldChangeTheRoversCurrentPostion_GivenWest(char command, int newRowPosition, int newColumnPosition)
        // {
        //     var grid = new Grid(5,5);
        //     var mockDirections = new Mock<IDirections>();

        //     mockDirections.SetupGet(x => x.Head).Returns(new West());

        //     var rover = new Rover(grid, mockDirections.Object);
        //     var expected = grid.Find(newRowPosition, newColumnPosition);
            
        //     rover.Move(command);
            
        //     Assert.Equal(expected, rover.CurrentSquare);
        // }

        
    }
}