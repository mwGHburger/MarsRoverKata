using Xunit;

namespace MarsRover.Tests
{
    public class DirectionsTest
    {
        [Fact]
        public void NodesProperty_ShouldBeAListOfDirectionNodes()
        {
            var directions = new Directions();
            var expected = 4;
            var actual = directions.Nodes.Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HeadProperty_ShouldBeNorth()
        {
            var directions = new Directions();
            var expected = DirectionName.North;

            var actual = directions.Head.Name;

            Assert.Equal(expected, actual);
        }
    }
}