using Xunit;

namespace MarsRover.Tests
{
    public class EastTests
    {
        [Fact]
        public void GetSquareInfront_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var east = new East();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,2);

            var actual = east.GetSquareInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSquareBehind_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var east = new East();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,3);

            var actual = east.GetSquareBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}