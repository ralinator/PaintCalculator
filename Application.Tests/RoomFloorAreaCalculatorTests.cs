using Xunit;

namespace Application.Tests
{
    public class RoomFloorAreaCalculatorTests
    {
        [Fact]
        public void Calculate_ValidRoom_ReturnsArea()
        {
            decimal length = 2;
            decimal width = 3;
            decimal height = 4;
            var room = new Room(length, width, height);
            var sut = new RoomFloorAreaCalculator();

            var actual = sut.Calculate(room);

            Assert.Equal(6, actual);
        }
    }
}
