namespace Application
{
    public class AreaCalculator
    {
        public decimal Calculate(decimal length, decimal width)
        {
            var area = length * width;
            return area;
        }
    }
}
