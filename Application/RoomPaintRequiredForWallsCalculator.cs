namespace Application
{
    public class RoomPaintRequiredForWallsCalculator
    {
        private readonly decimal _wallSurfaceAreaToVolumeOfPaintRatio;

        public RoomPaintRequiredForWallsCalculator(decimal wallSurfaceAreaToVolumeOfPaintRatio = 10)
        {
            _wallSurfaceAreaToVolumeOfPaintRatio = wallSurfaceAreaToVolumeOfPaintRatio;
        }

        public decimal Calculate(Room room)
        {
            var roomWallAreaCalculator = new RoomWallAreaCalculator();
            var wallArea = roomWallAreaCalculator.Calculate(room);
            var paintVolume = wallArea / _wallSurfaceAreaToVolumeOfPaintRatio;
            return paintVolume;
        }
    }
}
