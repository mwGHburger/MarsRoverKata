using Xunit;

namespace MarsRover.Tests
{
    public class SouthTests
    {
        [Fact]
        public void MoveForward_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var south = new South();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(3,1);

            var actual = south.MoveForward(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MoveBackwards_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var south = new South();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(2,1);

            var actual = south.MoveBackwards(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}