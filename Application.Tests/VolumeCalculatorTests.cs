using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.Tests
{
    public class VolumeCalculatorTests
    {
        private readonly VolumeCalculator _sut;
        public VolumeCalculatorTests()
        {
            _sut = new VolumeCalculator();
        }

        [Fact]
        public void Calculate_PositiveInputs_ReturnsVolume()
        {
            var actual = _sut.Calculate(1, 2, 3);

            Assert.Equal(6, actual);
        }

        [Theory]
        [InlineData(-1, 2, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(0, 2, 1)]
        public void Calculate_InvalidInputs_ThrowsException(decimal length, decimal width, decimal height)
        {
            Action action = () => _sut.Calculate(length, width, height);

            Assert.Throws<DimensionOutOfRangeException>(action);
        }
    }
}
