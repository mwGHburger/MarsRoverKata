using Xunit;

namespace MarsRover.Tests
{
    public class WestTests
    {
        [Fact]
        public void GetSquareInfront_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var west = new West();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,3);

            var actual = west.GetSquareInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSquareBehind_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var west = new West();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,2);

            var actual = west.GetSquareBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}