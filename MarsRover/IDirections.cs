using System.Collections.Generic;

namespace MarsRover
{
    public interface IDirections
    {
        List<DirectionNode> Nodes { get; }
        DirectionNode Head { get; }
    }
}