using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class CommandLineInterfaceTests
    {
        
        [Fact]
        public void DisplayGrid_ShouldPrintTheCurrentGridStateOnTheConsole()
        {
            var mockInput = new Mock<IInput>();
            var mockOutput = new Mock<IOutput>();
            var rows = 4;
            var columns = 4;
            var grid = new Grid(rows,columns);
            var commandLineInterface = new CommandLineInterface(mockInput.Object, mockOutput.Object);
            var expected = "oooo\n" +
                           "oooo\n" +
                           "oooo\n" +
                           "oooo\n"; 

            commandLineInterface.DisplayGrid(grid);
            
            mockOutput.Verify(x => x.WriteLine(expected), Times.Exactly(1));
        }
    }
}