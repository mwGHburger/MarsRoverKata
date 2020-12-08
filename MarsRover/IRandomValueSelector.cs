using System.Collections.Generic;

namespace MarsRover
{
    public interface IRandomValueSelector
    {
        T SelectRandomValue<T>(List<T> list);
    }
}