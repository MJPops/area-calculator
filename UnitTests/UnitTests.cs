using AreaCalculator;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(15)]
        public void GetCircleAreaTest(float radius)
        {
            var result = AreasCalculator.GetArea(radius);

            Assert.IsType<float>(result);
            Assert.Equal((float)Math.PI * radius * radius, result);
        }
        [Fact]
        public void GetCircleAreaTestWhitUncorrectInput()
        {
            Assert.Throws<Exception>(() => AreasCalculator.GetArea(-10));
        }

        [Fact]
        public void GetTriangleAreaTest()
        {
            float halfPerimeter = (3 + 5 + 2) / 2;
            float area = (float)Math.Sqrt(halfPerimeter * (halfPerimeter - 3) *
                (halfPerimeter - 5) *
                (halfPerimeter - 2));

            var result = AreasCalculator.GetArea(3, 5, 2);

            Assert.IsType<float>(result);
            Assert.Equal(area, result);
        }
        [Theory]
        [InlineData(3, 5, 9)]
        [InlineData(-3, 5, 1)]
        public void GetTriangleAreaTestWhitUncorrectInput(float FirstSide, float SecondSide, float ThierdSide)
        {
            Assert.Throws<Exception>(() => AreasCalculator.GetArea(FirstSide, SecondSide, ThierdSide));
        }

        [Theory]
        [InlineData(3, 5, 4)]
        [InlineData(5, 4, 3)]
        [InlineData(4, 3, 5)]
        public void IsRightTriangleTestWithCorrectInput(float FirstSide, float SecondSide, float ThierdSide)
        {
            var result = AreasCalculator.IsRightTriangle(FirstSide, SecondSide, ThierdSide);

            Assert.IsType<bool>(result);
            Assert.True(result);
        }
        [Fact]
        public void IsRightTriangleTestWithUncorrectInput()
        {
            var result = AreasCalculator.IsRightTriangle(3, 5, 2);

            Assert.IsType<bool>(result);
            Assert.False(result);
        }
    }
}
