double a = 5;      // lado 1
double b = 10;     // lado 2
double altura = 8; // altura del prisma

double perimetro = Application.Paralelogramo.Perimetro(a, b);
double area = Application.Paralelogramo.Area(a, b);
double volumen = Application.Paralelogramo.Volumen(area, altura);

Console.WriteLine($"El perímetro de un paralelogramo de lados {a} cm y {b} cm es {perimetro} cm.");
Console.WriteLine($"El área de un paralelogramo de lados {a} cm y {b} cm es {area} cm2.");
Console.WriteLine($"El volumen de un prisma con base de área {area} cm2 y altura {altura} cm es {volumen} cm3.");
