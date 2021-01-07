using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTests
    {
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
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverNorth;
            var directionTypes = TestHelper.SetupDirectionTypes();
            var directions = new Directions(directionTypes);
            var rover = new Rover(grid, directions);
            rover.CurrentSquare = startingSquare;

            rover.TurnRight();

            Assert.Equal(DirectionName.East, rover.CurrentDirection.Name);   
            Assert.Equal(SquareState.RoverEast, rover.CurrentSquare.State);         
        }

        [Fact]
        public void TurnLeft_ShouldChangeTheRoversCurrentDirectionToTheNextAntiClockwiseDirection()
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverNorth;
            var directionTypes = TestHelper.SetupDirectionTypes();
            var directions = new Directions(directionTypes);
            var rover = new Rover(grid, directions);
            rover.CurrentSquare = startingSquare;

            rover.TurnLeft();

            Assert.Equal(DirectionName.West, rover.CurrentDirection.Name);
            Assert.Equal(SquareState.RoverWest, rover.CurrentSquare.State);            
        }

        [Theory]
        [InlineData(2, 1)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenNorth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverNorth;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new North());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);
            
            rover.MoveForward();
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverNorth, rover.CurrentSquare.State);
        }

        [Theory]
        [InlineData(1, 2)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenEast(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverEast;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new East());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveForward();
            
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverEast, rover.CurrentSquare.State);
        }

        [Theory]
        [InlineData(5, 1)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenSouth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverSouth;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new South());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);

            
            rover.MoveForward();
            
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverSouth, rover.CurrentSquare.State);
        }

        [Theory]
        [InlineData(1, 5)]
        public void MoveForward_ShouldChangeTheRoversCurrentPostion_GivenWest(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverSouth;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new West());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);

            
            rover.MoveForward();
            
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverWest, rover.CurrentSquare.State);
        }

        [Theory]
        [InlineData(5, 1)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenNorth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverNorth;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new North());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverNorth, rover.CurrentSquare.State);
        }

        [Theory]
        [InlineData(1, 5)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenEast(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverEast;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new East());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverEast, rover.CurrentSquare.State);
        }

        [Theory]
        [InlineData(2, 1)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenSouth(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverSouth;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new South());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverSouth, rover.CurrentSquare.State);
        }

        [Theory]
        [InlineData(1, 2)]
        public void MoveBackwards_ShouldChangeTheRoversCurrentPostion_GivenWest(int newRowPosition, int newColumnPosition)
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            startingSquare.State = SquareState.RoverWest;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new West());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            var expected = grid.Find(newRowPosition, newColumnPosition);

            rover.MoveBackwards();
            
            Assert.Equal(SquareState.Empty, startingSquare.State);
            Assert.Equal(expected, rover.CurrentSquare);
            Assert.Equal(SquareState.RoverWest, rover.CurrentSquare.State);
        }
        
        [Fact]
        public void DetectObstacleInfront_ShouldThrowExceptionWhenObstacleExistInfront()
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            var obstacle = grid.Find(2,1);
            startingSquare.State = SquareState.RoverNorth;
            obstacle.State = SquareState.Obstacle;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new North());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            
            var ex = Assert.Throws<ArgumentException>(() => rover.DetectObstacleInfront());
            Assert.Equal("Obstacle infront of Rover!", ex.Message);
        }

        [Fact]
        public void DetectObstacleBehind_ShouldThrowExceptionWhenObstacleExistInfront()
        {
            var grid = new Grid(5,5);
            var startingSquare = grid.Find(1,1);
            var obstacle = grid.Find(5,1);
            startingSquare.State = SquareState.RoverNorth;
            obstacle.State = SquareState.Obstacle;
            var mockDirections = new Mock<IDirections>();

            mockDirections.SetupGet(x => x.Head).Returns(new North());

            var rover = new Rover(grid, mockDirections.Object);
            rover.CurrentSquare = startingSquare;
            
            var ex = Assert.Throws<ArgumentException>(() => rover.DetectObstacleBehind());
            Assert.Equal("Obstacle behind Rover!", ex.Message);
        }
    }
}