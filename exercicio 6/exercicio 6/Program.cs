Console.WriteLine("coloque o nome");
string nome = Console.ReadLine();
Console.WriteLine("coloque o peso");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("coloque a altura");
double altura = double.Parse(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);

Console.WriteLine($"{nome}, seu IMC é {Math.Round(imc)}");