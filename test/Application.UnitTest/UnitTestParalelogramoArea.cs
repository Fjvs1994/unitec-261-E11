using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestParalelogramoArea
    {
        [Theory]
        [InlineData(5, 10, 50)]
        [InlineData(4, 2, 8)]
        [InlineData(6, 6, 36)]
        [InlineData(3, 7, 21)]
        [InlineData(20, 10, 200)]
        [InlineData(2, 1, 2)]
        [InlineData(12, 8, 96)]
        [InlineData(5, 15, 75)]
        [InlineData(50, 10, 500)]
        [InlineData(2.5, 4, 10)]
        [InlineData(1.5, 2, 3)]
        [InlineData(9, 4, 36)]
        [InlineData(11, 5, 55)]
        [InlineData(5, 20, 100)]
        [InlineData(10, 100, 1000)]
        [InlineData(6.5, 2, 13)]
        [InlineData(3, 12, 36)]
        [InlineData(9, 9, 81)]
        [InlineData(14, 5, 70)]
        [InlineData(99, 1, 99)]
        public void TestArea(double a, double b, double esperado)
        {
            double area = Paralelogramo.Area(a, b);
            Assert.Equal(esperado, area, 3);
        }
    }
}