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
                length = value;
            }
        }
        public decimal Width
        {
            get => width; set
            {
                width = value;
            }
        }
        public decimal Height
        {
            get => height; set
            {
                height = value;
            }
        }
    }
}
