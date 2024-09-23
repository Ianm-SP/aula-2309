Console.WriteLine("coloque x1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("coloque y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("coloque x2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("coloque y2");
double y2 = double.Parse(Console.ReadLine());

// Cálculo da distância usando a fórmula fornecida
double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// Saída: exibir a distância com 4 casas decimais
Console.WriteLine(distancia.ToString("F4"));