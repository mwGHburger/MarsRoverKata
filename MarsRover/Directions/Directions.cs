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
            var startingIndex = 0;
            for(int i = startingIndex; i < DirectionTypes.Count; i++)
            {
                if(i.Equals(DirectionTypes.Count - 1))
                {
                    DirectionTypes[i].Right = DirectionTypes[0];
                    return;
                }
                DirectionTypes[i].Right = DirectionTypes[i + 1];
            }
        }

        private void SetupAntiClockwiseDirections()
        {
            var endingIndex = DirectionTypes.Count - 1;
            for(int i = endingIndex; i >= 0; i--)
            {
                if(i.Equals(0))
                {
                    DirectionTypes[i].Left = DirectionTypes[DirectionTypes.Count - 1];
                    return;
                }
                DirectionTypes[i].Left = DirectionTypes[i - 1];
            }
        }
    }
}