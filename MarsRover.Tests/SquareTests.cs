using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class SquareTests
    {
        [Fact]
        public void Square_ShouldHaveEnptyStateWhenInstantiated()
        {
            var square = new Square(1,1);
            var expected = SquareState.Empty;

            var actual = square.State;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetRoverState_ShouldSetStateDependingOnRoverCurrentDirection()
        {
            var square = new Square(1,1);
            var mockRover = new Mock<IRover>();
            var expected = SquareState.RoverNorth;

            mockRover.Setup(x => x.CurrentDirection).Returns(new North());

            square.SetStateBasedOnRoverDirection(mockRover.Object);

            var actual = square.State;

            Assert.Equal(expected, actual);
        }
    }
}