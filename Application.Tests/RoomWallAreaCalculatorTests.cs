using Xunit;

namespace Application.Tests
{
    public class RoomWallAreaCalculatorTests
    {
        [Fact]
        public void Calculate_ValidRoom_ReturnsTotalWallArea()
        {
            const decimal length = 2;
            const decimal width = 3;
            const decimal height = 4;

            decimal singleLengthWallExpectedArea = length * height;
            decimal bothLengthWallsExpectedArea = singleLengthWallExpectedArea * 2;

            decimal singleWidthWallExpectedArea = width * height;
            decimal bothWidthWallsExpectedArea = singleWidthWallExpectedArea * 2;
            decimal expectedTotalArea = bothLengthWallsExpectedArea + bothWidthWallsExpectedArea;

            var room = new Room(length, width, height);
            var sut = new RoomWallAreaCalculator();

            var actual = sut.Calculate(room);

            Assert.Equal(expectedTotalArea, actual);
        }
    }
}
