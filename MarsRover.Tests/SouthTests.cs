using Xunit;

namespace MarsRover.Tests
{
    public class SouthTests
    {
        [Fact]
        public void GetSquareInfront_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var south = new South();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(3,1);

            var actual = south.GetSquareInfront(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSquareBehind_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var south = new South();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(2,1);

            var actual = south.GetSquareBehind(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}