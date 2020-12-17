using System.Collections.Generic;
using System.Reflection.Emit;
namespace MarsRover
{
    public class Grid : IGrid
    {
        public int Rows { get; }
        public int Columns { get; }

        public List<ISquare> Squares { get; } = new List<ISquare>();

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            CreateSquares();
        }

        public ISquare Find(int row, int column)
        {
            return Squares.Find(x => x.Row.Equals(row) && x.Column.Equals(column));
        }

        public ISquare GetNextSquareUp(ISquare currentSquare)
        {
            var newRow = (currentSquare.Row + 1 > Rows) ? 1 : currentSquare.Row + 1;
            return Find(newRow, currentSquare.Column);
        }

        public ISquare GetNextSquareDown(ISquare currentSquare)
        {
            var newRow = (currentSquare.Row - 1).Equals(0) ? Rows : currentSquare.Row - 1;
            return Find(newRow, currentSquare.Column);
        }
        
        public ISquare GetNextSquareLeft(ISquare currentSquare)
        {
            var newColumn = (currentSquare.Column - 1).Equals(0) ? Columns : currentSquare.Column - 1;
            return Find(currentSquare.Row, newColumn);
        }

        public ISquare GetNextSquareRight(ISquare currentSquare)
        {
            var newColumn = (currentSquare.Column + 1 > Columns) ? 1 : currentSquare.Column + 1;
            return Find(currentSquare.Row, newColumn);
        }

        private void CreateSquares()
        {
            for(int row = ApplicationProperties.GridMinimumValue; row <= Rows; row++)
            {   
                for(int column = ApplicationProperties.GridMinimumValue; column <= Columns; column++)
                {
                    Squares.Add(new Square(row, column));
                }
            }
        }
    }
}