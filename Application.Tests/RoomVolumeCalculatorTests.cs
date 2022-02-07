using Xunit;

namespace Application.Tests
{
    public class RoomVolumeCalculatorTests
    {
        [Fact]
        public void Calculate_ValidRoom_ReturnsVolume()
        {
            decimal length = 2;
            decimal width = 3;
            decimal height = 4;
            var room = new Room(length, width, height);
            var sut = new RoomVolumeCalculator();

            var actual = sut.Calculate(room);

            Assert.Equal(24, actual);
        }
    }
}
