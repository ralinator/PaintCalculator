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
    }
}
