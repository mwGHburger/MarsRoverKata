using System.Collections.Generic;

namespace MarsRover.Tests
{
    public static class TestHelper
    {
        public static List<IDirection> SetupDirectionTypes()
        {
            return new List<IDirection>()
            {
                new North(),
                new East(),
                new South(),
                new West()
            };
        }

        public static List<IValidator> SetupValidators()
        {
            return new List<IValidator>()
            {
                new EmptyInputValidator(),
                new InvalidCommandValidator()
            };
        }

        public static List<ISquare> SetupSquares(int row, int column)
        {
            var squares = new List<ISquare>();

            for(var i = 1; i <= row; i++)
            {
                for(var j = 1; j <= column; j++)
                {
                    squares.Add(new Square(i,j));
                }
            }
            return squares;
        }

        public static string SetupGridString(int row, int column, string icon)
        {
            var gridString= "";
            
            for(var i = 1; i <= row; i++)
            {
                var gridRow = "";
                for(var j = 1; j <= column; j++)
                {
                    gridRow += icon;
                }
                gridString = "\n" + gridRow + gridString;
            }
            return gridString;
        }
    }
}