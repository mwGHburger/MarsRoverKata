using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = ClassInstantiatorFactory.CreateApplication();
            application.Run();
        }
    }
}
