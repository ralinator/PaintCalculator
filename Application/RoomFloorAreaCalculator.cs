namespace Application
{
    public class RoomFloorAreaCalculator
    {
        public decimal Calculate(Room room)
        {
            var areaCalculator = new AreaCalculator();
            var area = areaCalculator.Calculate(room.Length, room.Width);
            return area;
        }
    }
}
