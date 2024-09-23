Console.WriteLine("Digite o nome do vendedor:");
string nomeVendedor = Console.ReadLine();

Console.WriteLine("Digite o salário fixo do vendedor:");
double salarioFixo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o total de vendas efetuadas pelo vendedor:");
double totalVendas = double.Parse(Console.ReadLine());

double comissao = totalVendas * 0.15;
double totalReceber = salarioFixo + comissao;

Console.WriteLine($"TOTAL = R$ {totalReceber:F2}");
