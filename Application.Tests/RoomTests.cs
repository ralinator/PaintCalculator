using System;
using Xunit;

namespace Application.Tests
{
    public class RoomTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0.5, 2.5, 100)]
        public void Construct_PositiveInputs_CorrectDimensions(decimal length, decimal width, decimal height)
        {
            var sut = new Room(length, width, height);

            Assert.Equal(length, sut.Length);
            Assert.Equal(width, sut.Width);
            Assert.Equal(height, sut.Height);
        }

        [Theory]
        [InlineData(-1, 2, 3)]
        [InlineData(1, 0, 100)]
        [InlineData(1, 1, -1)]
        [InlineData(-1, -2, -3)]
        public void Construct_InvalidInputs_ThrowsException(decimal length, decimal width, decimal height)
        {
            Action action = () => new Room(length, width, height);

            Assert.Throws<ArgumentOutOfRangeException>(action);
        }
    }
}
