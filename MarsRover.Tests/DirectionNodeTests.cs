using Xunit;

namespace MarsRover.Tests
{
    public class DirectionNodeTests
    {
        [Fact]
        public void NameProperty_ShouldBeDirectionNameEnum()
        {
            var direction = new DirectionNode(DirectionName.North);

            Assert.IsType<DirectionName>(direction.Name);
        }

        [Fact]
        public void NextClockwiseDirectionProperty_ShouldBeDirectionNameEnum()
        {
            var north = new DirectionNode(DirectionName.North);
            var east = new DirectionNode(DirectionName.East);

            north.TurnRight = east;

            Assert.Equal(east, north.TurnRight);
        }

        [Fact]
        public void NextAntiClockwiseDirectionProperty_ShouldBeDirectionNameEnum()
        {
            var north = new DirectionNode(DirectionName.North);
            var west = new DirectionNode(DirectionName.West);

            north.TurnLeft = west;

            Assert.Equal(west, north.TurnLeft);
        }
    }
}