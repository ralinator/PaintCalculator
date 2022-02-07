using System;
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

        [Theory]
        [InlineData(-1, 2)]
        [InlineData(-1, -1)]
        [InlineData(0, -1)]
        [InlineData(0, 2)]
        public void Calculate_InvalidInputs_ThrowsException(decimal length, decimal width)
        {
            Action action = () => _sut.Calculate(length, width);

            Assert.Throws<ArgumentOutOfRangeException>(action);
        }
    }
}
