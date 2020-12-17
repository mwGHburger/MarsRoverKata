using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class LoaderTests
    {
        [Fact]
        public void LoadRoverOntoGrid_ShouldPlaceRoverOntoGrid()
        {
            var mockGrid = new Mock<IGrid>();
            var mockRover = new Mock<IRover>();
            var loader = new Loader(mockGrid.Object, mockRover.Object);
            var mockSquare = new Mock<ISquare>();

            mockGrid.Setup(x => x.Find(It.IsAny<int>(), It.IsAny<int>())).Returns(mockSquare.Object);

            loader.LoadRoverOntoGrid();

            mockRover.VerifySet(x => x.CurrentSquare = mockSquare.Object);
            mockSquare.VerifySet(x => x.State = SquareState.RoverNorth);
        }
    }
}