using System.Collections.Generic;
using System.Reflection.Emit;
namespace MarsRover
{
    public class Grid
    {
        private int _rows;
        private int _columns;

        public List<Square> Squares { get; } = new List<Square>();

        public Grid(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            CreateSquares();
        }

        private void CreateSquares()
        {
            for(int row = 1; row <= _rows; row++)
            {   
                for(int column = 1; column <= _columns; column++)
                {
                    Squares.Add(new Square(row, column));
                }
            }
        }
    }
}