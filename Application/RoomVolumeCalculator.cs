namespace Application
{
    public class RoomVolumeCalculator
    {
        public decimal Calculate(Room room)
        {
            var volumeCalculator = new VolumeCalculator();
            var volume = volumeCalculator.Calculate(room.Length, room.Width, room.Height);
            return volume;
        }
    }
}
