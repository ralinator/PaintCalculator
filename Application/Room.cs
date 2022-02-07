namespace Application
{
    public class Room
    {
        private decimal length;
        private decimal width;
        private decimal height;

        public Room(decimal length, decimal width, decimal height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public decimal Length
        {
            get => length; set
            {
                DimensionValidator.Validate(value);
                length = value;
            }
        }
        public decimal Width
        {
            get => width; set
            {
                DimensionValidator.Validate(value);
                width = value;
            }
        }
        public decimal Height
        {
            get => height; set
            {
                DimensionValidator.Validate(value);
                height = value;
            }
        }

        public decimal FloorArea
        {
            get
            {
                var floorAreaCalculator = new RoomFloorAreaCalculator();
                var area = floorAreaCalculator.Calculate(this);
                return area;
            }
        }

        public decimal VolumeOfPaintRequiredForWalls
        {
            get
            {
                var paintCalculator = new RoomPaintRequiredForWallsCalculator();
                var volumeOfPaint = paintCalculator.Calculate(this);
                return volumeOfPaint;
            }
        }
        public decimal VolumeOfRoom
        {
            get
            {
                var roomVolumeCalculator = new RoomVolumeCalculator();
                var volume = roomVolumeCalculator.Calculate(this);
                return volume;
            }
        }
    }
}
