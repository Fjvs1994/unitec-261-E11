using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestParalelogramoVolumen
    {
        [Theory]
        [InlineData(50, 10, 500)]
        [InlineData(8, 5, 40)]
        [InlineData(36, 4, 144)]
        [InlineData(21, 3, 63)]
        [InlineData(200, 2, 400)]
        [InlineData(2, 10, 20)]
        [InlineData(96, 1, 96)]
        [InlineData(75, 2, 150)]
        [InlineData(500, 2, 1000)]
        [InlineData(10, 5, 50)]
        [InlineData(3, 10, 30)]
        [InlineData(36, 2, 72)]
        [InlineData(55, 4, 220)]
        [InlineData(100, 5, 500)]
        [InlineData(1000, 0.5, 500)]
        [InlineData(13, 10, 130)]
        [InlineData(36, 3, 108)]
        [InlineData(81, 2, 162)]
        [InlineData(70, 1, 70)]
        [InlineData(99, 10, 990)]
        public void TestVolumen(double area, double altura, double esperado)
        {
            double resultado = Paralelogramo.Volumen(area, altura);
            Assert.Equal(esperado, resultado, 3);
        }
    }
}
