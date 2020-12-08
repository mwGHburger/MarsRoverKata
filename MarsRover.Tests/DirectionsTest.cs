using System.Collections.Generic;
using Xunit;

namespace MarsRover.Tests
{
    public class DirectionsTest
    {
        [Fact]
        public void NodesProperty_ShouldBeAListOfDirectionNodes()
        {
            var directionTypes = TestHelper.SetupDirectionTypes();
            var directions = new Directions(directionTypes);
            var expected = 4;
            var actual = directions.DirectionTypes.Count;

            Assert.Equal(expected, actual);
        }

        // [Fact]
        // public void HeadProperty_ShouldBeNorth()
        // {
        //     var directions = new Directions();
        //     var expected = DirectionName.North;

        //     var actual = directions.Head.Name;

        //     Assert.Equal(expected, actual);
        // }
    }
}