using System.Collections.Generic;
using Xunit;

namespace MarsRover.Tests
{
    public class RandomValueSelectorTests
    {
        [Fact]
        public void SelectRandomValue_ShouldReturnRandomValueFromAnyList()
        {
            var list = new List<string>()
            {
                "a",
                "b",
                "c"
            };
            var randomValueSelector = new RandomValueSelector();
            var actual = randomValueSelector.SelectRandomValue(list);

            Assert.Contains(actual, list);
        }
    }
}