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
    }
}
