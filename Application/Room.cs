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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                length = value;
            }
        }
        public decimal Width
        {
            get => width; set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                width = value;
            }
        }
        public decimal Height
        {
            get => height; set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                height = value;
            }
        }
    }
}
