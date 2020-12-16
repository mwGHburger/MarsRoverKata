using System;
using Xunit;

namespace MarsRover.Tests
{
    public class GridTests
    {
        [Fact]
        public void CreateSquares_ShouldGenerateListOfSquaresOnGrid_DependentOfRowsAndColumns()
        {
            var grid = new Grid(4,5);

            var actual = grid.Squares.Count;

            Assert.Equal(20, actual);
        }

        [Fact]
        public void Find_ShouldReturnSquareGivenRowAndColumn()
        {
            var grid = new Grid(5,5);

            var actual = grid.Find(2,3);

            Assert.Equal(2, actual.Row);
            Assert.Equal(3, actual.Column);
        }

        // If this work, refactor north, south, east , west tests
        [Fact]
        public void GetNextSquareUp_ShouldRetursSquareAboveCurrentSquare()
        {
            var grid = new Grid(5,5);
            var currentGrid = grid.Find(1,1);
            var actual = grid.GetNextSquareUp(currentGrid);

            Assert.Equal(2, actual.Row);
            Assert.Equal(1, actual.Column);
        }

        [Fact]
        public void GetNextSquareDown_ShouldRetursSquareBelowCurrentSquare()
        {
            var grid = new Grid(5,5);
            var currentGrid = grid.Find(1,1);
            var actual = grid.GetNextSquareDown(currentGrid);

            Assert.Equal(5, actual.Row);
            Assert.Equal(1, actual.Column);
        }

        [Fact]
        public void GetNextSquareLeft_ShouldRetursSquareLeftOfCurrentSquare()
        {
            var grid = new Grid(5,5);
            var currentGrid = grid.Find(1,1);
            var actual = grid.GetNextSquareLeft(currentGrid);

            Assert.Equal(1, actual.Row);
            Assert.Equal(5, actual.Column);
        }

        [Fact]
        public void GetNextSquareRight_ShouldRetursSquareRightOfCurrentSquare()
        {
            var grid = new Grid(5,5);
            var currentGrid = grid.Find(1,1);
            var actual = grid.GetNextSquareRight(currentGrid);

            Assert.Equal(1, actual.Row);
            Assert.Equal(2, actual.Column);
        }
    }
}
