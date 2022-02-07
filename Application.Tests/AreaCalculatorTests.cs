using Xunit;

namespace Application.Tests
{
    public class AreaCalculatorTests
    {
        private readonly AreaCalculator _sut;
        public AreaCalculatorTests()
        {
            _sut = new AreaCalculator();
        }
        [Fact]
        public void Calculate_PositiveInputs_ReturnsArea()
        {
            var actual = _sut.Calculate(2, 3);

            Assert.Equal(6, actual);
        }
    }
}
