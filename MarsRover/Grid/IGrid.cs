using System.Collections.Generic;

namespace MarsRover
{
    public interface IGrid
    {
        int Rows { get; }
        int Columns { get; }
        List<ISquare> Squares { get; }
        ISquare Find(int row, int column);
        ISquare GetNextSquareUp(ISquare currentSquare);
        ISquare GetNextSquareDown(ISquare currentSquare);
        ISquare GetNextSquareLeft(ISquare currentSquare);
        ISquare GetNextSquareRight(ISquare currentSquare);
    }
}