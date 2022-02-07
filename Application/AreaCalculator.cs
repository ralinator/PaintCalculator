namespace Application
{
    public class AreaCalculator
    {
        public decimal Calculate(decimal length, decimal width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var area = length * width;
            return area;
        }
    }
}
