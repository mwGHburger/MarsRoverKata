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
    }
}
