using Xunit;

namespace Application.Tests
{
    public class RoomPaintRequiredForWallsCalculatorTests
    {
        [Fact]
        public void Calculate_ValidRoom_ReturnsTotalWallArea()
        {
            const decimal length = 2;
            const decimal width = 3;
            const decimal height = 4;

            var room = new Room(length, width, height);
            var wallAreaCalculator = new RoomWallAreaCalculator();
            var wallArea = wallAreaCalculator.Calculate(room);
            const decimal wallSurfaceAreaToVolumeOfPaintRatio = 10;
            var expected = wallArea / wallSurfaceAreaToVolumeOfPaintRatio;
            var sut = new RoomPaintRequiredForWallsCalculator(wallSurfaceAreaToVolumeOfPaintRatio);

            var actual = sut.Calculate(room);

            Assert.Equal(expected, actual);
        }
    }
}
