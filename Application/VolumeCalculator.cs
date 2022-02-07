namespace Application
{
    public class VolumeCalculator
    {
        public decimal Calculate(decimal length, decimal width, decimal height)
        {
            DimensionValidator.Validate(length);
            DimensionValidator.Validate(width);
            DimensionValidator.Validate(height);
            var area = length * width;
            var volume = area * height;
            return volume;
        }
    }
}
