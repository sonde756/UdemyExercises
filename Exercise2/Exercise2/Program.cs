using System.Globalization;

Console.WriteLine("Digite seu nome completo");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem sua casa?");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Qual valor deste produto?");
double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite seu sobrenome, idade e altura (mesma linha)");
string[] v = Console.ReadLine().Split(' ');
string sobrenome = v[0];
int idade = int.Parse(v[1]);
double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

Console.WriteLine($"Seu nome completo {nomeCompleto}");
Console.WriteLine($"Sua casa tem {quartos}");
Console.WriteLine($"valor do produto é {valorProduto}");

Console.WriteLine($"Seu sobrenome é {sobrenome}, sua idade é {idade} e sua altura é {altura}");



