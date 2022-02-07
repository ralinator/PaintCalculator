namespace Application
{
    public static class DimensionValidator
    {
        public static decimal Validate(decimal input)
        {
            if (input <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return input;
        }
    }
}
