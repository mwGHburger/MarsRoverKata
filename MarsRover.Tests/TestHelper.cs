using System.Collections.Generic;

namespace MarsRover.Tests
{
    public static class TestHelper
    {
        public static void SetupDirection()
        {
            var directions = new List<Direction>()
            {
                new Direction(DirectionName.North),
                new Direction(DirectionName.East),
                new Direction(DirectionName.South),
                new Direction(DirectionName.West)
            };
        }
    }
}