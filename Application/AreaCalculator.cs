namespace Application
{
    public class AreaCalculator
    {
        public decimal Calculate(decimal length, decimal width)
        {
            DimensionValidator.Validate(length);
            DimensionValidator.Validate(width);
            var area = length * width;
            return area;
        }
    }
}
