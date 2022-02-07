namespace Application
{
    public class RoomWallAreaCalculator
    {
        public decimal Calculate(Room room)
        {
            var lengthWallsArea = CalculateWallsArea(room.Length, room.Height);
            var widthWallsArea = CalculateWallsArea(room.Width, room.Height);
            var totalArea = lengthWallsArea + widthWallsArea;
            return totalArea;
        }

        private decimal CalculateWallsArea(decimal groundDimension, decimal heightOfRoom)
        {
            var areaCalculator = new AreaCalculator();
            var singleWallArea = areaCalculator.Calculate(groundDimension, heightOfRoom);
            var bothWallsArea = singleWallArea * 2;
            return bothWallsArea;
        }
    }
}
