using Xunit;

namespace MarsRover.Tests
{
    public class DirectionTests
    {
        [Fact]
        public void NameProperty_ShouldBeDirectionNameEnum()
        {
            var direction = new Direction(DirectionName.North);

            Assert.IsType<DirectionName>(direction.Name);
        }
    }
}