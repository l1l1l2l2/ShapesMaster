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
        [InlineData(3, 4, 5, 6)]
        [InlineData(3, 5, 6, 7.483314773547883)]
        [InlineData(2, 3, 4, 2.9047375096555625)]
        [InlineData(12345.1f, 10230.5f, 12312.3f, 57379736.43139169)]
        public void AreaCorrect(double a, double b, double c, double expect)
        {
            Assert.Equal(expect, new Triangle(a, b, c).Area);
        }
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(6, 8, 10)]
        public void IsRightCorrectTrue(double a, double b, double c)
        {
            Assert.True(new Triangle(a, b, c).IsRight);
        }
        [Theory]
        [InlineData(3, 7, 5)]
        [InlineData(10, 11, 12)]
        [InlineData(13.3, 15.3, 18.5)]
        public void IsRightCorrectFalse(double a, double b, double c)
        {
            Assert.False(new Triangle(a, b, c).IsRight);
        }
    }
}
