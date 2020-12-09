using System.Collections.Generic;

namespace MarsRover
{
    public interface IDirections
    {
        List<IDirection> DirectionTypes { get; }
        IDirection Head { get; }
    }
}