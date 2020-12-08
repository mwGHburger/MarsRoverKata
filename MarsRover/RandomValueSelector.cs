using System.Collections.Generic;

namespace MarsRover
{
    public class RandomValueSelector : IRandomValueSelector
    {
        public T SelectRandomValue<T>(List<T> list)
        {
            return list[0];
        }
    }
}