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
            var emptyIcon = "o";
            var mockGrid = new Mock<IGrid>();
            var mockIcons = new Mock<IIcons>();
            var commandLineInterface = new CommandLineInterface(mockInput.Object, mockOutput.Object);
            var expected = TestHelper.SetupGridString(rows, columns, emptyIcon);

            mockGrid.Setup(x => x.Columns).Returns(4);
            mockGrid.Setup(x => x.Squares).Returns(TestHelper.SetupSquares(rows, columns));
            mockIcons.Setup(x => x.GetIconFromSquareState(SquareState.Empty)).Returns(emptyIcon);
            
            commandLineInterface.DisplayGrid(mockGrid.Object, mockIcons.Object);
            
            mockOutput.Verify(x => x.WriteLine(expected), Times.Exactly(1));
        }
    }
}