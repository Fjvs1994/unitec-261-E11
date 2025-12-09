# unitec-261-E11
"Application"

using System;

namespace Application
{
    public class Paralelogramo
    {
        public static double Perimetro(double a, double b)
        {
            double perimetro = 2 * a + 2 * b;
            return perimetro;
        }

        public static double Area(double a, double b)
        {
            double area = a * b;
            return area;
        }

        public static double Volumen(double area, double altura)
        {
            double volumen = area * altura;
            return volumen;
        }
    }
}


"ConsoleApp"

double a = 5;      // lado 1
double b = 10;     // lado 2
double altura = 8; // altura del prisma

double perimetro = Application.Paralelogramo.Perimetro(a, b);
double area = Application.Paralelogramo.Area(a, b);
double volumen = Application.Paralelogramo.Volumen(area, altura);

Console.WriteLine($"El perímetro de un paralelogramo de lados {a} cm y {b} cm es {perimetro} cm.");
Console.WriteLine($"El área de un paralelogramo de lados {a} cm y {b} cm es {area} cm2.");
Console.WriteLine($"El volumen de un prisma con base de área {area} cm2 y altura {altura} cm es {volumen} cm3.");


"WebApp"

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.MapRazorPages();
app.Run();

public partial class Program { }


"IntegrationTestParalelogramoVolumen"

using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class IntegrationTestParalelogramoVolumen
    {
        [Theory]
        [InlineData(10, 5, 10, 500)]
        [InlineData(4, 2, 5, 40)]
        [InlineData(6, 6, 2, 72)]
        [InlineData(7, 3, 3, 63)]
        [InlineData(20, 10, 2, 400)]
        [InlineData(2, 1, 10, 20)]
        [InlineData(12, 8, 1, 96)]
        [InlineData(5, 15, 2, 150)]
        [InlineData(50, 10, 2, 1000)]
        [InlineData(2.5, 4, 5, 50)]
        [InlineData(1.5, 2, 10, 30)]
        [InlineData(9, 4, 2, 72)]
        [InlineData(11, 5, 4, 220)]
        [InlineData(5, 20, 5, 500)]
        [InlineData(10, 100, 0.5, 500)]
        [InlineData(6.5, 2, 10, 130)]
        [InlineData(3, 12, 3, 108)]
        [InlineData(9, 9, 2, 162)]
        [InlineData(14, 5, 1, 70)]
        [InlineData(99, 1, 10, 990)]
        public void TestIntegrado(double a, double b, double altura, double esperado)
        {
            double area = Paralelogramo.Area(a, b);
            double volumen = Paralelogramo.Volumen(area, altura);
            
            Assert.Equal(esperado, volumen, 3);
        }
    }
}


"UnitTesParalelogramoArea"

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


"UnitTesParalelogramoPerimetro"

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


"UnitTesParalelogramoVolumen"

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


"WebApp.IntegrationTest"

using Xunit;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApp.IntegrationTest
{
    public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public IntegrationTestPages(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("Index")]
        [InlineData("Privacy")]
        public async Task TestGetPages(string url)
        {
            // Arrange

            // Act
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
