using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Directions : IDirections
    {
        public List<DirectionNode> Nodes { get;} = new List<DirectionNode>();
        public DirectionNode Head { get; }

        public Directions()
        {
            SetupDirectionNodes();
            ConnectDirectionNodes();
            Head = Nodes[0];
        }


        private void SetupDirectionNodes()
        {
            foreach(DirectionName directionName in Enum.GetValues(typeof(DirectionName)))
            {
                Nodes.Add(new DirectionNode(directionName));
            }
        }

        private void ConnectDirectionNodes()
        {
            SetupClockwiseDirections();
            SetupAntiClockwiseDirections();
        }

        private void SetupClockwiseDirections()
        {
            for(int i = 0; i < Nodes.Count; i++)
            {
                if(i.Equals(Nodes.Count - 1))
                {
                    Nodes[i].NextClockwiseDirection = Nodes[0];
                    return;
                }
                Nodes[i].NextClockwiseDirection = Nodes[i + 1];
            }
        }

        private void SetupAntiClockwiseDirections()
        {
            for(int i = Nodes.Count - 1; i >= 0; i--)
            {
                if(i.Equals(0))
                {
                    Nodes[i].NextAntiClockwiseDirection = Nodes[Nodes.Count - 1];
                    return;
                }
                Nodes[i].NextAntiClockwiseDirection = Nodes[i - 1];
            }
        }
    }
}