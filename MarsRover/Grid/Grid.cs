using System.Collections.Generic;
using System.Reflection.Emit;
namespace MarsRover
{
    public class Grid
    {
        public int Rows { get; }
        public int Columns { get; }

        public List<Square> Squares { get; } = new List<Square>();

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            CreateSquares();
        }

        public Square Find(int row, int column)
        {
            return Squares.Find(x => x.Row.Equals(row) && x.Column.Equals(column));
        }

        public Square GetNextSquareUp(Square currentSquare)
        {
            var newRow = (currentSquare.Row + 1 > Rows) ? 1 : currentSquare.Row + 1;
            return Find(newRow, currentSquare.Column);
        }

        public Square GetNextSquareDown(Square currentSquare)
        {
            var newRow = (currentSquare.Row - 1).Equals(0) ? Rows : currentSquare.Row - 1;
            return Find(newRow, currentSquare.Column);
        }
        
        public Square GetNextSquareLeft(Square currentSquare)
        {
            var newColumn = (currentSquare.Column - 1).Equals(0) ? Columns : currentSquare.Column - 1;
            return Find(currentSquare.Row, newColumn);
        }

        public Square GetNextSquareRight(Square currentSquare)
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