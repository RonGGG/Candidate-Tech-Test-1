using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new[] { 3, -2, 6, 0, 5, -1, 7, 9 }, new[] { -1, 7, 9 })]
        [InlineData(new[] { 1, 7, -2, -1, 9, 2 }, new[] { -2, -1, 9 })]
        [InlineData(new[] { 1, 9, -8, -7, 3, 4 }, new[] { -8, -7, 3, 4 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new[] { 1 }, new[] { 1 })]

        // TODO: add more scenarios to ensure finder is working properly
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {

            // Arrange
            var finder = new LongestRisingSequenceFinder();

            // Act
            var actual = await finder.Find(data);

            // Assert
            actual.Should().Equal(expected);
        }
    }

}
