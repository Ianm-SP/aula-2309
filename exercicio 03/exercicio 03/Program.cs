double pi = 3.14159;

// Leitura dos valores A B C
Console.WriteLine("Digite o valor de A:");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B:");
double B = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de C:");
double C = double.Parse(Console.ReadLine());

// Cálculos das áreas
double areaTriangulo = (A * C) / 2.0;
double areaCirculo = pi * (C * C);
double areaTrapezio = ((A + B) * C) / 2.0;
double areaQuadrado = B * B;
double areaRetangulo = A * B;

// Exibição
Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
