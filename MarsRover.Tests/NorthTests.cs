using Xunit;

namespace MarsRover.Tests
{
    public class NorthTests
    {
        [Fact]
        public void MoveForward_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var north = new North();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(2,1);

            var actual = north.MoveForward(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MoveBackwards_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var north = new North();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(3,1);

            var actual = north.MoveBackwards(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}