using System.Collections.Generic;
using Moq;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverControllerTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ExecuteCommands_ShouldTranslateUserInputIntoRoverCommands(List<char> roverCommands, int moveForwardTimesCalled, int moveBackwardsTimesCalled, int turnLeftTimesCalled, int turnRightTimesCalled)
        {
            var mockRover = new Mock<IRover>();

            var roverController = new RoverController(mockRover.Object);

            roverController.HandleInputCommands(roverCommands);

            mockRover.Verify(x => x.MoveForward(), Times.Exactly(moveForwardTimesCalled));
            mockRover.Verify(x => x.MoveBackwards(), Times.Exactly(moveBackwardsTimesCalled));
            mockRover.Verify(x => x.TurnLeft(), Times.Exactly(turnLeftTimesCalled));
            mockRover.Verify(x => x.TurnRight(), Times.Exactly(turnRightTimesCalled));
        }
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { new List<char>() {'f','b','l','r'}, 1, 1, 1, 1 },
                new object[] { new List<char>() {'f','f','r','r','r'}, 2, 0, 0, 3 },
            };
    }
    
}