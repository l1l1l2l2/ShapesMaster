using Xunit;
using ShapesMaster;
using System;

namespace ShapesMaster.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-12.0d)]
        [InlineData(double.MinValue)]
        public void CanThrowUncorrectCreation(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
        [Theory]
        [InlineData(1, 3.141592653589793)]
        [InlineData(1234, 4783879.062809779)]
        [InlineData(12345.5d, 478814441.10095394)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void AreaCorrect(double radius, double expectedArea)
        {
            var area = new Circle(radius).Area;
            Assert.Equal(expectedArea, area);
        }
    }
}