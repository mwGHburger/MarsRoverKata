using System.Collections.Generic;

namespace MarsRover
{
    public interface IGrid
    {
        int Rows { get; }
        int Columns { get; }
        List<Square> Squares { get; }
        ISquare Find(int row, int column);
    }
}