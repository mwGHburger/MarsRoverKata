using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Loader : ILoader
    {
        private IGrid _grid;
        private IRover _rover;

        public Loader(IGrid grid, IRover rover)
        {
            _grid = grid;
            _rover = rover;
        }

        public void LoadRoverOntoGrid()
        {
            var square = _grid.Find(1,1);
            _rover.CurrentSquare = square;
            square.State = SquareState.RoverNorth;
        }

        public void LoadObstaclesOntoGrid(int quantity)
        {
            var random = new Random();
            var randomNumberPairs = new List<List<int>>();
            var i = 0;
            
            while(i < quantity)
            {
                var randomRow = random.Next(1, _grid.Rows);
                var randomColumn = random.Next(1, _grid.Columns);
                var condition = randomNumberPairs.Exists(x => (x[0].Equals(randomRow) && x[1].Equals(randomColumn)));

                if(!condition)
                {
                    randomNumberPairs.Add(new List<int>() {randomRow, randomColumn});
                    var square = _grid.Find(randomRow,randomColumn);
                    square.State = SquareState.Obstacle;
                    i++;
                }
            }
        }
    }
}