using System.Collections.Generic;

namespace MarsRover
{
    public static class ApplicationProperties
    {
        public static int GridMinimumValue = 1;
        public static List<char> ValidCommands = new List<char>()
        {
            'f',
            'b',
            'l',
            'r'
        };
    }
}