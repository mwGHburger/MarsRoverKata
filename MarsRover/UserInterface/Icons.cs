using System;
using System.Collections.Generic;
using System.Collections.Specialized;
namespace MarsRover
{
    public class Icons
    {   
        public string GetIconFromSquareState(SquareState squareState)
        {
            switch(squareState) 
            {
                case SquareState.Empty: 
                    return "o"; 
                case SquareState.RoverNorth: 
                    return "🔼"; 
                case SquareState.RoverEast: 
                    return "▶️";
                case SquareState.RoverSouth: 
                    return "🔽";
                case SquareState.RoverWest: 
                    return "◀️";
                default:
                    throw new ArgumentException("Square state does not exist");
            }
        }
    }
}