using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Directions : IDirections
    {
        public List<IDirection> DirectionTypes { get; }

        public IDirection Head { get; }

        public Directions(List<IDirection> directionTypes)
        {
            DirectionTypes = directionTypes;
            ConnectDirectionTypes();
            Head = DirectionTypes[0];
        }

        private void ConnectDirectionTypes()
        {
            SetupClockwiseDirections();
            SetupAntiClockwiseDirections();
        }

        private void SetupClockwiseDirections()
        {
            for(int i = 0; i < DirectionTypes.Count; i++)
            {
                if(i.Equals(DirectionTypes.Count - 1))
                {
                    DirectionTypes[i].TurnRight = DirectionTypes[0];
                    return;
                }
                DirectionTypes[i].TurnRight = DirectionTypes[i + 1];
            }
        }

        private void SetupAntiClockwiseDirections()
        {
            for(int i = DirectionTypes.Count - 1; i >= 0; i--)
            {
                if(i.Equals(0))
                {
                    DirectionTypes[i].TurnLeft = DirectionTypes[DirectionTypes.Count - 1];
                    return;
                }
                DirectionTypes[i].TurnLeft = DirectionTypes[i - 1];
            }
        }
    }
}