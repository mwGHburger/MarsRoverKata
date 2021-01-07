using Xunit;

namespace MarsRover.Tests
{
    public class IconsTests
    {
        [Theory]
        [InlineData("🟥", SquareState.Empty)]
        [InlineData("🌋", SquareState.Obstacle)]
        [InlineData("🔼", SquareState.RoverNorth)]
        [InlineData("⏩", SquareState.RoverEast)]
        [InlineData("🔽", SquareState.RoverSouth)]
        [InlineData("⏪", SquareState.RoverWest)]
        public void GetIcon_ShouldReturnStringIconDependingOnSquareState(string expected, SquareState squareState)
        {
            var icons = new Icons();

            var actual = icons.GetIconFromSquareState(squareState);

            Assert.Equal(expected, actual);
        }
    }
}