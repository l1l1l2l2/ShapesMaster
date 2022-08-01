using System;
using Xunit;
using ShapesMaster;

namespace ShapesMaster.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(-15, 3, 5)]
        [InlineData(5, -3, 7)]
        [InlineData(5, 3, -7)]
        [InlineData(155, 3, 7)]
        [InlineData(132312321.3f, 123123.1f, 312312313122.1f)]

        public void CanThrowUncorrectCreation(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
        [Theory]
        [InlineData(3, 5, 6, 7.483314773547983)]

        public void AreaCorrect(double a, double b, double c, double expect)
        {
            Assert.Equal(expect, new Triangle(a, b, c).Area);
        }
    }
}
