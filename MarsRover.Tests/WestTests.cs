using Xunit;

namespace MarsRover.Tests
{
    public class WestTests
    {
        [Fact]
        public void MoveForward_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var west = new West();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,3);

            var actual = west.MoveForward(currentSquare, grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MoveBackwards_ShouldReturnNewSquare_GivenCurrentSquare()
        {
            var west = new West();
            var grid = new Grid(3,3);
            var currentSquare = grid.Find(1,1);
            var expected = grid.Find(1,2);

            var actual = west.MoveBackwards(currentSquare, grid);

            Assert.Equal(expected, actual);
        }
    }
}