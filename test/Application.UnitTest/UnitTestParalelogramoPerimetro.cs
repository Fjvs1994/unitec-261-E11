using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestParalelogramoPerimetro
    {
        [Theory]
        [InlineData(5, 10, 30)]
        [InlineData(2, 4, 12)]
        [InlineData(6, 6, 24)]
        [InlineData(7, 3, 20)]
        [InlineData(10, 20, 60)]
        [InlineData(1, 2, 6)]
        [InlineData(8, 12, 40)]
        [InlineData(15, 5, 40)]
        [InlineData(50, 50, 200)]
        [InlineData(2.5, 2.5, 10)]
        [InlineData(0.5, 1.5, 4)]
        [InlineData(4, 9, 26)]
        [InlineData(11, 5, 32)]
        [InlineData(20, 5, 50)]
        [InlineData(100, 10, 220)]
        [InlineData(3.5, 6.5, 20)]
        [InlineData(12, 3, 30)]
        [InlineData(9, 9, 36)]
        [InlineData(7, 14, 42)]
        [InlineData(1, 99, 200)]
        public void TestPerimetro(double a, double b, double esperado)
        {
            double perimetro = Paralelogramo.Perimetro(a, b);
            Assert.Equal(esperado, perimetro, 3);
        }
    }
}
