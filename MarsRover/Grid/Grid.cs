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

        private void CreateSquares()
        {
            for(int row = 1; row <= Rows; row++)
            {   
                for(int column = 1; column <= Columns; column++)
                {
                    Squares.Add(new Square(row, column));
                }
            }
        }
    }
}